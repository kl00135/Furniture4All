///<summary>
/// The point of this file is to create a view for the customers to see and interact with.
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
    /// This class is going to allow the employees to register new members into the system.
    /// Information collection, MemberController logic validation, and inserts data into database.
    /// </summary>
    public partial class RegisterMemberForm : Form
    {
        private Employee loggedInEmployee;
        private MemberController memberController;

        /// <summary>
        /// This method will initialize the form with an employee if they are logged in.
        /// The employee should be passed from the MainForm so we can see their name on the screen.
        /// </summary>
        /// <param name="employee">The employee who is currently logged in.</param>
        public RegisterMemberForm(Employee employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
            this.memberController = new MemberController();
        }

        /// <summary>
        /// This method will run when the form appears first.
        /// This is where we can populate the Combobox dropdown options.
        /// </summary>
        private void RegisterMemberForm_Load(object sender, EventArgs e)
        {
            
            string role = loggedInEmployee.IsAdmin ? "Admin" : "Employee";
            lblLoggedIn.Text = $"Logged in as: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} ({role})";

            // Binary sex selection
            cmbSex.Items.AddRange(new string[] { "M", "F" });

            // U.S. State selection
            cmbState.Items.AddRange(new string[]
            {
                "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
                "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
                "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
                "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
            });
        }

        /// <summary>
        /// This method willhandle the Register button click.
        /// We should be able to see error messages or successes when this is activated.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = new Member
                {
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

                int newId = memberController.RegisterMember(member);

                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = $"Success! Member registered. Member ID: {newId}";
            }
            catch (ArgumentException ex)
            {
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
        /// This method should make it to where information is erased when "Clear" is clicked.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbSex.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
            txtAddress.Clear();
            txtCity.Clear();
            cmbState.SelectedIndex = -1;
            txtZip.Value = 0;
            txtPhone.Clear();
            lblStatus.Text = "";
        }

        /// <summary>
        /// This method should allow for the form to be closed and the user returned to the dashboard.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}