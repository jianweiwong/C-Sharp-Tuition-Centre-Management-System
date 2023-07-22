using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ClassInfo
    {
        private string tutorID;
        private string sub;
        private string day;
        private string time;
        private string dura;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public ClassInfo(string t, string s, string d, string tm, string du)
        {
            tutorID = t;
            sub = s;
            day = d;
            time = tm;
            dura = du;
        }


        public string addClassInfo()
        {
            con.Open();
            SqlCommand count = new SqlCommand("select COUNT(*) FROM Class", con);
            string counting = count.ExecuteScalar().ToString();
            if (counting != "0")
            {
                SqlCommand newcmd = new SqlCommand("select ClassID from Class order by len(ClassID) DESC, ClassID DESC", con); //attempt to find the largest id from database
                string temp = newcmd.ExecuteScalar().ToString(); // convert sql command output to string
                string temp1 = temp.Substring(1); //get the numbers in id only
                int IDitself = Convert.ToInt32(temp1); //removing the prefix from user id
                IDitself += 1; // add one to the largest id number
                temp = temp.Substring(0, 1) + IDitself.ToString();

                SqlCommand cmd = new SqlCommand("insert into Class(ClassID,TutorID,Subject,Day,Time,Duration) values(@class,@TutorID,@sub,@day,@time,@dura)", con);
                cmd.Parameters.AddWithValue("@class", temp.ToString());
                cmd.Parameters.AddWithValue("@tutorID", tutorID);
                cmd.Parameters.AddWithValue("@sub", sub);
                cmd.Parameters.AddWithValue("@day", day);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@dura", dura);
                string status;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Class Information added successfully.";
                }
                else
                {
                    status = "Unable to add class information.";
                }
                con.Close();

                return status;

            }
            else
            {
                string temp = "C1";

                SqlCommand cmd = new SqlCommand("insert into Class(ClassID,TutorID,Subject,Day,Time,Duration) values(@class,@TutorID,@sub,@day,@time,@dura)", con);
                cmd.Parameters.AddWithValue("@class", temp.ToString());
                cmd.Parameters.AddWithValue("@tutorID", tutorID);
                cmd.Parameters.AddWithValue("@sub", sub);
                cmd.Parameters.AddWithValue("@day", day);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@dura", dura);
                string status;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Class Information added successfully.";
                }
                else
                {
                    status = "Unable to add class information.";
                }
                con.Close();

                return status;
            }
        }

    
    }
}
