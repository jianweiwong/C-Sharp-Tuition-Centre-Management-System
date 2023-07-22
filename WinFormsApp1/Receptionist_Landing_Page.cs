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
    public partial class Receptionist_Landing_Page : Form
    {
        public static string username;

        public Receptionist_Landing_Page()
        {
            InitializeComponent();
        }

        public Receptionist_Landing_Page(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void Receptionist_Landing_Page_Load(object sender, EventArgs e)
        {
            lblReceptionistLandingPage_WelcomeMessage.Text = "Welcome, " + username;
        }

        private void btnReceptionistLandingPage_StudentRegistration_Click(object sender, EventArgs e)
        {
            Hide();
            Receptionist_Register_Enroll registerenroll = new Receptionist_Register_Enroll(username);
            registerenroll.ShowDialog();            
            Show();
        }

        private void btnReceptionistLandingPage_ViewUpdateProfile_Click(object sender, EventArgs e)
        {
            Hide();
            Receptionist_View_Update_Profile profile = new Receptionist_View_Update_Profile(username);
            profile.ShowDialog();            
            Show();
        }

        private void btnReceptionistLandingPage_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //close window
            }

            
        }

        private void btnReceptionistLandingPage_StudentPayment_Click(object sender, EventArgs e)
        {
            Hide();
            Receptionist_Payment payment = new Receptionist_Payment(username);
            payment.ShowDialog();           
            Show();
        }

        private void btnReceptionistLandingPage_StudentUpdateSubject_Click(object sender, EventArgs e)
        {
            Hide();
            Receptionist_Update_Subject update = new Receptionist_Update_Subject(username);
            update.ShowDialog();          
            Show();
        }

        private void btnReceptionistLandingPage_DeleteStudent_Click(object sender, EventArgs e)
        {
            Hide();
            Receptionist_DeleteStudent delete = new Receptionist_DeleteStudent(username);
            delete.ShowDialog();
            Show();
        }
    }
}
