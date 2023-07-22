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
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class ViewTutors : Form
    {
        public ViewTutors()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private void Form7_Load(object sender, EventArgs e)
        {
            ArrayList Tutor_ID = new ArrayList();
            Tutor_ID = AdminADDTutor.viewtutor_id();
            foreach (var item in Tutor_ID)
            {
                lstAdminTutorInfo.Items.Add(item);
            }
            ArrayList username = new ArrayList();
            username = AdminADDTutor.viewusername();
            foreach (var item in username)
            {
                lstAdminTutorInfo2.Items.Add(item);
            }
            ArrayList level = new ArrayList();
            level = AdminADDTutor.viewlevel();
            foreach (var item in level)
            {
                lstAdminTutorInfo3.Items.Add(item);
            }
            ArrayList Ic_Num = new ArrayList();
            Ic_Num = AdminADDTutor.viewic_num();
            foreach (var item in Ic_Num)
            {
                lstAdminTutorInfo4.Items.Add(item);
            }
            ArrayList Email = new ArrayList();
            Email = AdminADDTutor.viewemail();
            foreach (var item in Email)
            {
                lstAdminTutorInfo5.Items.Add(item);
            }
            ArrayList Contact = new ArrayList();
            Contact = AdminADDTutor.viewcontact();
            foreach (var item in Contact)
            {
                lstAdminTutorInfo6.Items.Add(item);
            }
            ArrayList Address = new ArrayList();
            Address = AdminADDTutor.viewaddress();
            foreach (var item in Address)
            {
                lstAdminTutorInfo7.Items.Add(item);
            }
            ArrayList id = new ArrayList();
            id = AdminADDTutor.viewid();
            foreach (var item in id)
            {
                lstAdminTutorInfo8.Items.Add(item);
            }
            ArrayList Subject = new ArrayList();
            Subject = AdminADDTutor.viewsubject();
            foreach (var item in Subject)
            {
                lstAdminTutorInfo9.Items.Add(item);
            }
        }
        private void lstAdminInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstAdminInfo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("delete from TutorProfession where TutorID='" + lstAdminTutorInfo.Text + "'", con);
            SqlCommand cmd = new SqlCommand("delete from Tutor where USername='" + lstAdminTutorInfo2.Text + "'", con);
            SqlCommand cmd2= new SqlCommand("delete from Users where Username='"+ lstAdminTutorInfo2.Text + "'", con);
            cmd3.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            if (lstAdminTutorInfo2.Text != ""&& lstAdminTutorInfo.Text!="")
            {
                MessageBox.Show("Deleted successfully");
                con.Close();
                Close();
            }
            else
                MessageBox.Show("Please select Username and TutorID option for delete!!");
            con.Close();
        }

        private void btnAdminRecepDone_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminRecepExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdminTutorRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterTutor profile = new RegisterTutor();
            profile.ShowDialog();
            profile = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("delete from TutorProfession where Subject='" + lstAdminTutorInfo9.Text + "'and TutorID='"+lstAdminTutorInfo8.Text+"'", con);
            cmd4.ExecuteNonQuery();
            if (lstAdminTutorInfo9.Text == ""||lstAdminTutorInfo8.Text=="" )
            {
                MessageBox.Show("Please select the tutorID and subject option for delete!!");
            }
            else
                MessageBox.Show("Delete Successful!!");
            con.Close();
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
