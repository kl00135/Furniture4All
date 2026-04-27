/// <summary>
/// This file will be the display for the receipts for a processed return transaction.
/// It should show the return ID, member, employee, return date. line items
/// with their fines/refunds, and a total summary of the fines/refunds and net amount due or owed.
///
/// Author: Laken Harville
/// Version: 4/27/2026
/// </summary>

using System;
using System.Drawing;
using System.Windows.Forms;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// This class is a read only form that displays the details of a completed return transaction, including line items, fines, refunds, and net amount due or owed
    /// after it is saved.
    /// </summary>
    public partial class ReturnReceiptForm : Form
    {
        private ReturnTransaction returnTxn;

        /// <summary>
        /// This method initializes the receipt form with the return transaction to display.
        /// </summary>
        /// <param name="returnTxn">The completed return, with ID assigned.</param>
        public ReturnReceiptForm(ReturnTransaction returnTxn)
        {
            InitializeComponent();
            this.returnTxn = returnTxn;
        }

        /// <summary>
        /// Populates the receipt fields when the form loads.
        /// </summary>
        private void ReturnReceiptForm_Load(object sender, EventArgs e)
        {
            lblTransactionId.Text = $"Return Transaction ID: RET-{returnTxn.ReturnTransactionID}";
            lblMember.Text = $"Member: {returnTxn.MemberName} (ID: {returnTxn.MemberID})";
            lblEmployee.Text = $"Service Employee: {returnTxn.EmployeeName} (ID: {returnTxn.EmployeeID})";
            lblReturnDate.Text = $"Return Date: {returnTxn.ReturnDate:MM/dd/yyyy}";

            SetupLineItemsGrid();
            PopulateLineItems();

            lblTotalFine.Text = $"Total Fine: {returnTxn.TotalFine:C2}";
            lblTotalRefund.Text = $"Total Refund: {returnTxn.TotalRefund:C2}";

            decimal net = returnTxn.NetAmount;
            if (net > 0)
            {
                lblNetAmount.Text = $"Amount Due: {net:C2}";
                lblNetAmount.ForeColor = Color.DarkRed;
            }
            else if (net < 0)
            {
                lblNetAmount.Text = $"Refund Owed: {Math.Abs(net):C2}";
                lblNetAmount.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblNetAmount.Text = "Net Amount: $0.00";
                lblNetAmount.ForeColor = Color.Black;
            }

            btnClose.Click += btnClose_Click;
        }

        /// <summary>
        /// This method will setup the grid columns for the items.
        /// </summary>
        private void SetupLineItemsGrid()
        {
            dgvLineItems.Columns.Clear();
            dgvLineItems.AutoGenerateColumns = false;
            dgvLineItems.ReadOnly = true;
            dgvLineItems.AllowUserToAddRows = false;
            dgvLineItems.AllowUserToDeleteRows = false;
            dgvLineItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLineItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvLineItems.Columns.Add("ItemID", "Item ID");
            dgvLineItems.Columns.Add("Name", "Name");
            dgvLineItems.Columns.Add("RentalID", "Rental ID");
            dgvLineItems.Columns.Add("Qty", "Qty");
            dgvLineItems.Columns.Add("Rate", "Daily Rate");
            dgvLineItems.Columns.Add("Due", "Due Date");
            dgvLineItems.Columns.Add("Fine", "Fine");
            dgvLineItems.Columns.Add("Refund", "Refund");
        }

        /// <summary>
        /// This method populates the grid from the return's line items.
        /// </summary>
        private void PopulateLineItems()
        {
            foreach (ReturnLineItem item in returnTxn.LineItems)
            {
                dgvLineItems.Rows.Add(
                    item.FurnitureID,
                    item.FurnitureName,
                    item.RentalTransactionID,
                    item.Quantity,
                    item.DailyRate.ToString("C2"),
                    item.DueDate.ToString("MM/dd/yyyy"),
                    item.Fine > 0 ? item.Fine.ToString("C2") : "—",
                    item.Refund > 0 ? item.Refund.ToString("C2") : "—"
                );
            }
        }

        /// <summary>
        /// Closes the receipt form.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}