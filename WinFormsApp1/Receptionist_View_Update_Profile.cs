using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Receptionist_View_Update_Profile : Form
    {
        public static string username;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Receptionist_View_Update_Profile(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void Receptionist_View_Update_Profile_Load(object sender, EventArgs e)
        {
            Receptionist_ReceptionistProfile obj1 = new Receptionist_ReceptionistProfile(username);
            Receptionist_ReceptionistProfile.ViewProfile(obj1);
            lblReceptionistViewUpdateProfile_ViewName.Text = obj1.Username1;
            lblReceptionistViewUpdateProfile_ViewICPassport.Text = obj1.ICPassport1;
            txtReceptionistViewUpdateProfile_EnterEmail.Text = obj1.Email1;
            txtReceptionistViewUpdateProfile_EnterContactNumber.Text = obj1.Contact1;
            txtReceptionistViewUpdateProfile_EnterAddress.Text = obj1.Address1;
        }

        private void btnReceptionistViewUpdateProfile_Update_Click(object sender, EventArgs e)
        {
            
            Receptionist_ReceptionistProfile obj1 = new Receptionist_ReceptionistProfile(username);


            Match match = Regex.Match(txtReceptionistViewUpdateProfile_EnterEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // use to validate '@' and '.' in the Email textbox

            if (match.Success)
            {
                MessageBox.Show(obj1.UpdateProfile(txtReceptionistViewUpdateProfile_EnterEmail.Text,
                    txtReceptionistViewUpdateProfile_EnterContactNumber.Text, txtReceptionistViewUpdateProfile_EnterAddress.Text));

            }
            else
            {
                MessageBox.Show("Invalid Email format.");
                txtReceptionistViewUpdateProfile_EnterEmail.Focus();
            }
                

        }

        private void btnReceptionistViewUpdateProfile_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
