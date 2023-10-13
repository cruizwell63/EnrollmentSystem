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
    public partial class PassGenerator : Form
    {
        public PassGenerator()
        {
            InitializeComponent();
        }

        private void PassGenerator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOP1234567890^%!@#$*";
            int len = 13;
            StringBuilder str = new StringBuilder();
            Random rand = new Random();

            while (0 < len) {
                len--;
                str.Append(chars[rand.Next(chars.Length)]);
            }
            GenPass.Text = str.ToString();

        }
    }
}
