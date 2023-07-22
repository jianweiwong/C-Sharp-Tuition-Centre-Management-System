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
    public partial class Receptionist_Update_Subject : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string username;

        public Receptionist_Update_Subject(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void Receptionist_Update_Subject_Load(object sender, EventArgs e)
        {
            LoadingUpdateSubjectForm();

        }

        private void LoadingUpdateSubjectForm()
        {
            ReceptionistPaymentViewUsername();
            btnReceptionistUpdateSubject_Confirm.Enabled = false;
            btnReceptionistUpdateSubject_Delete.Enabled = false;

            lstReceptionistUpdateSubject_RequestID.Items.Clear();
            lstReceptionistUpdateSubject_StudentID.Items.Clear();
            lstReceptionistUpdateSubject_Date.Items.Clear();
            lstReceptionistUpdateSubject_OldSubject.Items.Clear();
            lstReceptionistUpdateSubject_NewSubject.Items.Clear();
            lblReceptionistUpdateSubject_StudentID.Text = "";
            lblReceptionistUpdateSubject_OldSubject.Text = "";
            lblReceptionistUpdateSubject_NewSubject.Text = "";

            ArrayList RequestID = new ArrayList();
            RequestID = Receptionist_UpdateStudentSubject.ViewRequestID();
            foreach (var item in RequestID)
            {
                lstReceptionistUpdateSubject_RequestID.Items.Add(item);
            }
            ArrayList StudentID = new ArrayList();
            StudentID = Receptionist_UpdateStudentSubject.ViewStudentID();
            foreach (var item in StudentID)
            {
                lstReceptionistUpdateSubject_StudentID.Items.Add(item);
            }
            ArrayList Date = new ArrayList();
            Date = Receptionist_UpdateStudentSubject.ViewDate();
            foreach (var item in Date)
            {
                lstReceptionistUpdateSubject_Date.Items.Add(item);
            }
            ArrayList OldSubject = new ArrayList();
            OldSubject = Receptionist_UpdateStudentSubject.ViewOldSubject();
            foreach (var item in OldSubject)
            {
                lstReceptionistUpdateSubject_OldSubject.Items.Add(item);
            }
            ArrayList NewSubject = new ArrayList();
            NewSubject = Receptionist_UpdateStudentSubject.ViewNewSubject();
            foreach (var item in NewSubject)
            {
                lstReceptionistUpdateSubject_NewSubject.Items.Add(item);
            }
        }
        private void ReceptionistPaymentViewUsername()
        {
            string query2 = "Select distinct RequestID from StudentRequest";
            SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
            con.Open();
            DataSet dt = new DataSet();
            adapter.Fill(dt, "RequestID");
            cmbReceptionistUpdateSubject_RequestID.DisplayMember = "RequestID";
            cmbReceptionistUpdateSubject_RequestID.ValueMember = "RequestID";
            cmbReceptionistUpdateSubject_RequestID.DataSource = dt.Tables["RequestID"];
            con.Close();
            if (cmbReceptionistUpdateSubject_RequestID.Items.Count > 1)
            {
                cmbReceptionistUpdateSubject_RequestID.SelectedIndex = -1;
            }
        }

        private void btnReceptionistUpdateSubject_Find_Click(object sender, EventArgs e)
        {
            if (cmbReceptionistUpdateSubject_RequestID.SelectedItem != null)
            {
                con.Close();
                con.Open();
                SqlCommand cmd7 = new SqlCommand("select StudentID from StudentRequest where RequestID='" + cmbReceptionistUpdateSubject_RequestID.Text + "'", con);
                string viewstudentid = cmd7.ExecuteScalar().ToString();
                lblReceptionistUpdateSubject_StudentID.Text = "";
                lblReceptionistUpdateSubject_StudentID.Text = viewstudentid;

                
                SqlCommand cmd = new SqlCommand("select OldSubject, NewSubject from StudentRequest where RequestID= '" + cmbReceptionistUpdateSubject_RequestID.Text + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lblReceptionistUpdateSubject_OldSubject.Text = rd.GetString(0);
                    lblReceptionistUpdateSubject_NewSubject.Text = rd.GetString(1);
                }
                


                con.Close();
                btnReceptionistUpdateSubject_Confirm.Enabled = true;
                btnReceptionistUpdateSubject_Delete.Enabled = true;

            }
            else
            {
                MessageBox.Show("RequestID not chosen");
                cmbReceptionistUpdateSubject_RequestID.Focus();
            }
        }

        private void btnReceptionistUpdateSubject_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReceptionistUpdateSubject_Confirm_Click(object sender, EventArgs e)
        {
            Receptionist_UpdateStudentSubject obj1 = new Receptionist_UpdateStudentSubject(username);
            MessageBox.Show(obj1.UpdateStudentSubject(lblReceptionistUpdateSubject_StudentID.Text, lblReceptionistUpdateSubject_OldSubject.Text,
                lblReceptionistUpdateSubject_NewSubject.Text));

            con.Open();
            SqlCommand cmd = new SqlCommand("delete from StudentRequest where RequestID='" + cmbReceptionistUpdateSubject_RequestID.Text + "'", con);
            
            cmd.ExecuteNonQuery();
            
            con.Close();

            LoadingUpdateSubjectForm();
        }

        private void btnReceptionistUpdateSubject_Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from StudentRequest where RequestID='" + cmbReceptionistUpdateSubject_RequestID.Text + "'", con);

            cmd.ExecuteNonQuery();

            con.Close();

            LoadingUpdateSubjectForm();
        }

        private void btnReceptionistUpdateSubject_Refresh_Click(object sender, EventArgs e)
        {
            LoadingUpdateSubjectForm();
        }
    }
}
