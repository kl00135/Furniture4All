///<summary>
/// The point of this file is to display the rental form.
///
/// Author: Kade Levy
/// Version: 4/11/2026
/// </summary>

using Furniture4AllApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// Represents a rental form where employees can manage rentals for members. 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RentalForm : Form
    {
        private Employee loggedInEmployee;
        private Member currentMember;
        private List<CartItem> cartItems = new List<CartItem>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalForm"/> class.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <param name="member">The member.</param>
        public RentalForm(Employee employee)
        {
            InitializeComponent();
            loggedInEmployee = employee;
            
        }

        /// <summary>
        /// Handles the Load event of the RentalForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RentalForm_Load(object sender, EventArgs e)
        {
            SetupCartGrid();
        }

        /// <summary>
        /// Setups the cart grid.
        /// </summary>
        private void SetupCartGrid()
        {
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add("FurnitureID", "ID");
            dgvCart.Columns.Add("Name", "Name");
            dgvCart.Columns.Add("DailyRate", "Daily Rate");
            dgvCart.Columns.Add("Quantity", "Qty");
            dgvCart.Columns.Add("Subtotal", "Subtotal");

            DataGridViewButtonColumn addBtn = new DataGridViewButtonColumn();
            addBtn.Name = "Add";
            addBtn.Text = "+";
            addBtn.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(addBtn);

            DataGridViewButtonColumn removeOneBtn = new DataGridViewButtonColumn();
            removeOneBtn.Name = "RemoveOne";
            removeOneBtn.Text = "-";
            removeOneBtn.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(removeOneBtn);

            DataGridViewButtonColumn removeAllBtn = new DataGridViewButtonColumn();
            removeAllBtn.Name = "RemoveAll";
            removeAllBtn.Text = "Remove";
            removeAllBtn.UseColumnTextForButtonValue = true;
            dgvCart.Columns.Add(removeAllBtn);

            dgvCart.CellClick += dgvCart_CellClick;
        }

        /// <summary>
        /// Handles the CellClick event of the dgvCart control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = cartItems[e.RowIndex];

            string columnName = dgvCart.Columns[e.ColumnIndex].Name;

            if (columnName == "Add")
            {
                item.Quantity++;
            }
            else if (columnName == "RemoveOne")
            {
                item.Quantity--;

                if (item.Quantity <= 0)
                    cartItems.RemoveAt(e.RowIndex);
            }
            else if (columnName == "RemoveAll")
            {
                cartItems.RemoveAt(e.RowIndex);
            }

            RefreshCartGrid();
        }

        /// <summary>
        /// Refreshes the cart grid.
        /// </summary>
        private void RefreshCartGrid()
        {
            dgvCart.Rows.Clear();

            foreach (var item in cartItems)
            {
                dgvCart.Rows.Add(
                    item.FurnitureId,
                    item.Name,
                    item.DailyRate.ToString("C"),
                    item.Quantity,
                    item.Subtotal.ToString("C")
                );
            }

            UpdateTotal();
        }


        /// <summary>
        /// Updates the total.
        /// </summary>
        private void UpdateTotal()
        {
            decimal total = cartItems.Sum(i => i.Subtotal);
            lblTotalCost.Text = $"Total Daily Cost: {total:C}";
        }


        /// <summary>
        /// Handles the Click event of the btnContinueShopping control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            SearchFurnitureForm SFForm = new SearchFurnitureForm(loggedInEmployee);
            SFForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnSubmit control. WIP - NON FUNCTIONAL
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
