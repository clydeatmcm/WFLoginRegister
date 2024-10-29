using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFLoginRegister.Models;
using WFLoginRegister.ModelViews;

namespace WFLoginRegister.Views
{
    public partial class RegisterForm : Form
    {
        private UserMV userMV = new UserMV();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserModel newUser = new UserModel
            {
                Username = txtNewUsername.Text,
                PasswordHash = txtNewPassword.Text
            };

            userMV.RegisterUser(newUser);
            MessageBox.Show("Registration successful!");
            this.Close();
            new LoginForm().Show();
        }
    }
}
