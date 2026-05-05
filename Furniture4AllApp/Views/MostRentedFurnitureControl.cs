/// <summary>
/// This file is the user control that renders the "Most Popular Furniture During Dates" report.
/// It displays a header with date range info plus a grid of furniture items with rental
/// statistics and member age demographics.
///
/// The user control is hosted inside ReportForm.
///
/// Author: Anu Rayini
/// Version: 5/2/2026
/// </summary>

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// User control that displays the Most Popular Furniture During Dates report.
    /// The hosting form passes in a list of FurnitureReportItem and date range.
    /// The control handles all the rendering.
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

            dgvReport.Columns.Add("FurnitureID", "Furn ID");
            dgvReport.Columns.Add("Category", "Category");
            dgvReport.Columns.Add("Name", "Name");
            dgvReport.Columns.Add("RentalCount", "# Rentals");
            dgvReport.Columns.Add("TotalCount", "Total Trans");
            dgvReport.Columns.Add("PercentRentals", "% Rentals");
            dgvReport.Columns.Add("PercentAge1829", "% Age 18-29");
            dgvReport.Columns.Add("PercentAgeOther", "% Other");

            dgvReport.Columns["FurnitureID"].Width = 60;
            dgvReport.Columns["Category"].Width = 90;
            dgvReport.Columns["Name"].Width = 160;
            dgvReport.Columns["RentalCount"].Width = 70;
            dgvReport.Columns["TotalCount"].Width = 80;
            dgvReport.Columns["PercentRentals"].Width = 80;
            dgvReport.Columns["PercentAge1829"].Width = 90;
            dgvReport.Columns["PercentAgeOther"].Width = 70;
        }

        /// <summary>
        /// This method displays the report data in the user control.
        /// Called by the hosting form after running the report query.
        /// </summary>
        /// <param name="items">The aggregated report rows.</param>
        /// <param name="startDate">The start of the report date range.</param>
        /// <param name="endDate">The end of the report date range.</param>
        public void DisplayReport(List<FurnitureReportItem> items, DateTime startDate, DateTime endDate)
        {
            dgvReport.Rows.Clear();

            int totalTrans = 0;
            int qualifiedItems = 0;

            if (items != null)
            {
                foreach (FurnitureReportItem row in items)
                {
                    dgvReport.Rows.Add(
                        row.FurnitureID,
                        row.Category,
                        row.Name,
                        row.RentalCount,
                        row.TotalRentalCount,
                        row.PercentRentals.ToString("F2") + "%",
                        row.PercentAge1829.ToString("F2") + "%",
                        row.PercentAgeOther.ToString("F2") + "%"
                    );

                    qualifiedItems++;
                    totalTrans = row.TotalRentalCount;
                }
            }

            lblDateRangeValue.Text = $"{startDate:MM/dd/yyyy} to {endDate:MM/dd/yyyy}";
            lblTotalTransValue.Text = totalTrans.ToString();
            lblQualifiedItemsValue.Text = qualifiedItems.ToString();

            lblNoData.Visible = qualifiedItems == 0;
        }

        /// <summary>
        /// This method clears the report display.
        /// </summary>
        public void ClearReport()
        {
            dgvReport.Rows.Clear();
            lblDateRangeValue.Text = "-";
            lblTotalTransValue.Text = "0";
            lblQualifiedItemsValue.Text = "0";
            lblNoData.Visible = false;
        }
    }
}
