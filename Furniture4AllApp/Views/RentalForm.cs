///<summary>
/// The point of this file is to display the rental form.
///
/// Author: Kade Levy
/// Version: 4/11/2026
/// Modified by Laken Harville (4/11/2026): added member lookup, employee display,
/// wired submit to RentalController, fixed Continue Shopping bug, and added receipt flow.
/// </summary>

using Furniture4AllApp.Controllers;
using Furniture4AllApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// Represents a rental form where employees can manage rentals for members. 
    /// This is where we can see the flow. Look up member, add furniture to cart, set due date, submit, and see receipt.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RentalForm : Form
    {
        private Employee loggedInEmployee;
        private Member currentMember;
        private List<CartItem> cartItems = new List<CartItem>();
        private MemberController memberController = new MemberController();
        private RentalController rentalController = new RentalController();

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
        /// This will set up the header, employee display, due date defaults, and cart grid.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RentalForm_Load(object sender, EventArgs e)
        {
            string role = loggedInEmployee.IsAdmin ? "Admin" : "Employee";
            lblLoggedIn.Text = $"Logged in as: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} ({role})";

            lblEmployee.Text = $"Employee: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} (ID: {loggedInEmployee.EmployeeID})";

            dtpDueDate.MinDate = DateTime.Today.AddDays(1);
            dtpDueDate.Value = DateTime.Today.AddDays(7);
            SetupCartGrid();
            UpdateUIState();
        }

        /// <summary>
        /// This method will handle the member button lookup click.
        /// It will look up the member ID and either populated currentMember
        /// or it will show an error if not found.
        /// </summary>
        private void btnLookupMember_Click(object sender, EventArgs e)
        {
            int memberId;
            if (!int.TryParse(txtMemberID.Text.Trim(), out memberId))
            {
                lblMemberInfo.ForeColor = Color.Red;
                lblMemberInfo.Text = "Please enter a valid numeric Member ID.";
                currentMember = null;
                return;
            }

            try
            {
                Member member = memberController.GetMemberById(memberId);
                if (member == null)
                {
                    currentMember = null;
                    lblMemberInfo.ForeColor = Color.Red;
                    lblMemberInfo.Text = "No member found with that ID.";
                }
                else
                {
                    currentMember = member;
                    lblMemberInfo.ForeColor = Color.ForestGreen;
                    lblMemberInfo.Text = $"Member: {member.FirstName} {member.LastName} (ID: {member.MemberID})";
                    lblStatus.Text = "";
                }
            }
            catch (Exception ex)
            {
                currentMember = null;
                lblMemberInfo.ForeColor = Color.Red;
                lblMemberInfo.Text = "Lookup error: " + ex.Message;
            }
            UpdateUIState();
        }

        /// <summary>
        /// This method will enable or disable form controls based on current state.
        /// A member is needed to add furniture and you cannot submit without both
        /// a member and items in the cart.
        /// </summary>
        private void UpdateUIState()
        {
            bool memberSelected = currentMember != null;
            bool hasItems = cartItems.Count > 0;

            btnAddFurniture.Enabled = memberSelected;
            dgvCart.Enabled = memberSelected;
            btnSubmit.Enabled = memberSelected && hasItems;
        }

        /// <summary>
        /// Gets the number of rental days based on the due date.
        /// Ensures at least 1 day is returned.
        /// </summary>
        private int GetRentalDays()
        {
            int days = (dtpDueDate.Value.Date - DateTime.Today).Days;
            return days <= 0 ? 1 : days;
        }

        /// <summary>
        /// Setups the cart grid.
        /// </summary>
        private void SetupCartGrid()
        {
            dgvCart.Columns.Clear();
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvCart.Columns.Add("FurnitureID", "ID");
            dgvCart.Columns.Add("Name", "Name");
            dgvCart.Columns.Add("DailyRate", "Daily Rate");
            dgvCart.Columns.Add("Quantity", "Qty");
            dgvCart.Columns.Add("Subtotal", "Subtotal");

            DataGridViewButtonColumn addBtn = new DataGridViewButtonColumn();
            addBtn.Name = "Add";
            addBtn.HeaderText = "";
            addBtn.Text = "+";
            addBtn.UseColumnTextForButtonValue = true;
            addBtn.Width = 30;
            dgvCart.Columns.Add(addBtn);

            DataGridViewButtonColumn removeOneBtn = new DataGridViewButtonColumn();
            removeOneBtn.Name = "RemoveOne";
            removeOneBtn.HeaderText = "";
            removeOneBtn.Text = "-";
            removeOneBtn.UseColumnTextForButtonValue = true;
            removeOneBtn.Width = 30;
            dgvCart.Columns.Add(removeOneBtn);

            DataGridViewButtonColumn removeAllBtn = new DataGridViewButtonColumn();
            removeAllBtn.Name = "RemoveAll";
            removeAllBtn.HeaderText = "";
            removeAllBtn.Text = "Remove";
            removeAllBtn.UseColumnTextForButtonValue = true;
            removeAllBtn.Width = 70;
            dgvCart.Columns.Add(removeAllBtn);

            dgvCart.CellClick += dgvCart_CellClick;
        }

        /// <summary>
        /// Handles the CellClick event of the dgvCart control.
        /// + will increase the quantity while - will decrease it.
        /// Remove completely takes out the item.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= cartItems.Count) return;

            CartItem item = cartItems[e.RowIndex];
            string columnName = dgvCart.Columns[e.ColumnIndex].Name;

            if (columnName == "Add")
            {
                item.Quantity++;
            }
            else if (columnName == "RemoveOne")
            {
                item.Quantity--;
                if (item.Quantity <= 0)
                {
                    cartItems.RemoveAt(e.RowIndex);
                }
            }
            else if (columnName == "RemoveAll")
            {
                cartItems.RemoveAt(e.RowIndex);
            }
            else
            {
                return; 
            }

            RefreshCartGrid();
            UpdateUIState();
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
                    item.DailyRate.ToString("C2"),
                    item.Quantity,
                    (item.DailyRate * item.Quantity * GetRentalDays()).ToString("C2")
                );
            }

            UpdateTotal();
        }


        /// <summary>
        /// Updates the total.
        /// </summary>
        private void UpdateTotal()
        {
            int days = GetRentalDays();
            decimal total = cartItems.Sum(i => i.DailyRate * i.Quantity * days);
            decimal dailyTotal = cartItems.Sum(i => i.DailyRate * i.Quantity);
            lblTotalCost.Text = total.ToString("C2");
            lblDailyTotal.Text = $"{dailyTotal:C2}";
        }

        /// <summary>
        /// This method will handle the Add Furniture Button click.
        /// It will open SearchFurnitureForm in rental mode, pass the cart by reference so the search
        /// form will add items to it. When the dialogue closes,
        /// we can refresh the grid to show what was added.
        /// </summary>
        private void btnAddFurniture_Click(object sender, EventArgs e)
        {
            if (currentMember == null)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please look up a member before adding furniture.";
                return;
            }

            SearchFurnitureForm searchForm = new SearchFurnitureForm(loggedInEmployee, cartItems);
            searchForm.ShowDialog();

            RefreshCartGrid();
            UpdateUIState();
        }

        /// <summary>
        /// This method will handle the Submit button click.
        /// It will build a RentalTransaction from the cart, validates and saves via the controller,
        /// and open the receipt form on success.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentMember == null)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Please look up a member first.";
                return;
            }
            if (cartItems.Count == 0)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "The cart is empty. Please add at least one item.";
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to submit this rental?",
                "Confirm Rental",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                RentalTransaction rental = new RentalTransaction
                {
                    MemberID = currentMember.MemberID,
                    MemberName = $"{currentMember.FirstName} {currentMember.LastName}",
                    EmployeeID = loggedInEmployee.EmployeeID,
                    EmployeeName = $"{loggedInEmployee.FirstName} {loggedInEmployee.LastName}",
                    RentalDate = DateTime.Today,
                    DueDate = dtpDueDate.Value.Date
                };

                foreach (CartItem cItem in cartItems)
                {
                    rental.LineItems.Add(new RentalLineItem
                    {
                        FurnitureID = cItem.FurnitureId,
                        FurnitureName = cItem.Name,
                        Quantity = cItem.Quantity,
                        DailyRate = cItem.DailyRate
                    });
                }

                int newRentalId = rentalController.CreateRental(rental);
                rental.RentalTransactionID = newRentalId;

                ReceiptForm receipt = new ReceiptForm(rental);
                receipt.ShowDialog();

                ResetForm();
            }
            catch (ArgumentException ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Submit error: " + ex.Message;
            }
        }

        /// <summary>
        /// This method will clear all state for a new transaction.
        /// </summary>
        private void ResetForm()
        {
            cartItems.Clear();
            currentMember = null;
            txtMemberID.Clear();
            lblMemberInfo.Text = "";
            lblStatus.Text = "";
            dtpDueDate.Value = DateTime.Today.AddDays(7);
            RefreshCartGrid();
            UpdateUIState();
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
    }
}
