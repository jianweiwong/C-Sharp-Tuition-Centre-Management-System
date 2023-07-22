using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    internal class Admin
    {
        private int id;
        private string username;
        private string password;
        private string ICPassport;
        private string Email;
        private string Contact;
        private string Address;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Contact1 { get => Contact; set => Contact = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string ICPassport1 { get => ICPassport; set => ICPassport = value; }

        public Admin(string username, string password,string IC_Num,string Email,string Contact,string Address)
        {
            this.Username = username;
            this.Password = password;
            this.ICPassport = IC_Num;
            this.Email = Email;
            this.Contact = Contact;
            this.Address = Address;
        }
        public Admin(string username)
        {
            this.Username = username;
        }
        public static void viewprofile(Admin o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select username,ICPassport,Email,Contact,Address from Admin", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.username = rd.GetString(0);
                o1.ICPassport =rd.GetString(1);
                o1.Email = rd.GetString(2);
                o1.Contact =rd.GetString(3);
                o1.Address =rd.GetString(4);
            }
            con.Close();
        }
        public string updateProfile(string em,string co,string ad)
        {
            string status;
            con.Open();
            this.Email = em;
            this.Contact = co;
            this.Address = ad;


            SqlCommand cmd = new SqlCommand("update Admin set Email='" + Email+"',Contact='"+Contact+"',Address='"+Address+"'where Username='"+ username +"'", con);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successful";
            else
                status = "Update Fail";
            con.Close();
            return status;
        }
        public static ArrayList viewusername()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select username from Admin", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewic_num()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select ICPassport from Admin", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.IsDBNull("ICPassport") ? "" : rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewemail()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Email from Admin", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.IsDBNull("Email") ? "" : rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewcontact()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Contact from Admin", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.IsDBNull("Contact") ? "" : rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewaddress()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Address from Admin", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.IsDBNull("Address") ? "" : rd.GetString(0));
            }
            con.Close();
            return nm;
        }
    } 
}
