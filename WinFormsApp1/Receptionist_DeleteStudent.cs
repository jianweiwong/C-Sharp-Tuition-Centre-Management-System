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
    public partial class Receptionist_DeleteStudent : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string username;
        public Receptionist_DeleteStudent(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void ReceptionistDeleteViewStudentID()
        {
            string query1 = "Select distinct StudentID from Student";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
            con.Open();
            DataSet dt = new DataSet();
            adapter.Fill(dt, "StudentID");
            cmbReceptionistDeleteStudent_StudentID.DisplayMember = "StudentID";
            cmbReceptionistDeleteStudent_StudentID.ValueMember = "StudentID";
            cmbReceptionistDeleteStudent_StudentID.DataSource = dt.Tables["StudentID"];
            con.Close();
            if (cmbReceptionistDeleteStudent_StudentID.Items.Count > 1)
            {
                cmbReceptionistDeleteStudent_StudentID.SelectedIndex = -1;
            }
        }
        public static ArrayList ViewStudentStudentID()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StudentID from Student", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("StudentID");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList ViewStudentUsername()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Username from Student", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("Username");
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }
        public static ArrayList ViewStudentLevel()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Level from Student", con);
            SqlDataReader rd = cmd.ExecuteReader();
            nm.Add("Level");
            while (rd.Read())
            {
                nm.Add(rd.GetInt32(0));
            }
            con.Close();
            return nm;
        }
        private void btnReceptionistDeleteStudent_Find_Click(object sender, EventArgs e)
        {
            if (cmbReceptionistDeleteStudent_StudentID.SelectedItem != null)
            {
                con.Close();
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select Username from Student where StudentID='" + cmbReceptionistDeleteStudent_StudentID.Text + "'", con);
                string viewusername = cmd2.ExecuteScalar().ToString();
                lblReceptionistDeleteStudent_Username.Text = "";
                lblReceptionistDeleteStudent_Username.Text = viewusername;
                con.Close();
                btnReceptionistDeleteStudent_DeleteStudent.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please insert student's name");
            }
        }

        private void btnReceptionistDeleteStudent_Refresh_Click(object sender, EventArgs e)
        {
            lstReceptionistDeleteStudent_StudentID.Items.Clear();
            lstReceptionistDeleteStudent_Username.Items.Clear();
            lstReceptionistDeleteStudent_Level.Items.Clear();
            lblReceptionistDeleteStudent_Username.Text = "";


            LoadingDeleteStudentForm();
        }

        private void btnReceptionistDeleteStudent_DeleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from StudentRequest where StudentID='" + cmbReceptionistDeleteStudent_StudentID.Text + "'", con);
                SqlCommand cmd2 = new SqlCommand("delete from StudentSubject where StudentID='" + cmbReceptionistDeleteStudent_StudentID.Text + "'", con);
                SqlCommand cmd3 = new SqlCommand("delete from Student where StudentID='" + cmbReceptionistDeleteStudent_StudentID.Text + "'", con);
                SqlCommand cmd4 = new SqlCommand("delete from Users where Username='" + lblReceptionistDeleteStudent_Username.Text + "'", con);

                int i = cmd.ExecuteNonQuery();
                int j = cmd2.ExecuteNonQuery();
                int k = cmd3.ExecuteNonQuery();
                int l = cmd4.ExecuteNonQuery();

                if (i != 0)
                {
                    if (j != 0)
                    {
                        if (k != 0)
                        {
                            if (l != 0)
                            {
                                MessageBox.Show("Student Deletion Successful");
                            }
                            else
                                MessageBox.Show("Student Deletion Successful");
                        }
                        else
                            MessageBox.Show("Student Deletion Successful");
                    }
                    else
                        MessageBox.Show("Student Deletion Successful");
                }
                else
                    MessageBox.Show("Student Deletion Successful");

                con.Close();

                lstReceptionistDeleteStudent_StudentID.Items.Clear();
                lstReceptionistDeleteStudent_Username.Items.Clear();
                lstReceptionistDeleteStudent_Level.Items.Clear();
                lblReceptionistDeleteStudent_Username.Text = "";
                LoadingDeleteStudentForm();
            }
            else if (dialogResult == DialogResult.No)
            {
                //close window
            }

            

        }

        private void btnReceptionistDeleteStudent_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Receptionist_DeleteStudent_Load(object sender, EventArgs e)
        {
            LoadingDeleteStudentForm();
        }
        private void LoadingDeleteStudentForm()
        {
            ReceptionistDeleteViewStudentID();
            btnReceptionistDeleteStudent_DeleteStudent.Enabled = false;

            ArrayList StudentID = new ArrayList();
            StudentID = ViewStudentStudentID();
            foreach (var item in StudentID)
            {
                lstReceptionistDeleteStudent_StudentID.Items.Add(item);
            }
            ArrayList Username = new ArrayList();
            Username = ViewStudentUsername();
            foreach (var item in Username)
            {
                lstReceptionistDeleteStudent_Username.Items.Add(item);
            }
            ArrayList Level = new ArrayList();
            Level = ViewStudentLevel();
            foreach (var item in Level)
            {
                lstReceptionistDeleteStudent_Level.Items.Add(item);
            }
        }

    }
}
