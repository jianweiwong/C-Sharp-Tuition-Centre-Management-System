using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class FormStudentRequest : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string name;


        public FormStudentRequest(string n)
        {
            InitializeComponent();
            name = n;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonStudentRequestBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayRequest()
        {
            listBoxDeleteRequestTable.Items.Clear();
            ArrayList listTable = new ArrayList();
            listTable = Request.viewRequestTable(name);
            listBoxDeleteRequestTable.Items.Add("Request ID         Request Date                     Old Subject                 New Subject");
            foreach (var items in listTable)
            {
                listBoxDeleteRequestTable.Items.Add(items);
            }
            this.Refresh();

            listBoxDeleteRequest.Items.Clear();
            ArrayList list = new ArrayList();
            list = Request.viewRequest(name);
            foreach (var item in list)
            {
                listBoxDeleteRequest.Items.Add(item);
            }
            this.Refresh();
        }

        private void listBoxDeleteRequest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormStudentRequest_Load(object sender, EventArgs e)
        {
            DisplayRequest();
            listboxSubject();
        }


        private void buttonSelectSubjectConfirm_Click(object sender, EventArgs e)
        {
            Request obj1 = new Request(name);
            con.Open();
            SqlCommand check = new SqlCommand("select StudentSubject.Subject, SubjectTable.Subject from StudentSubject left join Student ON StudentSubject.StudentID=Student.StudentID right join SubjectTable ON StudentSubject.Subject=SubjectTable.Subject where Username= '" + name + "'", con);
            SqlDataReader rd = check.ExecuteReader();
            if (comboBoxChangeTo.Text != comboBoxSelectSubject.Text)
            {
                MessageBox.Show(obj1.addRequest(comboBoxSelectSubject.Text, comboBoxChangeTo.Text));
            }
            else
            {
                MessageBox.Show("Your new subject cannot be same as old subject.");
            }

            con.Close();
            listBoxDeleteRequestTable.Items.Clear();
            ArrayList listTable = new ArrayList();
            listTable = Request.viewRequestTable(name);
            listBoxDeleteRequestTable.Items.Add("Request ID         Request Date                     Old Subject                 New Subject");
            foreach (var items in listTable)
            {
                listBoxDeleteRequestTable.Items.Add(items);
            }
            this.Refresh();

            listBoxDeleteRequest.Items.Clear();
            ArrayList list = new ArrayList();
            list = Request.viewRequest(name);
            foreach (var item in list)
            {
                listBoxDeleteRequest.Items.Add(item);
            }
            this.Refresh();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStudentDeleteRequestConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentRequest WHERE RequestID = '" + listBoxDeleteRequest.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Delete Request Completed.");
                    con.Close();
                }
                
                else
                {
                    MessageBox.Show("No Request Exist.");
                    con.Close();
                }

                listBoxDeleteRequestTable.Items.Clear();
                ArrayList listTable = new ArrayList();
                listTable = Request.viewRequestTable(name);
                listBoxDeleteRequestTable.Items.Add("Request ID         Request Date                     Old Subject                 New Subject");
                foreach (var items in listTable)
                {
                    listBoxDeleteRequestTable.Items.Add(items);
                }
                this.Refresh();

                listBoxDeleteRequest.Items.Clear();
                ArrayList list = new ArrayList();
                list = Request.viewRequest(name);
                foreach (var item in list)
                {
                    listBoxDeleteRequest.Items.Add(item);
                }
                this.Refresh();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void listboxSubject()
        {
            con.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter("select StudentSubject.*, SubjectTable.Subject from StudentSubject left join Student ON StudentSubject.StudentID=Student.StudentID right join SubjectTable ON StudentSubject.Subject=SubjectTable.Subject where Username= '" + name + "'", con);
            adapt.Fill(dt, "Subject");
            comboBoxSelectSubject.DataSource = dt.Tables["Subject"];
            comboBoxSelectSubject.DisplayMember = "Subject";

            DataSet dt1 = new DataSet();
            SqlDataAdapter adapt1 = new SqlDataAdapter("select SubjectTable.* from SubjectTable where SubjectTable.Level in (select Level from Student where Username = '" + name + "')", con);
            adapt1.Fill(dt1, "Subject");
            comboBoxChangeTo.DataSource = dt1.Tables["Subject"];
            comboBoxChangeTo.DisplayMember = "Subject";
            con.Close();
        }

        private void buttonStudentRequestRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteRequest()
        {

        }
    }
}
