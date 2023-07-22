using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class User
    {
        private string id;
        private string username;
        private string password;
        private string role;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Password { get => password; set => password = value; }

        public User(string un)
        {
            username = un;

        }

        public static void viewPasswordTutor(User o1)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select* from Users where Username='" + o1.username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.password = rd.GetString(2);
            }
            con.Close();

        }


        public string UpdatePasswordTutor(string pw)
        {
            string status;
            con.Open();
            
            password = pw;


            SqlCommand cmd = new SqlCommand("update Users set Password='" + password + "' where Username='" + username + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Password Successfully.";
            }
            else
            {
                status = "Unable to Update Password.";
            }
            con.Close();

            return status;
        }
    }
}
