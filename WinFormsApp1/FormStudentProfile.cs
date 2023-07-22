using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class FormStudentProfile : Form
    {
        public static string name;
        public static string password;

        public FormStudentProfile(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudentProfileBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStudentUpdateProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            string un = name;
            FormStudentUpdateProfile updateprofile = new FormStudentUpdateProfile(un);
            updateprofile.ShowDialog();
            updateprofile = null;
            listProfile();
            this.Show();
        }

        private void buttonStudentUpdatePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            string un = name;
            FormStudentUpdatePassword updatepassword = new FormStudentUpdatePassword(un);
            updatepassword.ShowDialog();
            updatepassword = null;
            listProfile();
            this.Show();
        }

        private void labelStudentProfileAddress1Value_Click(object sender, EventArgs e)
        {

        }

        private void FormStudentProfile_Load(object sender, EventArgs e)
        {
            listProfile();
            listSubject();
        }

        private void pictureBoxStudentProfile_Click(object sender, EventArgs e)
        {

        }

        private void listProfile()
        {
            Student obj1 = new Student(name);
            Student.viewProfile(obj1);
            labelStudentIDValue.Text = obj1.Id;
            labelStudentProfileNameValue.Text = obj1.Username;
            labelStudentProfileICValue.Text = obj1.IC1;
            labelStudentProfileEmailValue.Text = obj1.Email;
            labelStudentProfilePhoneValue.Text = obj1.PhoneNum;
            labelStudentProfileAddressValue.Text = obj1.Address;
            labelStudentProfileLevelValue.Text = "Form" + " " + obj1.Level;
            labelStudentProfileMonthValue.Text = obj1.Monthofenrollment;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listSubject()
        {
            ArrayList subj = new ArrayList();
            subj = Student.viewSubject(name);
            listBoxSubject.Items.Add("Subject Taken:");
            foreach (var items in subj)
            {
                listBoxSubject.Items.Add(items);
            }
            this.Refresh();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
