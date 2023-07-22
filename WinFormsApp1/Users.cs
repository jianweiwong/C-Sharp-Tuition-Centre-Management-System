using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Users
    {
        private string username;
        private string password;

        public Users(string text1, string text2)
        {
            this.username = text1;
            this.password = text2;
        }

        public string login(string un)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from Users where Username = '" + username + "' and Password = '" + password + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from Users where Username = '" + username + "' and Password = '" + password + "'", con);
                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    MessageBox.Show("Login Successful");
                    AdminHomepage s = new AdminHomepage(un);
                    s.ShowDialog();
                }

                else if (userRole == "student")
                {
                    MessageBox.Show("Login Successful");
                    FormStudentMainMenu s = new FormStudentMainMenu(un);
                    s.ShowDialog();
                }

                else if (userRole == "tutor")
                {
                    MessageBox.Show("Login Successful");
                    mainPageTutor t = new mainPageTutor(un);
                    t.ShowDialog();
                }

                else if (userRole == "receptionist")
                {
                    MessageBox.Show("Login Successful");
                    Receptionist_Landing_Page s = new Receptionist_Landing_Page(un);
                    s.ShowDialog();
                }
            }

            else
                status = "Incorrect username/password";
            con.Close();

            return status;
        }
    }
}
