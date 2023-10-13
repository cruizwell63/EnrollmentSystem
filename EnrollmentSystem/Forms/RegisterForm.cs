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
    
    public partial class RegisterForm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e) // when register button is clicked
        {
            string temp = "";
            string role = "Student";
            int q = db.checkUsername1(Username.Text);

            if (Username.Text == "" || Password.Text == "" || ConfirmPass.Text == "" || Fname.Text == "" || Lname.Text == "" || Gender.SelectedItem == null)
            {
                FillFields.Visible = true; //if all or some fields are null, show message
            }
            else if (Password.Text != ConfirmPass.Text) {
                PassMatch.Visible = true; //if passwords did not match, show message
            }
            else if (q == 1) {
                MessageBox.Show("Username already taken","Warning");
            }
            else {
                FillFields.Visible = false;
                PassMatch.Visible = false;
                db.addUser(Username.Text, Password.Text, temp, Fname.Text, MName.Text, Lname.Text, Gender.Text, BDate.Value, role, DateTime.Now, DateTime.Now);
                MessageBox.Show("Registered Successfully!", "Successful");
            }
        }
    }
}
