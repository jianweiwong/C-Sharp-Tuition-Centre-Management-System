using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PasswordCheckTutor : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static string username;
        private string password;
        public PasswordCheckTutor()
        {
            InitializeComponent();
        }
        public PasswordCheckTutor(string n)
        {
            InitializeComponent();
            username = n;
        }

        private void btnPasswordCheckTutor_Identify_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Password from Users where Username='" + username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                password = rd.GetString(0);
            }

            con.Close();

            if (password == txtPasswordCheckTutor_Password.Text)
            {
                MessageBox.Show("Identify Successfully!");
                UpdateProfileTutor obj1 = new UpdateProfileTutor(username);
                obj1.ShowDialog();
            }

            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }

        private void PasswordCheckTutor_Load(object sender, EventArgs e)
        {

        }
    }
}
