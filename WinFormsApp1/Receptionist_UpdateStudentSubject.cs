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
    internal class Receptionist_UpdateStudentSubject
    {
        private string RequestID;
        private string StudentID;
        private string Date;
        private string OldSubject;
        private string NewSubject;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string RequestID1 { get => RequestID; set => RequestID = value; }
        public string StudentID1 { get => StudentID; set => StudentID = value; }
        public string Date1 { get => Date; set => Date = value; }
        public string OldSubject1 { get => OldSubject; set => OldSubject = value; }
        public string NewSubject1 { get => NewSubject; set => NewSubject = value; }

        public Receptionist_UpdateStudentSubject(string RI)
        {
            RequestID = RI;
        }

        public static ArrayList ViewRequestID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select RequestID from StudentRequest Order By Date", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("RequestID");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public static ArrayList ViewStudentID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StudentID from StudentRequest Order By Date", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("StudentID");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList ViewDate()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Date from StudentRequest Order By Date", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("Date");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList ViewOldSubject()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select OldSubject from StudentRequest Order By Date", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("OldSubject");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList ViewNewSubject()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select NewSubject from StudentRequest Order By Date", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("NewSubject");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }

        public string UpdateStudentSubject(string SI, string OS, string NS)
        {
            string status;
            con.Open();           
            StudentID = SI;           
            OldSubject = OS;
            NewSubject = NS;

            SqlCommand cmd6 = new SqlCommand("update StudentSubject set Subject='" + NewSubject + "' where StudentID = '" + StudentID + "' and Subject='"+ OldSubject+"'", con);
            
            int k = cmd6.ExecuteNonQuery();
            if (k != 0)
                status = "Subject Update Successful";
            else
                status = "Subject Update Fail";
            con.Close();
            return status;
        }

        

    }
}
