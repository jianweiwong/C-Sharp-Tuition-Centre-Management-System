using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    internal class Receptionist_RegisterStudentAndSubject
    {
        private string StudentID;
        private string Username;
        private string ICPassport;
        private string Email;
        private string Contact;
        private string Address;
        private int Level;
        private string MonthOfEnrollment;
        private string Password;
        private string Subject;


        public string StudentID1 { get => StudentID; set => StudentID = value; }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Receptionist_RegisterStudentAndSubject(string UN, string IP, string EM, string CT, string AD, string PW, int LV, string MOE/*, string FS, string SS, string TS*/)
        {
            Username = UN;
            ICPassport = IP;
            Email = EM;
            Contact = CT;
            Address = AD;
            Password = PW;
            Level = LV;
            MonthOfEnrollment = MOE;


        }

        public Receptionist_RegisterStudentAndSubject(string SJ)
        {
            Subject = SJ;

        }

        public string RegisterEnrollStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) as row from Student", con);
            string test = cmd.ExecuteScalar().ToString();
            string temp;
            if (test != "0")
            {
                SqlCommand cmd1 = new SqlCommand("select StudentID from Student order by len(StudentID) DESC, StudentID DESC", con);
                temp = cmd1.ExecuteScalar().ToString();
                string temp1 = temp.Substring(1);
                int ID = Convert.ToInt32(temp1);
                ID += 1;
                StudentID = temp.Substring(0, 1) + ID.ToString();
            }
            else
            {
                StudentID = "S1";
            }

            string status;

            SqlCommand cmd2 = new SqlCommand("insert into Student(StudentID, Username, ICPassport, Email, Contact, Address, Level, MonthOfEnrollment) " +
                "values (@StudentID, @Username, @ICPassport, @Email, @Contact, @Address, @Level, @MonthOfEnrollment)", con);
            cmd2.Parameters.AddWithValue("@StudentID", StudentID);
            cmd2.Parameters.AddWithValue("@Username", Username);
            cmd2.Parameters.AddWithValue("@ICPassport", ICPassport);
            cmd2.Parameters.AddWithValue("@Email", Email);
            cmd2.Parameters.AddWithValue("@Contact", Contact);
            cmd2.Parameters.AddWithValue("@Address", Address);
            cmd2.Parameters.AddWithValue("@Level", Level);
            cmd2.Parameters.AddWithValue("@MonthOfEnrollment", MonthOfEnrollment);

            SqlCommand cmd3 = new SqlCommand("insert into Users(Username,Password,Role) values(@Username,@Password,'student')", con);
            cmd3.Parameters.AddWithValue("@Username", Username);
            cmd3.Parameters.AddWithValue("@Password", Password);

            
            
            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
                status = "Student Registration Successful";
            else
                status = "Student Registration Fail";

            cmd3.ExecuteNonQuery();

            con.Close();
            return status;
            



        }

        public string SubjectEnrollStudent1(string SI, string SJ)
        {
            string status;
            con.Open();
            StudentID = SI;
            Subject = SJ;

            SqlCommand cmd5 = new SqlCommand("insert into StudentSubject(StudentID, Subject) values(@StudentID, @Subject)", con);
            cmd5.Parameters.AddWithValue("@StudentID", StudentID);
            cmd5.Parameters.AddWithValue("@Subject", Subject);


            int j = cmd5.ExecuteNonQuery();

            if (j != 0)
                status = "Student Subject Enrollment Successful";
            else
                status = "Student Subject Enrollment Fail";
            con.Close();
            return status;


        }


        
    }
}

