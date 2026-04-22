using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUser.Text == "" || txtLoginPassword.Text == "")
            {
                MessageBox.Show("Please enter your Username and Password.");
                return;
            }

            User myUser = new User
            {
                UserName = txtLoginUser.Text.Trim(),
                UserPassword = txtLoginPassword.Text.Trim()
            };

            VerifyUser controller = new VerifyUser();

            if (controller.Login(myUser))
            {
                MessageBox.Show("Login successful.");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Try again.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
