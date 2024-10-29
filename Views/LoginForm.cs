using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFLoginRegister.ModelViews;

namespace WFLoginRegister.Views
{
    public partial class LoginForm : Form
    {
        private UserMV userMV = new UserMV();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (userMV.LoginUser(username, password))
            {
                MessageBox.Show("Login successful!");
                // Navigate to main application form
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); // Optional: hide the login form
        }
    }
}
