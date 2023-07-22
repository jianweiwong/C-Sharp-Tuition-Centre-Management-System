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
    public partial class RegisterReceptionist : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public RegisterReceptionist()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RegisterReceptionist_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminTutorDone_Click(object sender, EventArgs e)
        {
            Match match1 = Regex.Match(txtAdminRecepEmail.Text, @"^[^@\s]+@[^@\s]+.[^@\s]+$"); // validate email
            Match match2 = Regex.Match(txtAdminRecepIC_Num.Text, @"^[0-9-]+$");//validate ic
            Match match3 = Regex.Match(txtAdminRecepContact.Text, @"^[0-9-]+$");//validate contact
            Match match4 = Regex.Match(txtAdminRecepUserName.Text, @"^[a-zA-Z ]+$");//validate username
            if (match1.Success && match2.Success && match3.Success && match4.Success)
            { 
                AdminADDReceptionist obj1 = new AdminADDReceptionist(txtAdminRecepUserName.Text, txtAdminRecepPass.Text, txtAdminRecepIC_Num.Text, txtAdminRecepEmail.Text, txtAdminRecepContact.Text, txtAdminRecepAddress.Text);
                if (txtAdminRecepConPass.Text != txtAdminRecepPass.Text)
                    MessageBox.Show("Password does not match", "error");
                else if (txtAdminRecepUserName.Text == "" || txtAdminRecepPass.Text == "" || txtAdminRecepIC_Num.Text == "" || txtAdminRecepEmail.Text == "" || txtAdminRecepContact.Text == "" || txtAdminRecepAddress.Text == "")
                    MessageBox.Show("Cannot leave it blank!!");
                else
                {
                    string status = "0";
                    con.Open();
                    SqlCommand test = new SqlCommand("select count(*) as row from Receptionist", con);
                    string test1 = test.ExecuteScalar().ToString();
                    if (test1 != "0")
                    {
                        SqlCommand cmd2 = new SqlCommand("select username from Users where username=@user", con);
                        cmd2.Parameters.AddWithValue("@user", txtAdminRecepUserName.Text);
                        SqlDataReader rd;
                        rd = cmd2.ExecuteReader();
                        if (rd.Read())
                        {
                            MessageBox.Show("Username has been used");
                        }
                        else
                        {
                            MessageBox.Show(obj1.addRecep());
                        }
                    }
                    else
                    {
                        MessageBox.Show(obj1.addRecep());
                    }
                    con.Close();
                    Close();
                }
            }
            else
                MessageBox.Show("Username/IC/COntact/Email Validation Error!");
        }

        private void btnAdminRecepExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdminRecepUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
