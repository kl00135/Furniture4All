///<summary>
/// This file displays the return history for a selected member.
/// Employees can look up a member by ID and view all their past return transactions
/// along with the line items for each return.
///
/// Author: Anu Rayini
/// Version: 4/27/2026
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
    /// This form allows employees to search for a member and view their return history.
    /// Selecting a return transaction in the top grid shows its line items in the bottom grid.
    /// </summary>
    public partial class ReturnHistoryForm : Form
    {
        private Employee loggedInEmployee;
        private MemberController memberController;
        private ReturnController returnController;
        private List<ReturnTransaction> returnHistory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnHistoryForm"/> class.
        /// </summary>
        /// <param name="employee">The employee who is currently logged in.</param>
        public ReturnHistoryForm(Employee employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
            this.memberController = new MemberController();
            this.returnController = new ReturnController();
        }

        /// <summary>
        /// This method will run once when the form appears.
        /// Sets up the logged-in employee display and configures the grids.
        /// </summary>
        private void ReturnHistoryForm_Load(object sender, EventArgs e)
        {
            string role = loggedInEmployee.IsAdmin ? "Admin" : "Employee";
            lblLoggedIn.Text = $"Logged in as: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} ({role})";

            SetupTransactionsGrid();
            SetupLineItemsGrid();
        }

        /// <summary>
        /// This method will configure the columns for the return transactions grid.
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

            dgvTransactions.Columns.Add("ReturnID", "Return ID");
            dgvTransactions.Columns.Add("ReturnDate", "Return Date");
            dgvTransactions.Columns.Add("Employee", "Employee");
            dgvTransactions.Columns.Add("TotalFine", "Total Fine");
            dgvTransactions.Columns.Add("TotalRefund", "Total Refund");
            dgvTransactions.Columns.Add("NetAmount", "Net Amount");

            dgvTransactions.Columns["ReturnID"].Width = 80;
            dgvTransactions.Columns["ReturnDate"].Width = 100;
            dgvTransactions.Columns["Employee"].Width = 150;
            dgvTransactions.Columns["TotalFine"].Width = 90;
            dgvTransactions.Columns["TotalRefund"].Width = 100;
            dgvTransactions.Columns["NetAmount"].Width = 100;

            dgvTransactions.SelectionChanged += dgvTransactions_SelectionChanged;
        }

        /// <summary>
        /// This method will configure the columns for the return line items grid.
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
            dgvLineItems.Columns.Add("RentalID", "Rental ID");
            dgvLineItems.Columns.Add("Quantity", "Qty");
            dgvLineItems.Columns.Add("Fine", "Fine");
            dgvLineItems.Columns.Add("Refund", "Refund");

            dgvLineItems.Columns["FurnitureID"].Width = 70;
            dgvLineItems.Columns["Name"].Width = 160;
            dgvLineItems.Columns["RentalID"].Width = 80;
            dgvLineItems.Columns["Quantity"].Width = 50;
            dgvLineItems.Columns["Fine"].Width = 90;
            dgvLineItems.Columns["Refund"].Width = 90;
        }

        /// <summary>
        /// This method will handle the Search button click.
        /// Looks up the member by ID, then retrieves and displays their return history.
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

                returnHistory = returnController.GetReturnsByMemberId(memberId);

                if (returnHistory.Count == 0)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "No return history found for this member.";
                    return;
                }

                foreach (ReturnTransaction returnTxn in returnHistory)
                {
                    dgvTransactions.Rows.Add(
                        returnTxn.ReturnTransactionID,
                        returnTxn.ReturnDate.ToString("MM/dd/yyyy"),
                        returnTxn.EmployeeName,
                        returnTxn.TotalFine.ToString("C2"),
                        returnTxn.TotalRefund.ToString("C2"),
                        returnTxn.NetAmount.ToString("C2")
                    );
                }

                lblStatus.ForeColor = Color.ForestGreen;
                lblStatus.Text = $"Found {returnHistory.Count} return transaction(s).";
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Search error: " + ex.Message;
            }
        }

        /// <summary>
        /// This method will handle the selection change in the transactions grid.
        /// When a return transaction is selected, its line items are displayed in the bottom grid.
        /// </summary>
        private void dgvTransactions_SelectionChanged(object sender, EventArgs e)
        {
            dgvLineItems.Rows.Clear();

            if (dgvTransactions.SelectedRows.Count == 0) return;
            if (returnHistory == null) return;

            int selectedIndex = dgvTransactions.SelectedRows[0].Index;
            if (selectedIndex < 0 || selectedIndex >= returnHistory.Count) return;

            ReturnTransaction selectedReturn = returnHistory[selectedIndex];

            foreach (ReturnLineItem item in selectedReturn.LineItems)
            {
                dgvLineItems.Rows.Add(
                    item.FurnitureID,
                    item.FurnitureName,
                    item.RentalTransactionID,
                    item.Quantity,
                    item.Fine.ToString("C2"),
                    item.Refund.ToString("C2")
                );
            }
        }

        /// <summary>
        /// This method will close the form and return to the previous form.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
