using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class AdminADDTutor
    {
        private string TutorID;
        private string username;
        private string password;
        private int level;
        private string ICPassport;
        private string email;
        private string contact;
        private string address;
        private string sub1;
        private string sub2;
        private string sub3;
        private string sub4;
        private string sub5;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Address { get => address; set => address = value; }
        public string TutorID1 { get => TutorID; set => TutorID = value; }
        public string ICPassport1 { get => ICPassport; set => ICPassport = value; }
        public string Sub1 { get => sub1; set => sub1 = value; }
        public string Sub2 { get => sub2; set => sub2 = value; }
        public string Sub3 { get => sub3; set => sub3 = value; }
        public string Sub4 { get => sub4; set => sub4 = value; }
        public string Sub5 { get => sub5; set => sub5 = value; }
        public int Level { get => level; set => level = value; }

        public AdminADDTutor(string username, string password, int level, string iC_Num, string email, string contact, string address)
        {
            this.Username = username;
            this.Password = password;
            this.Level = level;
            this.ICPassport = iC_Num;
            this.Email = email;
            this.Contact = contact;
            this.Address = address;
        }
        public AdminADDTutor(string sub1)
        {
            Sub1 = sub1;
        }

        public string addTutor()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) as row from Tutor", con);
            string test = cmd.ExecuteScalar().ToString();
            string temp;
            if (test != "0")
            {
                SqlCommand cmd1 = new SqlCommand("select TutorID from Tutor order by len(TutorID) DESC, TutorID DESC", con);
                temp = cmd1.ExecuteScalar().ToString();
                string temp1 = temp.Substring(1);
                int ID = Convert.ToInt32(temp1);
                ID += 1;
                TutorID = temp.Substring(0, 1) + ID.ToString();
            }
            else
            {
                TutorID = "T1";
            }
            string status;
            SqlCommand cmd2 = new SqlCommand("insert into Tutor(TutorID,Username,Level,ICPassport,Email,Contact,Address) values(@Tutor_ID,@username,@level,@icnum,@email,@contact,@address)", con);
            SqlCommand cmd3 = new SqlCommand("insert into Users(Username,Password,Role) values(@username,@pass,'tutor')", con);
            cmd2.Parameters.AddWithValue("@Tutor_ID",TutorID);
            cmd2.Parameters.AddWithValue("@username", Username);
            cmd3.Parameters.AddWithValue("@username",Username);
            cmd3.Parameters.AddWithValue("@pass", Password);
            cmd2.Parameters.AddWithValue("@level", Level);
            cmd2.Parameters.AddWithValue("@icnum", ICPassport1);
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
        public string addsubj(string SI, string SJ)
        {
            string status;
            con.Open();
            TutorID = SI;
            Sub1 = SJ;

            SqlCommand cmd4 = new SqlCommand("insert into TutorProfession(TutorID, Subject) values(@tutorID, @Subject)", con);
            cmd4.Parameters.AddWithValue("@tutorID", TutorID);
            cmd4.Parameters.AddWithValue("@Subject", Sub1);


            int j = cmd4.ExecuteNonQuery();

            if (j != 0)
                status = "Subject Enrollment Successful";
            else
                status = "Subject Enrollment Fail";
            con.Close();
            return status;
        }

        public static ArrayList viewtutor_id()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select TutorID from Tutor", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("TutorID");
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
            SqlCommand cmd = new SqlCommand("select username from Tutor", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("username");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewlevel()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select level from Tutor", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("level");
            while (rd.Read())
            {
                nm.Add(rd.GetInt32(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewic_num()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select ICPassport from Tutor", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("lCPassport");
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
            SqlCommand cmd = new SqlCommand("select Email from Tutor", con);
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
            SqlCommand cmd = new SqlCommand("select Contact from Tutor", con);
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
            SqlCommand cmd = new SqlCommand("select Address from Tutor", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("Address");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewsubject()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Subject from TutorProfession", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("Subject");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewid()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select TutorID from TutorProfession", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("TutorID");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList viewcombo()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Subject from SubjectTable", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
    }
}
