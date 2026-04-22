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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterUser.Text == "" || txtRegisterPassword.Text == "")
            {
                MessageBox.Show("Please enter a Username and Password.");
                return;
            }

            User newUser = new User
            {
                UserName = txtRegisterUser.Text.Trim(),
                UserPassword = txtRegisterPassword.Text.Trim()
            };

            VerifyUser controller = new VerifyUser();

            if (controller.Register(newUser))
            {
                MessageBox.Show("New user was successfully registered.");
                this.Close();
            }
            else
            {
                MessageBox.Show("User already exists or unexpected error occurred.");
            }
        }
    }
}
