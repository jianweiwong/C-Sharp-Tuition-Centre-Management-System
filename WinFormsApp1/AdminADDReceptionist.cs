using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace WinFormsApp1
{
    internal class AdminADDReceptionist
    {
        private string ReceptionistID;
        private string username;
        private string password;
        private string ICPassport;
        private string email;
        private string contact;
        private string address;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Address { get => address; set => address = value; }
        public string Password { get => password; set => password = value; }
        public string ICPassport1 { get => ICPassport; set => ICPassport = value; }
        public string ReceptionistID1 { get => ReceptionistID; set => ReceptionistID = value; }

        public AdminADDReceptionist(string username,string password,string iC_Num, string email, string contact, string address)
        {
            this.Username = username;
            this.Password = password;
            this.ICPassport = iC_Num;
            this.Email = email;
            this.Contact = contact;
            this.Address = address;
        }
        public string addRecep()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) as row from Receptionist", con);
            string test = cmd.ExecuteScalar().ToString();
            string temp;
            if (test != "0")
            {
                SqlCommand cmd1 = new SqlCommand("select ReceptionistID from Receptionist order by len(ReceptionistID) DESC, ReceptionistID DESC", con);
                temp = cmd1.ExecuteScalar().ToString();
                string temp1 = temp.Substring(1);
                int ID = Convert.ToInt32(temp1);
                ID += 1;
                ReceptionistID = temp.Substring(0, 1) + ID.ToString();
            }
            else
            {
                ReceptionistID = "R1";
            }


            string status;
            SqlCommand cmd2 = new SqlCommand("insert into Receptionist(ReceptionistID,Username,ICPassport,Email,Contact,Address) values(@Recep_ID,@username,@icnum,@email,@contact,@address)", con);
            SqlCommand cmd3= new SqlCommand("insert into Users(Username,Password,Role) values(@username,@pass,'receptionist')",con);
            cmd2.Parameters.AddWithValue("@Recep_ID", ReceptionistID);
            cmd2.Parameters.AddWithValue("@username", Username);
            cmd3.Parameters.AddWithValue("@username", Username);
            cmd3.Parameters.AddWithValue("@pass", Password);
            cmd2.Parameters.AddWithValue("@icnum", ICPassport);
            cmd2.Parameters.AddWithValue("@email", Email);
            cmd2.Parameters.AddWithValue("@contact", Contact);
            cmd2.Parameters.AddWithValue("@address", Address);

            cmd3.ExecuteNonQuery();
            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful";
            else
                status = "Registration Fail";
            con.Close();
            return status;
        }
        public static ArrayList viewrecep_id()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select ReceptionistID from Receptionist", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("ReceptionistID");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList viewusername()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select username from Receptionist", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("Username");
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
            SqlCommand cmd = new SqlCommand("select ICPassport from Receptionist", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("lc_Num");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewemail()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Email from Receptionist", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("Email");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewcontact()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Contact from Receptionist", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("Contact");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewaddress()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Address from Receptionist", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("Address");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
    }
}
