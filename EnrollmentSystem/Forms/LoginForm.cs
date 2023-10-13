using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class LoginForm : Form
    {
        RegisterForm register = new RegisterForm();
        AdminHome admin = new AdminHome();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void RegisterLnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string usern = "cruizwell";
            string pass = "canen";

            if (LoginUserName.Text == usern && LoginPassword.Text == pass)
            {
                Errormsg1.Visible = false;
                admin.Show();
            }
            else {
                Errormsg1.Visible = true;
            }
        }
    }
}
