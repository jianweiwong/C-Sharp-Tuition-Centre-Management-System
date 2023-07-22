using System;
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
    public partial class mainPageTutor : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        SqlCommandBuilder sb;
        SqlDataAdapter sda;
        DataTable dt;
        public static string username;
        public static string tutorID;
        public mainPageTutor()
        {
            InitializeComponent();
        }

        public mainPageTutor(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void btnTutorAddClassInfo_Click(object sender, EventArgs e)
        {
            addClassInfoTutor obj1 = new addClassInfoTutor(tutorID);
            obj1.ShowDialog();
        }

        private void btnTutorViewStudentList_Click(object sender, EventArgs e)
        {
            ViewEnrolledStudent obj1 = new ViewEnrolledStudent(username, tutorID);
            obj1.ShowDialog();
        }

        private void btnTutorUpdtDelClassInfo_Click(object sender, EventArgs e)
        {
            updtAndDltClass obj1 = new updtAndDltClass(tutorID);
            obj1.ShowDialog();
        }

        private void btnTutorUpdtProfile_Click(object sender, EventArgs e)
        {
            PasswordCheckTutor obj1 = new PasswordCheckTutor(username);
            obj1.ShowDialog();
        }

        private void mainPageTutor_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome to tutor main page, {username}";

            con.Open();
            SqlCommand cmd = new SqlCommand("select* from Class", con);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dgvTutorMainPage_ViewAllClassInfo.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("Select TutorID from tutor where Username='" + username + "'", con);
            tutorID = cmd2.ExecuteScalar().ToString();
            con.Close();
        }

        private void btnTutorRefresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select* from Class", con);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dgvTutorMainPage_ViewAllClassInfo.DataSource = dt;
            con.Close();
        }
    }
}
