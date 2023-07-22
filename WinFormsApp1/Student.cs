using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Reflection.PortableExecutable;

namespace WinFormsApp1
{
    internal class Student
    {
        private string id;
        private string monthofenrollment;
        private string username;
        private string email;
        private string phoneNum;
        private string address;
        private string IC;
        private int level;
        byte check;
        private string subjectName;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Address { get => address; set => address = value; }
        public string IC1 { get => IC; set => IC = value; }
        public string Username { get => username; set => username = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public int Level { get => level; set => level = value; }
        public string Monthofenrollment { get => monthofenrollment; set => monthofenrollment = value; }
        public string Id { get => id; set => id = value; }

        public Student(string username)
        {
            this.username = username;
        }



        public static void viewProfile(Student o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student where Username='" + o1.username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                try
                {
                    o1.id = rd.GetString(0);
                    o1.username = rd.GetString(1);
                    o1.IC = rd.GetString(2);
                    o1.email = rd.GetString(3);
                    o1.phoneNum = rd.GetString(4);
                    o1.address = rd.GetString(5);
                    o1.level = rd.GetInt32(6);
                    o1.monthofenrollment = rd.GetString(7);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue; 
                }

            }
            con.Close();
        }
        public string updateProfile(string em, string num, string ad)
        {
            string status;
            con.Open();
            email = em;
            phoneNum = num;
            address = ad;
            SqlCommand cmd = new SqlCommand("update Student set Email ='" + email + "', Contact='" + phoneNum + "', Address='" + address + "' where username ='" + username + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public string updatePassword(string ps, string nps)
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where Username='" + username + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (ps == reader["Password"].ToString())
                {
                    check = 1;
                }
            }
            reader.Close();
            con.Close();
            if (check == 1)
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("update Users set Password ='" + nps + "'where Username ='" + username + "'", con);
                cmd2.ExecuteNonQuery();
                status = "Password Changed";
                con.Close();
            }
            else
            {
                status = "Please Enter Correct Current Password";
            }
            con.Close();
            return status;
        }
        public static ArrayList viewSubject(string name)
        {
            ArrayList list = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Subject from StudentSubject right join Student ON StudentSubject.StudentID=Student.StudentID where Username= '" + name + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(rd.GetString(0));
            }
            con.Close();
            return list;
        }

        public static ArrayList viewSchedule(string name)
        {
            ArrayList subj = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Class.Subject, Class.Day, Class.Time, " +
                "Class.Duration, Tutor.Username as TutorName from Class left join SubjectTable ON SubjectTable.Subject=Class.Subject " +
                "left join StudentSubject ON SubjectTable.Subject=StudentSubject.Subject " +
                "left join Tutor ON Class.TutorID=Tutor.TutorID " +
                "right join Student ON StudentSubject.StudentID=Student.StudentID " +
                "where Student.Username= '" + name + "' and SubjectTable.Subject=Class.Subject", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                subj.Add(rd.GetString(0) + "            " + rd.GetString(1) + "                 " + rd.GetString(2) + "                    " + rd.GetString(3) + "                      " + rd.GetString(4));
            }
            con.Close();
            return subj;
        }
    }
}

