using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ViewEnrolledStudent : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        SqlCommandBuilder sb;
        SqlDataAdapter sda;
        DataTable dt;

        public static string username;
        public static string tutorID;
        public ViewEnrolledStudent()
        {
            InitializeComponent();
        }

        public ViewEnrolledStudent(string n, string t)
        {
            InitializeComponent();
            username = n;
            tutorID = t;
        }

        private void btnTutorBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewEnrolledStudent_Load(object sender, EventArgs e)
        {
            ArrayList stuname = new ArrayList();
            stuname = Tutor.viewEnrolledStudentName(tutorID);
            foreach (var item in stuname)
            {
                LstTutorViewEnrolledStudentName.Items.Add(item);
            }

            ArrayList stulevel = new ArrayList();
            stulevel = Tutor.viewEnrolledStudentLevel(tutorID);
            foreach (var item in stulevel)
            {
                LstTutorViewEnrolledStudentLevel.Items.Add(item);
            }

            ArrayList stusub = new ArrayList();
            stusub = Tutor.viewEnrolledStudentSubject(tutorID);
            foreach (var item in stusub)
            {
                LstTutorViewEnrolledStudentSubject.Items.Add(item);
            }

        }

        private void LstTutorViewEnrolledStudentSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
