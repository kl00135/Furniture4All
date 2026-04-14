///<summary>
/// This file displays the rental history for a selected member.
/// Employees can look up a member by ID and view all their past rental transactions
/// along with the line items for each transaction.
///
/// Author: Anu Rayini
/// Version: 4/13/2026
/// </summary>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Furniture4AllApp.Controllers;
using Furniture4AllApp.Models;

namespace Furniture4AllApp
{
    /// <summary>
    /// This form allows employees to search for a member and view their rental history.
    /// Selecting a transaction in the top grid shows its line items in the bottom grid.
    /// </summary>
    public partial class RentalHistoryForm : Form
    {
        private Employee loggedInEmployee;
        private MemberController memberController;
        private RentalController rentalController;
        private List<RentalTransaction> rentalHistory;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalHistoryForm"/> class.
        /// </summary>
        /// <param name="employee">The employee who is currently logged in.</param>
        public RentalHistoryForm(Employee employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
            this.memberController = new MemberController();
            this.rentalController = new RentalController();
        }

        /// <summary>
        /// This method will run once when the form appears.
        /// Sets up the logged-in employee display and configures the grids.
        /// </summary>
        private void RentalHistoryForm_Load(object sender, EventArgs e)
        {
            string role = loggedInEmployee.IsAdmin ? "Admin" : "Employee";
            lblLoggedIn.Text = $"Logged in as: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} ({role})";

            SetupTransactionsGrid();
            SetupLineItemsGrid();
        }

        /// <summary>
        /// This method will configure the columns for the transactions grid.
        /// </summary>
        private void SetupTransactionsGrid()
        {
            dgvTransactions.Columns.Clear();
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.ReadOnly = true;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.MultiSelect = false;

            dgvTransactions.Columns.Add("RentalID", "Rental ID");
            dgvTransactions.Columns.Add("RentalDate", "Rental Date");
            dgvTransactions.Columns.Add("DueDate", "Due Date");
            dgvTransactions.Columns.Add("Employee", "Employee");
            dgvTransactions.Columns.Add("TotalCost", "Total Daily Cost");

            dgvTransactions.Columns["RentalID"].Width = 80;
            dgvTransactions.Columns["RentalDate"].Width = 100;
            dgvTransactions.Columns["DueDate"].Width = 100;
            dgvTransactions.Columns["Employee"].Width = 150;
            dgvTransactions.Columns["TotalCost"].Width = 110;

            dgvTransactions.SelectionChanged += dgvTransactions_SelectionChanged;
        }

        /// <summary>
        /// This method will configure the columns for the line items grid.
        /// </summary>
        private void SetupLineItemsGrid()
        {
            dgvLineItems.Columns.Clear();
            dgvLineItems.AutoGenerateColumns = false;
            dgvLineItems.ReadOnly = true;
            dgvLineItems.AllowUserToAddRows = false;
            dgvLineItems.AllowUserToDeleteRows = false;
            dgvLineItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvLineItems.Columns.Add("FurnitureID", "Item ID");
            dgvLineItems.Columns.Add("Name", "Name");
            dgvLineItems.Columns.Add("Quantity", "Qty");
            dgvLineItems.Columns.Add("DailyRate", "Daily Rate");
            dgvLineItems.Columns.Add("Subtotal", "Subtotal");
            dgvLineItems.Columns.Add("QtyReturned", "Qty Returned");

            dgvLineItems.Columns["FurnitureID"].Width = 70;
            dgvLineItems.Columns["Name"].Width = 160;
            dgvLineItems.Columns["Quantity"].Width = 50;
            dgvLineItems.Columns["DailyRate"].Width = 90;
            dgvLineItems.Columns["Subtotal"].Width = 90;
            dgvLineItems.Columns["QtyReturned"].Width = 95;
        }

        /// <summary>
        /// This method will handle the Search button click.
        /// Looks up the member by ID, then retrieves and displays their rental history.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            dgvTransactions.Rows.Clear();
            dgvLineItems.Rows.Clear();
            lblMemberInfo.Text = "";

            int memberId;
            if (!int.TryParse(txtMemberID.Text.Trim(), out memberId))
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please enter a valid numeric Member ID.";
                return;
            }

            try
            {
                Member member = memberController.GetMemberById(memberId);
                if (member == null)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "No member found with that ID.";
                    return;
                }

                lblMemberInfo.ForeColor = Color.ForestGreen;
                lblMemberInfo.Text = $"Member: {member.FirstName} {member.LastName} (ID: {member.MemberID})";

                rentalHistory = rentalController.GetRentalsByMemberId(memberId);

                if (rentalHistory.Count == 0)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "No rental history found for this member.";
                    return;
                }

                foreach (RentalTransaction rental in rentalHistory)
                {
                    dgvTransactions.Rows.Add(
                        rental.RentalTransactionID,
                        rental.RentalDate.ToString("MM/dd/yyyy"),
                        rental.DueDate.ToString("MM/dd/yyyy"),
                        rental.EmployeeName,
                        rental.TotalDailyCost.ToString("C2")
                    );
                }

                lblStatus.ForeColor = Color.ForestGreen;
                lblStatus.Text = $"Found {rentalHistory.Count} rental transaction(s).";
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Search error: " + ex.Message;
            }
        }

        /// <summary>
        /// This method will handle the selection change in the transactions grid.
        /// When a transaction is selected, its line items are displayed in the bottom grid.
        /// </summary>
        private void dgvTransactions_SelectionChanged(object sender, EventArgs e)
        {
            dgvLineItems.Rows.Clear();

            if (dgvTransactions.SelectedRows.Count == 0) return;
            if (rentalHistory == null) return;

            int selectedIndex = dgvTransactions.SelectedRows[0].Index;
            if (selectedIndex < 0 || selectedIndex >= rentalHistory.Count) return;

            RentalTransaction selectedRental = rentalHistory[selectedIndex];

            foreach (RentalLineItem item in selectedRental.LineItems)
            {
                dgvLineItems.Rows.Add(
                    item.FurnitureID,
                    item.FurnitureName,
                    item.Quantity,
                    item.DailyRate.ToString("C2"),
                    item.Subtotal.ToString("C2"),
                    item.QuantityReturned
                );
            }
        }

        /// <summary>
        /// This method will close the form and return to the dashboard.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
