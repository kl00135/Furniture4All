/// <summary>
/// This file is the user control that renders the "Most Rented Furniture" report.
/// It displays a summary section and a grid of furniture items with rental statistics.
/// The user control is hosted inside ReportForm.
///
/// Author: Anu Rayini
/// Version: 4/27/2026
/// </summary>

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// User control that displays the Most Rented Furniture report.
    /// The hosting form passes in a list of FurnitureReportItem and the control
    /// handles all the rendering (summary stats + grid).
    /// </summary>
    public partial class MostRentedFurnitureControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MostRentedFurnitureControl"/> class.
        /// </summary>
        public MostRentedFurnitureControl()
        {
            InitializeComponent();
            SetupGrid();
        }

        /// <summary>
        /// This method will configure the columns for the report grid.
        /// </summary>
        private void SetupGrid()
        {
            dgvReport.Columns.Clear();
            dgvReport.AutoGenerateColumns = false;
            dgvReport.ReadOnly = true;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvReport.Columns.Add("FurnitureID", "ID");
            dgvReport.Columns.Add("Name", "Name");
            dgvReport.Columns.Add("Category", "Category");
            dgvReport.Columns.Add("DailyRate", "Daily Rate");
            dgvReport.Columns.Add("TotalQty", "Total Qty Rented");
            dgvReport.Columns.Add("TxnCount", "# Transactions");
            dgvReport.Columns.Add("Revenue", "Estimated Revenue");

            dgvReport.Columns["FurnitureID"].Width = 50;
            dgvReport.Columns["Name"].Width = 160;
            dgvReport.Columns["Category"].Width = 100;
            dgvReport.Columns["DailyRate"].Width = 90;
            dgvReport.Columns["TotalQty"].Width = 110;
            dgvReport.Columns["TxnCount"].Width = 100;
            dgvReport.Columns["Revenue"].Width = 130;
        }

        /// <summary>
        /// This method displays the report data in the user control.
        /// Called by the hosting form after running the report query.
        /// </summary>
        /// <param name="items">The aggregated report rows.</param>
        public void DisplayReport(List<FurnitureReportItem> items)
        {
            dgvReport.Rows.Clear();

            int totalItems = 0;
            int totalQty = 0;
            decimal totalRevenue = 0;

            if (items != null)
            {
                foreach (FurnitureReportItem row in items)
                {
                    dgvReport.Rows.Add(
                        row.FurnitureID,
                        row.Name,
                        row.Category,
                        row.DailyRate.ToString("C2"),
                        row.TotalQuantityRented,
                        row.TransactionCount,
                        row.EstimatedRevenue.ToString("C2")
                    );

                    totalItems++;
                    totalQty += row.TotalQuantityRented;
                    totalRevenue += row.EstimatedRevenue;
                }
            }

            lblTotalItemsValue.Text = totalItems.ToString();
            lblTotalQtyValue.Text = totalQty.ToString();
            lblTotalRevenueValue.Text = totalRevenue.ToString("C2");

            if (totalItems == 0)
            {
                lblNoData.Visible = true;
            }
            else
            {
                lblNoData.Visible = false;
            }
        }

        /// <summary>
        /// This method clears the report display.
        /// </summary>
        public void ClearReport()
        {
            dgvReport.Rows.Clear();
            lblTotalItemsValue.Text = "0";
            lblTotalQtyValue.Text = "0";
            lblTotalRevenueValue.Text = "$0.00";
            lblNoData.Visible = false;
        }
    }
}
