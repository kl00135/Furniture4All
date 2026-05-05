/// <summary>
/// The point of this file is to establish the ReturnTransaction model.
/// This should allow employees to find active rentals, select items for return, and adjust 
/// the return quantity.
///
/// Author: Laken Harville (original file author: Kade Levy)
/// Version: 4/27/2026
/// </summary>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Furniture4AllApp.Controllers;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// This class will allow employees to process returns for members. 
    /// </summary>
    public partial class ReturnForm : Form
    {
        private Employee loggedInEmployee;
        private Member currentMember;

        private List<ActiveRental> activeRentals = new List<ActiveRental>();

        private MemberController memberController = new MemberController();
        private ReturnController returnController = new ReturnController();

        /// <summary>
        /// This method will initialize the form with the logged in employee's information.
        /// </summary>
        /// <param name="employee">The employee who is logged in.</param>
        public ReturnForm(Employee employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
        }

        /// <summary>
        /// This method will run the when the form first loads.
        /// It will setup the header, employee display, build grid columns, and disable the 
        /// Process Return button until a member is selected and items are checked.
        /// </summary>
        private void ReturnForm_Load(object sender, EventArgs e)
        {
            string role = loggedInEmployee.IsAdmin ? "Admin" : "Employee";
            lblLoggedIn.Text = $"Logged in as: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} ({role})";

            lblService.Text = $"Service Employee: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} (E{loggedInEmployee.EmployeeID})";

            SetupReturnGrid();
            UpdateUIState();

            btnLookupMember.Click += btnLookupMember_Click;
            btnProcessReturn.Click += btnProcessReturn_Click;
            btnCancel.Click += btnCancel_Click;
        }

        /// <summary>
        /// This method will replace the designer's grid columns with the following:
        /// A checkbox for returns, an editable "qty to return" column, and live
        /// preview columns for the fine and refunds.
        /// </summary>
        private void SetupReturnGrid()
        {
            dgvReturnCart.Columns.Clear();
            dgvReturnCart.AutoGenerateColumns = false;
            dgvReturnCart.AllowUserToAddRows = false;
            dgvReturnCart.AllowUserToDeleteRows = false;
            dgvReturnCart.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvReturnCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCheckBoxColumn selectCol = new DataGridViewCheckBoxColumn();
            selectCol.Name = "Select";
            selectCol.HeaderText = "Select";
            selectCol.Width = 50;
            dgvReturnCart.Columns.Add(selectCol);

            dgvReturnCart.Columns.Add(MakeReadOnlyCol("RentalID", "Rental ID", 70));
            dgvReturnCart.Columns.Add(MakeReadOnlyCol("ItemID", "Item ID", 60));
            dgvReturnCart.Columns.Add(MakeReadOnlyCol("ItemName", "Name", 130));
            dgvReturnCart.Columns.Add(MakeReadOnlyCol("Remaining", "Out", 50));
            dgvReturnCart.Columns.Add(MakeReadOnlyCol("Rate", "Daily Rate", 80));
            dgvReturnCart.Columns.Add(MakeReadOnlyCol("Rented", "Rented", 80));
            dgvReturnCart.Columns.Add(MakeReadOnlyCol("Due", "Due", 80));

            DataGridViewTextBoxColumn qtyCol = new DataGridViewTextBoxColumn();
            qtyCol.Name = "QtyToReturn";
            qtyCol.HeaderText = "Qty to Return";
            qtyCol.Width = 80;
            qtyCol.ReadOnly = false;
            dgvReturnCart.Columns.Add(qtyCol);

            dgvReturnCart.Columns.Add(MakeReadOnlyCol("Fine", "Fine", 80));
            dgvReturnCart.Columns.Add(MakeReadOnlyCol("Refund", "Refund", 80));

            dgvReturnCart.CellEndEdit += dgvReturnCart_CellEndEdit;
            dgvReturnCart.CurrentCellDirtyStateChanged += dgvReturnCart_CurrentCellDirtyStateChanged;
        }

        /// <summary>
        /// This method will build a read-only text column with name, header, and width.
        /// DRY helper to keep the grid setup cleaner.
        /// </summary>
        private DataGridViewTextBoxColumn MakeReadOnlyCol(string name, string headerText, int width)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = headerText,
                Width = width,
                ReadOnly = true
            };
        }

        /// <summary>
        /// This method will handle the Lookup Member button click. It validates the input, looks up the member,
        /// and loads their active rentals into the grid.
        /// </summary>
        private void btnLookupMember_Click(object sender, EventArgs e)
        {
            int memberId;
            if (!int.TryParse(txtMemberID.Text.Trim(), out memberId))
            {
                lblMemberInfo.ForeColor = Color.Red;
                lblMemberInfo.Text = "Please enter a valid numeric Member ID.";
                currentMember = null;
                ClearGrid();
                UpdateUIState();
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
                    ClearGrid();
                    UpdateUIState();
                    return;
                }

                currentMember = member;
                lblMemberInfo.ForeColor = Color.ForestGreen;
                lblMemberInfo.Text = $"Member: {member.FirstName} {member.LastName} (ID: {member.MemberID})";
                lblEmployee.Text = $"Active Rentals for {member.FirstName} {member.LastName} (ID: {member.MemberID}):";

                LoadActiveRentals(memberId);
            }
            catch (Exception ex)
            {
                currentMember = null;
                lblMemberInfo.ForeColor = Color.Red;
                lblMemberInfo.Text = "Lookup error: " + ex.Message;
                ClearGrid();
            }

            UpdateUIState();
        }

        /// <summary>
        /// This method will load the active rentals for a given member ID and populate the grid.
        /// </summary>
        /// <param name="memberId">The member to load rentals for.</param>
        private void LoadActiveRentals(int memberId)
        {
            ClearGrid();

            try
            {
                activeRentals = returnController.GetActiveRentalsByMemberId(memberId);

                if (activeRentals.Count == 0)
                {
                    lblMemberInfo.ForeColor = Color.OrangeRed;
                    lblMemberInfo.Text += " — No active rentals to return.";
                    return;
                }

                foreach (ActiveRental rental in activeRentals)
                {
                    dgvReturnCart.Rows.Add(
                        false,
                        rental.RentalTransactionID,
                        rental.FurnitureID,
                        rental.FurnitureName,
                        rental.QuantityRemaining,
                        rental.DailyRate.ToString("C2"),
                        rental.RentalDate.ToString("MM/dd/yyyy"),
                        rental.DueDate.ToString("MM/dd/yyyy"),
                        "",
                        "",
                        ""
                    );
                }
            }
            catch (Exception ex)
            {
                lblMemberInfo.ForeColor = Color.Red;
                lblMemberInfo.Text = "Error loading rentals: " + ex.Message;
            }
        }

        /// <summary>
        /// This method clears the grid and the in-memory active rentals list together.
        /// </summary>
        private void ClearGrid()
        {
            dgvReturnCart.Rows.Clear();
            activeRentals.Clear();
        }

        /// <summary>
        /// This method will commit checkbox changes immediately so that the CellEndEdit event can respond to them without waiting for the user to leave the cell.
        /// </summary>
        private void dgvReturnCart_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvReturnCart.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvReturnCart.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        /// <summary>
        /// This method will handle edits to the grid cells. It responds to changes in the "Select" checkbox and the "Qty to Return" cell.
        /// </summary>
        private void dgvReturnCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= activeRentals.Count) return;

            string columnName = dgvReturnCart.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvReturnCart.Rows[e.RowIndex];
            ActiveRental rental = activeRentals[e.RowIndex];

            if (columnName == "Select")
            {
                bool isChecked = Convert.ToBoolean(row.Cells["Select"].Value ?? false);

                if (isChecked && string.IsNullOrWhiteSpace(row.Cells["QtyToReturn"].Value?.ToString()))
                {
                    row.Cells["QtyToReturn"].Value = rental.QuantityRemaining;
                }
                else if (!isChecked)
                {
                    row.Cells["QtyToReturn"].Value = "";
                    row.Cells["Fine"].Value = "";
                    row.Cells["Refund"].Value = "";
                }

                RecomputeRowPreview(e.RowIndex);
            }
            else if (columnName == "QtyToReturn")
            {
                RecomputeRowPreview(e.RowIndex);
            }

            UpdateUIState();
        }

        /// <summary>
        /// This method will recompute the fine and refund preview for a given row index based on the current "Select" and "Qty to Return" values.
        /// It uses the same calculation logic as the controller to ensure consistency.
        /// </summary>
        private void RecomputeRowPreview(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= activeRentals.Count) return;

            DataGridViewRow row = dgvReturnCart.Rows[rowIndex];
            ActiveRental rental = activeRentals[rowIndex];

            bool isChecked = Convert.ToBoolean(row.Cells["Select"].Value ?? false);
            if (!isChecked)
            {
                row.Cells["Fine"].Value = "";
                row.Cells["Refund"].Value = "";
                return;
            }

            int qty;
            string qtyText = row.Cells["QtyToReturn"].Value?.ToString() ?? "";
            if (!int.TryParse(qtyText, out qty) || qty <= 0)
            {
                row.Cells["Fine"].Value = "";
                row.Cells["Refund"].Value = "";
                return;
            }

            if (qty > rental.QuantityRemaining)
            {
                qty = rental.QuantityRemaining;
                row.Cells["QtyToReturn"].Value = qty;
            }

            ReturnLineItem preview = new ReturnLineItem
            {
                FurnitureID = rental.FurnitureID,
                FurnitureName = rental.FurnitureName,
                Quantity = qty,
                DailyRate = rental.DailyRate,
                DueDate = rental.DueDate
            };
            preview.CalculateFineAndRefund(DateTime.Today);

            row.Cells["Fine"].Value = preview.Fine > 0 ? preview.Fine.ToString("C2") : "";
            row.Cells["Refund"].Value = preview.Refund > 0 ? preview.Refund.ToString("C2") : "";
        }

        /// <summary>
        /// This method enables or disables the Process Return button 
        /// based on whether a member is selected and at least one valid item is checked for return.
        /// </summary>
        private void UpdateUIState()
        {
            btnProcessReturn.Enabled = currentMember != null && HasValidSelection();
        }

        /// <summary>
        /// Returns true if at least one row is checked with a valid positive quantity.
        /// </summary>
        private bool HasValidSelection()
        {
            for (int i = 0; i < dgvReturnCart.Rows.Count; i++)
            {
                DataGridViewRow row = dgvReturnCart.Rows[i];
                bool isChecked = Convert.ToBoolean(row.Cells["Select"].Value ?? false);
                if (!isChecked) continue;

                int qty;
                if (int.TryParse(row.Cells["QtyToReturn"].Value?.ToString() ?? "", out qty) && qty > 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// This method will handle the Process Return button click. It validates the selections, constructs a
        /// ReturnTransaction object, and calls the controller to process the return.
        /// </summary>
        private void btnProcessReturn_Click(object sender, EventArgs e)
        {
            
            if (currentMember == null) return;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to process this return?",
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                ReturnTransaction returnTxn = new ReturnTransaction
                {
                    MemberID = currentMember.MemberID,
                    MemberName = $"{currentMember.FirstName} {currentMember.LastName}",
                    EmployeeID = loggedInEmployee.EmployeeID,
                    EmployeeName = $"{loggedInEmployee.FirstName} {loggedInEmployee.LastName}",
                    ReturnDate = DateTime.Today
                };

                for (int i = 0; i < dgvReturnCart.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvReturnCart.Rows[i];
                    bool isChecked = Convert.ToBoolean(row.Cells["Select"].Value ?? false);
                    if (!isChecked) continue;

                    int qty;
                    if (!int.TryParse(row.Cells["QtyToReturn"].Value?.ToString() ?? "", out qty)) continue;
                    if (qty <= 0) continue;

                    ActiveRental rental = activeRentals[i];

                    // Cap qty at what's still out (defensive)
                    if (qty > rental.QuantityRemaining)
                    {
                        qty = rental.QuantityRemaining;
                    }

                    returnTxn.LineItems.Add(new ReturnLineItem
                    {
                        RentalTransactionID = rental.RentalTransactionID,
                        FurnitureID = rental.FurnitureID,
                        FurnitureName = rental.FurnitureName,
                        Quantity = qty,
                        DailyRate = rental.DailyRate,
                        DueDate = rental.DueDate
                    });
                }

                int newReturnId = returnController.CreateReturn(returnTxn);
                returnTxn.ReturnTransactionID = newReturnId;

                ReturnReceiptForm receipt = new ReturnReceiptForm(returnTxn);
                receipt.ShowDialog();

                LoadActiveRentals(currentMember.MemberID);
                UpdateUIState();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Return error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method closes the form and returns to the dashboard.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}