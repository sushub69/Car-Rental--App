using System;
using System.Windows.Forms;
using WeAreCars.Models;
using WeAreCars.Services;

namespace WeAreCars.Forms
{
    public partial class LoginForm : Form
    {
        private readonly RentalManager rentalManager;
        private int failedAttempts = 0;
        private const int MaxAttempts = 3;

        public LoginForm(RentalManager rentalManager)
        {
            InitializeComponent();
            this.rentalManager = rentalManager;
            UiHelper.RoundTextBox(txtUsername);
            UiHelper.RoundTextBox(txtPassword);
            lblError.Visible = false;   // hidden until a login actually fails
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Empty-field checks (not counted as failed attempts)
            if (username.Length == 0 && password.Length == 0)
            {
                lblError.Text = "Please enter your username and password.";
                lblError.Visible = true;
                txtUsername.Focus();
                return;
            }
            if (username.Length == 0)
            {
                lblError.Text = "Please enter your username.";
                lblError.Visible = true;
                txtUsername.Focus();
                return;
            }
            if (password.Length == 0)
            {
                lblError.Text = "Please enter your password.";
                lblError.Visible = true;
                txtPassword.Focus();
                return;
            }

            if (Staff.ValidateLogin(username, password))
            {
                lblError.Visible = false;

                using (DashboardForm dashboard = new DashboardForm(rentalManager))
                {
                    dashboard.ShowDialog();
                }

                this.Close();   // dashboard closed (logout), so close login too
            }
            else
            {
                failedAttempts++;

                if (failedAttempts >= MaxAttempts)
                {
                    lblError.Text = "Account locked. Please contact your system administrator.";
                    lblError.Visible = true;
                    btnLogin.Enabled = false;
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                }
                else
                {
                    lblError.Text = $"Invalid username or password. Attempt {failedAttempts} of {MaxAttempts}.";
                    lblError.Visible = true;
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void chckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;

            // Switch the masking off or on; setting both covers either way the box was configured
            txtPassword.UseSystemPasswordChar = !show;
            txtPassword.PasswordChar = show ? '\0' : '*';   // '\0' means "no masking character"
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}