using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stat;
            Users obj1 = new Users(txtLoginPage_EnterUsername.Text, txtLoginPage_EnterPassword.Text);
            this.Hide();
            stat = obj1.login(txtLoginPage_EnterUsername.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
                this.Show();
            }
            else
                this.Show();
            txtLoginPage_EnterUsername.Text = String.Empty;
            txtLoginPage_EnterPassword.Text = String.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
