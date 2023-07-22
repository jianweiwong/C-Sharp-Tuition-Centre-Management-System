using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    internal class Request
    {
        private string username;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Request(string username)
        {
            this.username = username;
        }
        public string addRequest(string oS, string nS)
        {
            con.Open();
            SqlCommand count = new SqlCommand("select COUNT(*) FROM StudentRequest", con);
            string counting = count.ExecuteScalar().ToString();
            if  (counting != "0")
            {
                SqlCommand newcmd = new SqlCommand("select RequestID from StudentRequest order by len(RequestID) DESC, RequestID DESC", con);
                string temp = newcmd.ExecuteScalar().ToString();
                string temp1 = temp.Substring(1);
                int IDitself = Convert.ToInt32(temp1);
                IDitself += 1;
                temp = temp.Substring(0, 1) + IDitself.ToString();

                DateTime now = DateTime.Now;
                SqlCommand id = new SqlCommand("select StudentID from Student where Username ='" + username + "'", con);
                SqlCommand cmd = new SqlCommand("insert into StudentRequest(RequestID, StudentID, Date, OldSubject, NewSubject) values(@rID, @sID, @d, @oS, @nS)", con);
                string status;
                string student_id = id.ExecuteScalar().ToString();
                cmd.Parameters.AddWithValue("@oS", oS.ToString());
                cmd.Parameters.AddWithValue("@nS", nS.ToString());
                cmd.Parameters.AddWithValue("@rID", temp.ToString());
                cmd.Parameters.AddWithValue("@d", now.ToString());
                cmd.Parameters.AddWithValue("@sID", student_id);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    status = "Registration Sucessful.";
                else
                    status = "Your chosen new subject cannot be same as old subject.";
                con.Close();
                return status;

            }
            else
            {
                string temp = "R1";

                DateTime now = DateTime.Now;
                SqlCommand id = new SqlCommand("select StudentID from Student where Username ='" + username + "'", con);
                SqlCommand cmd = new SqlCommand("insert into StudentRequest(RequestID, StudentID, Date, OldSubject, NewSubject) values(@rID, @sID, @d, @oS, @nS)", con);
                string status;
                string student_id = id.ExecuteScalar().ToString();
                cmd.Parameters.AddWithValue("@oS", oS.ToString());
                cmd.Parameters.AddWithValue("@nS", nS.ToString());
                cmd.Parameters.AddWithValue("@rID", temp.ToString());
                cmd.Parameters.AddWithValue("@d", now.ToString());
                cmd.Parameters.AddWithValue("@sID", student_id);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    status = "Registration Sucessful.";
                else
                    status = "Your chosen new subject cannot be same as old subject.";
                con.Close();
                return status;
            }

        }

        public static ArrayList viewRequest(string name)
        {
            ArrayList rq = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StudentRequest.RequestID from StudentRequest " +
                "join Student ON StudentRequest.StudentID=Student.StudentID where Username= '" + name + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                rq.Add(rd.GetString(0));
            }
            con.Close();
            return rq;
        }

        public static ArrayList viewRequestTable(string name)
        {
            ArrayList rqt = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StudentRequest.RequestID, StudentRequest.Date, " +
                "StudentRequest.OldSubject, StudentRequest.NewSubject from StudentRequest " +
                "join Student ON StudentRequest.StudentID=Student.StudentID where Username= '" + name + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                rqt.Add(rd.GetString(0) + "                 " + rd.GetString(1) + "            " + rd.GetString(2) + "                     " + rd.GetString(3));
            }
            con.Close();
            return rqt;
        }
    }
}
