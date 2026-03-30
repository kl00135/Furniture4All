///<summary>
/// The point of this file is to set up the design for the search member page.
/// 
/// Author: Laken Harville
/// Version: 3/30/2026
/// </summary>

using System;
using System.Drawing;
using System.Windows.Forms;
using Furniture4AllApp.Controllers;
using Furniture4AllApp.Models;

namespace Furniture4AllApp
{
    /// <summary>
    /// This method will allow employees to search for members
    /// </summary>
    public partial class SearchEditMemberForm : Form
    {
        private Employee loggedInEmployee;
        private MemberController memberController;

        private Member currentMember;

        /// <summary>
        /// This method initializes the form with the currently logged-in employee.
        /// </summary>
        /// <param name="employee">The employee who is currently logged in.</param>
        public SearchEditMemberForm(Employee employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
            this.memberController = new MemberController();
        }

        /// <summary>
        /// This mehtod will run once when the form appears.
        /// </summary>
        private void SearchEditMemberForm_Load(object sender, EventArgs e)
        {
            string role = loggedInEmployee.IsAdmin ? "Admin" : "Employee";
            lblLoggedIn.Text = $"Logged in as: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} ({role})";

            cmbSearchBy.Items.AddRange(new string[]
            {
                "Member ID",
                "Phone Number",
                "First + Last Name"
            });
            cmbSearchBy.SelectedIndex = 0;

            cmbSex.Items.AddRange(new string[] { "M", "F" });

            cmbState.Items.AddRange(new string[]
            {
                "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
                "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
                "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
                "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
            });

            SetDetailFieldsEnabled(false);

            lblSearchValue2.Visible = false;
            txtSearchValue2.Visible = false;
        }

        /// <summary>
        /// This method will handle any changes to the dropdown.
        /// </summary>
        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedItem == null) return;

            string selected = cmbSearchBy.SelectedItem.ToString();

            if (selected == "First + Last Name")
            {
                lblSearchValue.Text = "First Name:";
                lblSearchValue2.Visible = true;
                txtSearchValue2.Visible = true;
            }
            else
            {
                lblSearchValue.Text = "Search Value:";
                lblSearchValue2.Visible = false;
                txtSearchValue2.Visible = false;
                txtSearchValue2.Clear();
            }

            txtSearchValue.Clear();
            ClearDetailFields();
            SetDetailFieldsEnabled(false);
            lblStatus.Text = "";
        }

        /// <summary>
        /// This mehtod will handle the search button clicks.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            Member member = null;

            if (cmbSearchBy.SelectedItem == null) return;
            string searchType = cmbSearchBy.SelectedItem.ToString();

            try
            {
                if (searchType == "Member ID")
                {

                    int id;
                    if (!int.TryParse(txtSearchValue.Text.Trim(), out id))
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Please enter a valid numeric Member ID.";
                        return;
                    }
                    member = memberController.GetMemberById(id);
                }
                else if (searchType == "Phone Number")
                {
                    string phone = txtSearchValue.Text.Trim();
                    if (string.IsNullOrWhiteSpace(phone))
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Please enter a phone number.";
                        return;
                    }
                    member = memberController.GetMemberByPhone(phone);
                }
                else 
                {
                    string firstName = txtSearchValue.Text.Trim();
                    string lastName = txtSearchValue2.Text.Trim();
                    if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "Please enter both first and last name.";
                        return;
                    }
                    member = memberController.GetMemberByName(firstName, lastName);
                }

                if (member != null)
                {
                    currentMember = member;
                    PopulateDetailFields(member);
                    SetDetailFieldsEnabled(true);
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = $"Member found: {member.FirstName} {member.LastName} (ID: {member.MemberID})";
                }
                else
                {
                    currentMember = null;
                    ClearDetailFields();
                    SetDetailFieldsEnabled(false);
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "No member found matching the search criteria.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Search error: " + ex.Message;
            }
        }

        /// <summary>
        /// This method will handle the saved changes button click.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentMember == null)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "No member is loaded. Please search for a member first.";
                return;
            }

            try
            {

                Member updatedMember = new Member
                {
                    MemberID = currentMember.MemberID,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Sex = cmbSex.SelectedItem?.ToString() ?? "",
                    DateOfBirth = dtpDOB.Value.Date,
                    Address = txtAddress.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    State = cmbState.SelectedItem?.ToString() ?? "",
                    Zip = txtZip.Text.Trim(),
                    Phone = txtPhone.Text.Trim()
                };

                bool success = memberController.UpdateMember(updatedMember);

                if (success)
                {
                    currentMember = updatedMember;
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Member updated successfully!";
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Update failed. The member may have been deleted.";
                }
            }
            catch (ArgumentException ex) { 

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "An error occurred: " + ex.Message;
            }
        }

        /// <summary>
        /// This method will update the detail fields for the member.
        /// </summary>
        /// <param name="member">The member whose data should fill the form.</param>
        private void PopulateDetailFields(Member member)
        {
            txtMemberID.Text = member.MemberID.ToString();
            txtFirstName.Text = member.FirstName;
            txtLastName.Text = member.LastName;
            cmbSex.SelectedItem = member.Sex;
            dtpDOB.Value = member.DateOfBirth;
            txtAddress.Text = member.Address;
            txtCity.Text = member.City;
            cmbState.SelectedItem = member.State;
            txtZip.Text = member.Zip;
            txtPhone.Text = member.Phone;
        }

        /// <summary>
        /// This method will clear any details of the member.
        /// </summary>
        private void ClearDetailFields()
        {
            txtMemberID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbSex.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
            txtAddress.Clear();
            txtCity.Clear();
            cmbState.SelectedIndex = -1;
            txtZip.Clear();
            txtPhone.Clear();
        }

        /// <summary>
        /// This method should enable or disable detail fields and the save button.
        /// Member ID should be read only.
        /// </summary>
        /// <param name="enabled">True to enable editing, false to disable.</param>
        private void SetDetailFieldsEnabled(bool enabled)
        {
            txtMemberID.ReadOnly = true;

            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
            cmbSex.Enabled = enabled;
            dtpDOB.Enabled = enabled;
            txtAddress.Enabled = enabled;
            txtCity.Enabled = enabled;
            cmbState.Enabled = enabled;
            txtZip.Enabled = enabled;
            txtPhone.Enabled = enabled;
            btnSave.Enabled = enabled;
        }

        /// <summary>
        /// This method will close the form and return the user back to the dashboard.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}