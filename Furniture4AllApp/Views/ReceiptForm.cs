///<summary>
/// Displays the receipt for a successfully submitted rental transaction.
/// Shows the rental ID, member, employee, dates, line items, and total cost.
///
/// Author: Laken Harville
/// Version: 4/12/2026
/// </summary>

using System;
using System.Windows.Forms;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// Read-only form that displays a rental receipt after the transaction is saved.
    /// Receives a fully populated RentalTransaction (including the new ID) and
    /// displays it in a printable-looking format.
    /// </summary>
    public partial class ReceiptForm : Form
    {
        private RentalTransaction rental;

        /// <summary>
        /// Initializes the receipt form with the rental transaction to display.
        /// </summary>
        /// <param name="rental">The completed rental with ID assigned.</param>
        public ReceiptForm(RentalTransaction rental)
        {
            InitializeComponent();
            this.rental = rental;
        }

        /// <summary>
        /// Populates all the receipt fields when the form loads.
        /// </summary>
        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            lblTransactionId.Text = $"Rental Transaction ID: RT-{rental.RentalTransactionID}";
            lblMember.Text = $"Member: {rental.MemberName} (ID: {rental.MemberID})";
            lblEmployee.Text = $"Employee: {rental.EmployeeName} (ID: {rental.EmployeeID})";
            lblRentalDate.Text = $"Rental Date: {rental.RentalDate:MM/dd/yyyy}";
            lblDueDate.Text = $"Due Date: {rental.DueDate:MM/dd/yyyy}";

            SetupLineItemsGrid();
            PopulateLineItems();

            lblTotal.Text = $"Total Daily Cost: {rental.TotalDailyCost:C2}";
        }

        /// <summary>
        /// Sets up the read-only grid columns for the receipt's line items.
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

            dgvLineItems.Columns.Add("FurnitureID", "Item ID");
            dgvLineItems.Columns.Add("Name", "Name");
            dgvLineItems.Columns.Add("Quantity", "Qty");
            dgvLineItems.Columns.Add("DailyRate", "Daily Rate");
            dgvLineItems.Columns.Add("DueDate", "Due Date");
            dgvLineItems.Columns.Add("Subtotal", "Subtotal");
        }

        /// <summary>
        /// Fills the grid from the rental's line items.
        /// </summary>
        private void PopulateLineItems()
        {
            foreach (RentalLineItem item in rental.LineItems)
            {
                dgvLineItems.Rows.Add(
                    item.FurnitureID,
                    item.FurnitureName,
                    item.Quantity,
                    item.DailyRate.ToString("C2"),
                    rental.DueDate.ToString("MM/dd/yyyy"),
                    item.Subtotal.ToString("C2")
                );
            }
        }

        /// <summary>
        /// Closes the receipt form, returning to the rental form which
        /// has already been reset for the next transaction.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}