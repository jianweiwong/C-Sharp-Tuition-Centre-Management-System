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
    public partial class Receptionist_Payment : Form
    {
    
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string username;
        public Receptionist_Payment(string un)
        {
            InitializeComponent();
            username = un;
        }


        private void ReceptionistPaymentViewUsername()
        {
            string query1 = "Select distinct Username from Student";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
            con.Open();
            DataSet dt = new DataSet();
            adapter.Fill(dt, "Username");
            cmbReceptionistPayment_Name.DisplayMember = "Username";
            cmbReceptionistPayment_Name.ValueMember = "Username";
            cmbReceptionistPayment_Name.DataSource = dt.Tables["Username"];
            con.Close();
            if (cmbReceptionistPayment_Name.Items.Count > 1)
            {
                cmbReceptionistPayment_Name.SelectedIndex = -1;
            }
        }


        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbReceptionistRegisterEnroll_MonthOfEnrollment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReceptionistPayment_GenerateReceipt_Click(object sender, EventArgs e)
        {
            

            if (cmbReceptionistPayment_Name.SelectedItem != null || String.IsNullOrEmpty(txtReceptionistPayment_AmountPaid.Text))
            {
                string status;
                con.Open();

                SqlCommand cmd3 = new SqlCommand("insert into StudentPayment(StudentID, Date, Month, PaymentAmount) " +
                    "values (@StudentID, @Date, @Month, @PaymentAmount)", con);
                cmd3.Parameters.AddWithValue("@StudentID", lblReceptionistPayment_ShowStudentID.Text);
                cmd3.Parameters.AddWithValue("@Date", lblReceptionistPayment_ViewDate.Text);
                cmd3.Parameters.AddWithValue("@Month", lblReceptionistPayment_Month.Text);
                cmd3.Parameters.AddWithValue("@PaymentAmount", txtReceptionistPayment_AmountPaid.Text);


                int i = cmd3.ExecuteNonQuery();
                if (i != 0)
                    MessageBox.Show("Student Payment Successful");
                else
                    MessageBox.Show("Student Payment Fail");
                con.Close();
                
            }
            else
            {
                MessageBox.Show("Fill up all details");
            }
        }

        private void btnReceptionistPayment_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReceptionistPayment_Find_Click(object sender, EventArgs e)
        {
            if (cmbReceptionistPayment_Name.SelectedItem != null) 
            {
                con.Close();
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select StudentID from Student where Username='" + cmbReceptionistPayment_Name.Text + "'", con);
                string viewstudentid = cmd2.ExecuteScalar().ToString();
                lblReceptionistPayment_ShowStudentID.Text = "";
                lblReceptionistPayment_ShowStudentID.Text = viewstudentid;
                con.Close();
                btnReceptionistPayment_GenerateReceipt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please insert student's name");
            }
           
        }

        private void Receptionist_Payment_Load(object sender, EventArgs e)
        {
            ReceptionistPaymentViewUsername();
            DateTime now = DateTime.Now;
            string nowtime = now.ToString("dd/MM/yyyy");
            lblReceptionistPayment_ViewDate.Text = nowtime;
            string nowtime1 = nowtime.Substring(3,2);
            lblReceptionistPayment_Month.Text = nowtime1;
            string month = lblReceptionistPayment_Month.Text;
            
            switch (month)
            {
                case "01":
                    lblReceptionistPayment_Month.Text = "January";
                    break;
                case "02":
                    lblReceptionistPayment_Month.Text = "February";
                    break;
                case "03":
                    lblReceptionistPayment_Month.Text = "March";
                    break;
                case "04":
                    lblReceptionistPayment_Month.Text = "April";
                    break;
                case "05":
                    lblReceptionistPayment_Month.Text = "May";
                    break;
                case "06":
                    lblReceptionistPayment_Month.Text = "June";
                    break;
                case "07":
                    lblReceptionistPayment_Month.Text = "July";
                    break;
                case "08":
                    lblReceptionistPayment_Month.Text = "August";
                    break;
                case "09":
                    lblReceptionistPayment_Month.Text = "September";
                    break;
                case "10":
                    lblReceptionistPayment_Month.Text = "October";
                    break;
                case "11":
                    lblReceptionistPayment_Month.Text = "November";
                    break;
                case "12":
                    lblReceptionistPayment_Month.Text = "December";
                    break;
            }

            btnReceptionistPayment_GenerateReceipt.Enabled = false;

        }

        private void cmbReceptionistPayment_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
