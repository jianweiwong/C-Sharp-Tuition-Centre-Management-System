using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class FormStudentUpdateProfile : Form
    {
        public static string name;

        public FormStudentUpdateProfile(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void buttonUpdateProfileBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonUpdateProfileConfirm_Click(object sender, EventArgs e)
        {
            Student obj1 = new Student(name);
            Match match1 = Regex.Match(textBoxStudentUpdateEmail.Text, @"^[^@\s]+@[^@\s]+.[^@\s]+$");
            Match match2 = Regex.Match(textBoxStudentUpdateContactNumber.Text, @"^+?\d{0,3}-?\d{5,9}");
            if (match1.Success)
            {
                if (match2.Success)
                {
                    MessageBox.Show(obj1.updateProfile(textBoxStudentUpdateEmail.Text, textBoxStudentUpdateContactNumber.Text, textBoxStudentUpdateAddress.Text));
                }

                else
                {
                    MessageBox.Show("Invalid Contact Number.");
                }
            }

            else
            {
                MessageBox.Show("Invalid Email.");
            }

        }

        private void FormStudentUpdateProfile_Load(object sender, EventArgs e)
        {
            Student obj1 = new Student(name);
            Student.viewProfile(obj1);
            labelStudentNameValue.Text = obj1.Username;
            labelStudentICValue.Text = obj1.IC1;
            textBoxStudentUpdateEmail.Text = obj1.Email;
            textBoxStudentUpdateContactNumber.Text = obj1.PhoneNum;
            textBoxStudentUpdateAddress.Text = obj1.Address;
        }

        private void buttonStudentUpdateProfileInsertPicture_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxUpdateStudentProfile_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
