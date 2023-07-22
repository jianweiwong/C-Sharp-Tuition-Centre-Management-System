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
    public partial class Recep : Form
    {
        public Recep()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private void Recep_Load(object sender, EventArgs e)
        {
            ArrayList Recep_ID = new ArrayList();
            Recep_ID = AdminADDReceptionist.viewrecep_id();
            foreach (var item in Recep_ID)
            {
                lstAdminRecepInfo.Items.Add(item);
            }
            ArrayList username = new ArrayList();
            username = AdminADDReceptionist.viewusername();
            foreach (var item in username)
            {
                lstAdminRecepInfo2.Items.Add(item);
            }
            ArrayList Ic_Num = new ArrayList();
            Ic_Num = AdminADDReceptionist.viewic_num();
            foreach (var item in Ic_Num)
            {
                lstAdminRecepInfo4.Items.Add(item);
            }
            ArrayList Email = new ArrayList();
            Email = AdminADDReceptionist.viewemail();
            foreach (var item in Email)
            {
                lstAdminRecepInfo5.Items.Add(item);
            }
            ArrayList Contact = new ArrayList();
            Contact = AdminADDReceptionist.viewcontact();
            foreach (var item in Contact)
            {
                lstAdminRecepInfo6.Items.Add(item);
            }
            ArrayList Address = new ArrayList();
            Address = AdminADDReceptionist.viewaddress();
            foreach (var item in Address)
            {
                lstAdminRecepInfo7.Items.Add(item);
            }
        }

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Receptionist where Username='" + lstAdminRecepInfo2.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("delete from Users where Username='"+lstAdminRecepInfo2.Text + "'", con);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            if (lstAdminRecepInfo2.Text != "")
            {
                MessageBox.Show("Deleted successfully");
                con.Close();
                Close();
            }
            else
                MessageBox.Show("Please select Username option for delete!!");
            con.Close();
        }

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdminRecepRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterReceptionist profile = new RegisterReceptionist();
            profile.ShowDialog();
            profile = null;
            this.Show();
        }
    }
}
