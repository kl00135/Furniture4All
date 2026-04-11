///<summary>
/// The point of this file is to allow users to log in to the application.
///
/// Author: Kade Levy
/// Version: 4/11/2026
/// </summary>

using Furniture4AllApp.Controllers;
using Furniture4AllApp.Views;
using System.Windows.Forms;

namespace Furniture4AllApp
{
    /// <summary>
    /// The login form that allows users to log in to the application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the LoginButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            AuthController controller = new AuthController();

            var emp = controller.Login(UsernameTextbox.Text, PasswordTextbox.Text);

            if (emp != null)
            {
                MainForm main = new MainForm(emp);
                main.Show();
                this.Hide();
            }
            else
            {
                ErrorLabel.Text = "Invalid username or password.";
                ErrorLabel.Visible = true;
            }
        }
    }
}
