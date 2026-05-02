/// <summary>
/// This file represents the admin dashboard. After logging in as an admin, the user
/// lands here. From this dashboard the admin can generate reports, manage employees,
/// or jump into the regular employee dashboard to perform employee tasks.
///
/// Author: Anu Rayini
/// Version: 5/2/2026
/// </summary>

using System.Windows.Forms;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// The admin dashboard. Shown only to users with IsAdmin = true.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AdminDashboardForm : Form
    {
        private Employee currentUser;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDashboardForm"/> class.
        /// </summary>
        /// <param name="user">The currently logged-in admin user.</param>
        public AdminDashboardForm(Employee user)
        {
            InitializeComponent();
            this.currentUser = user;
            LoadUserInfo();
        }

        /// <summary>
        /// Populates the header with the logged-in user's name and role.
        /// </summary>
        private void LoadUserInfo()
        {
            NameLabel.Text = currentUser.FirstName + " " + currentUser.LastName;
            RoleLabel.Text = "(Admin)";
        }

        /// <summary>
        /// Handles the LinkClicked event of the LogoutLinkLabel control.
        /// Logs the admin out and returns them to the login screen.
        /// </summary>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the GenerateReportButton control.
        /// Opens the Reports form for generating the Most Popular Furniture report.
        /// </summary>
        private void GenerateReportButton_Click(object sender, System.EventArgs e)
        {
            ReportForm RForm = new ReportForm(currentUser);
            RForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the ManageEmployeesButton control.
        /// Stub for the upcoming Manage Employees feature.
        /// </summary>
        private void ManageEmployeesButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(
                "Manage Employees is coming in a future update.",
                "Coming Soon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the Click event of the EmployeeFunctionsButton control.
        /// Opens the regular Employee Dashboard so the admin can perform employee tasks.
        /// </summary>
        private void EmployeeFunctionsButton_Click(object sender, System.EventArgs e)
        {
            MainForm main = new MainForm(currentUser);
            main.ShowDialog();
        }
    }
}
