/// <summary>
/// This file is the admin Reports form. It hosts the MostRentedFurnitureControl
/// user control and provides date range filters for running the
/// Most Popular Furniture During Dates report.
/// Only admins can access this form (enforced by AdminDashboardForm).
///
/// Author: Anu Rayini
/// Version: 5/2/2026
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
    /// Admin-only form for running the Most Popular Furniture During Dates report.
    /// Hosts the MostRentedFurnitureControl user control which renders the report data.
    /// </summary>
    public partial class ReportForm : Form
    {
        private Employee loggedInEmployee;
        private ReportController reportController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportForm"/> class.
        /// </summary>
        /// <param name="employee">The currently logged-in employee (must be admin).</param>
        public ReportForm(Employee employee)
        {
            InitializeComponent();
            this.loggedInEmployee = employee;
            this.reportController = new ReportController();
        }

        /// <summary>
        /// This method runs once when the form loads.
        /// Sets up the header and default date range (last 30 days).
        /// </summary>
        private void ReportForm_Load(object sender, EventArgs e)
        {
            string role = loggedInEmployee.IsAdmin ? "Admin" : "Employee";
            lblLoggedIn.Text = $"Logged in as: {loggedInEmployee.FirstName} {loggedInEmployee.LastName} ({role})";

            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Today;
        }

        /// <summary>
        /// This method handles the Run Report button click.
        /// Validates inputs, queries the controller, and displays the data in the user control.
        /// </summary>
        private void btnRunReport_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            try
            {
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                List<FurnitureReportItem> data = reportController.GetMostPopularFurnitureDuringDates(startDate, endDate);
                reportControl.DisplayReport(data, startDate, endDate);

                lblStatus.ForeColor = Color.ForestGreen;
                lblStatus.Text = $"Report generated for {startDate:MM/dd/yyyy} to {endDate:MM/dd/yyyy}.";
            }
            catch (ArgumentException ex)
            {
                reportControl.ClearReport();
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
            catch (Exception ex)
            {
                reportControl.ClearReport();
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Report error: " + ex.Message;
            }
        }

        /// <summary>
        /// This method closes the form and returns to the dashboard.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
