using System.Windows.Forms;
using Furniture4AllApp.Models;

namespace Furniture4AllApp.Views
{
    /// <summary>
    /// The Mainform where 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        private Employee currentUser;
        public MainForm(Employee user)
        {
            InitializeComponent();
            currentUser = user;
            LoadUserInfo();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the LinkClicked event of the LogoutLinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        /// <summary>
        /// Loads the user information.
        /// </summary>
        private void LoadUserInfo()
        {
            NameLabel.Text = currentUser.FirstName + " " + currentUser.LastName;

            if (currentUser.IsAdmin)
            {
                RoleLabel.Text = "(Admin)";
            }
            else
            {
                RoleLabel.Text = "(Employee)";
            }
        }
    }
}
