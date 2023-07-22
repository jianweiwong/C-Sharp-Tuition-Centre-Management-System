using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormsApp1
{
    public partial class View_Report : Form
    {
        public View_Report()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        private void display_datagrid()
        {
        }

        private void combo3()
        {
            string query1 = "Select distinct Month from StudentPayment ";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
            con.Open();
            DataSet dt = new DataSet();
            adapter.Fill(dt, "Month");
            CboxAdminViewReportMon.DisplayMember = "Month";
            CboxAdminViewReportMon.ValueMember = "Month";
            CboxAdminViewReportMon.DataSource = dt.Tables["Month"];
            con.Close();
            if (CboxAdminViewReportMon.Items.Count > 1)
            {
                CboxAdminViewReportMon.SelectedIndex = -1;
            }
            con.Close();
        }

        private void View_Report_Load(object sender, EventArgs e)
        {
            combo3();
        }

        private void CboxAdminViewReportSubj_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CboxAdminViewReportLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdminViewReportExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CboxAdminViewReportMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_datagrid();
            con.Close();
            con.Open();
            SqlCommand Total= new SqlCommand("select sum(PaymentAmount) from StudentPayment where Month='"+CboxAdminViewReportMon.Text+"'",con);
            string Sum = Total.ExecuteScalar().ToString();
            lstAdminReportTotal.Items.Clear();
            lstAdminReportTotal.Items.Add(Sum);
            con.Close();
        }

        private void btnAdminReportRef_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (CboxAdminViewReportMon.Text == "January")
                {
                    string query2 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='January'group by Month,Level,Subject";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                    da1.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                    con.Close();
                }

                else if (CboxAdminViewReportMon.Text=="February")
                {
                    string query3 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='February'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text=="")
                {
                    string query4 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID group by Month,Level,Subject";
                    SqlCommand cmd4 = new SqlCommand(query4, con);
                    cmd4.ExecuteNonQuery();
                    DataTable dt4 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd4);
                    da1.Fill(dt4);
                    dataGridView1.DataSource = dt4;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "March")
                {
                    string query5 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='March'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query5, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "April")
                {
                    string query6 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='April'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query6, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "May")
                {
                    string query6 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='May'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query6, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "June")
                {
                    string query6 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='June'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query6, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "July")
                {
                    string query6 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='July'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query6, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "August")
                {
                    string query6 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='August'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query6, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "September")
                {
                    string query6 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject, sum(PaymentAmount) as 'Total_Income' from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='September'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query6, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "October")
                {
                    string query6 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='October'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query6, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "November")
                {
                    string query6 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='November'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query6, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
                else if (CboxAdminViewReportMon.Text == "December")
                {
                    string query6 = "select StudentPayment.Month, count(*) as 'Total Number of Students',Student.Level, StudentSubject.Subject from StudentSubject right join Student on StudentSubject.StudentID = Student.StudentID right join StudentPayment on StudentPayment.StudentID = Student.StudentID where StudentPayment.Month='December'group by Month,Level,Subject";
                    SqlCommand cmd3 = new SqlCommand(query6, con);
                    cmd3.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                    da1.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
