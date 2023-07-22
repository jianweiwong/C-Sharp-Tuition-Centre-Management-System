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
    internal class Tutor
    {
        private string tutorID;
        private string username;
        private string ICPass;
        private string address;
        private string contact;
        private string email;
        private int level;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string TutorID { get => tutorID; set => tutorID = value; }
        public string Address { get => address; set => address = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string ICPass1 { get => ICPass; set => ICPass = value; }
        public string Username { get => username; set => username = value; }
        public int Level { get => level; set => level = value; }

        public Tutor(string un)
        {
            username = un;
        }

        public static void viewProfile(Tutor o1)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select* from Tutor where Username='" + o1.username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.tutorID = rd.GetString(0).ToString();
                o1.username = rd.GetString(1);

                o1.ICPass = rd.GetString(3);
                o1.email = rd.GetString(4);
                o1.contact = rd.GetString(5);
                o1.address = rd.GetString(6);

            }
            con.Close();

        }


        public string UpdateProfileTutor(string em, string pn, string a)
        {
            string status;
            con.Open();

            email = em;
            contact = pn;
            address = a;


            SqlCommand cmd = new SqlCommand("update tutor set Address='" + address + "',Email='" + email + "',Contact='" + contact + "' where Username='" + username + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Successfully.";
            }
            else
            {
                status = "Unable to Update.";
            }
            con.Close();

            return status;
        }


        public static ArrayList viewEnrolledStudentName(string t)
        {
            string tutorID;
            tutorID = t;
            ArrayList nm = new ArrayList();


            con.Open();
            SqlCommand cmd = new SqlCommand("select* from student where StudentID in (select StudentID from StudentSubject where Subject in (select Subject from TutorProfession where TutorID = '" + tutorID + "'))", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(1));//add element into array list

            }
            con.Close();
            return nm;
        }
        public static ArrayList viewEnrolledStudentLevel(string t)
        {
            string tutorID;
            tutorID = t;
            ArrayList lvl = new ArrayList();


            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student where StudentID in (select StudentID from StudentSubject where Subject in (select Subject from TutorProfession where TutorID = '" + tutorID + "'))", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvl.Add("Form "+rd.GetInt32(6));//add element into array list

            }
            con.Close();
            return lvl;
        }

        public static ArrayList viewEnrolledStudentSubject(string t)
        {
            string tutorID;
            tutorID = t;
            ArrayList sub = new ArrayList();


            con.Open();
            SqlCommand cmd = new SqlCommand("select Student.Username, StudentSubject.Subject from StudentSubject join Student on StudentSubject.StudentID=Student.StudentID where Subject in (select Subject from TutorProfession where TutorID = '" + tutorID + "')", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                sub.Add(rd.GetString(0) + "    " + rd.GetString(1));//add element into array list

            }
            con.Close();
            return sub;
        }
    }
}
