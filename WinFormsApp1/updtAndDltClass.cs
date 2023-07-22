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
    public partial class updtAndDltClass : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        SqlCommandBuilder sb;
        SqlDataAdapter sda;
        DataTable dt;

        public static string tutorID;
        public updtAndDltClass()
        {
            InitializeComponent();
        }
        public updtAndDltClass(string t)
        {
            InitializeComponent();
            tutorID = t;
        }

        private void btnTutorUpdtDelClassInfo_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updtAndDltClass_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select ClassID,Subject,Day,Time,Duration from Class where TutorID='" + tutorID + "'", con);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dgvTutorUpdtDelClassInfo_ClassInfo.DataSource = dt;
            con.Close();
        }

        private void btnTutorUpdtDelClassInfo_Update_Click(object sender, EventArgs e)
        {
            try
            {
                sb = new SqlCommandBuilder(sda);
                sda.Update(dt);
                MessageBox.Show($"Update Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Class ID cannot be same as others.");
            }
        }

        private void btnTutorUpdtDelClassInfo_Delete_Click(object sender, EventArgs e)
        {
            int index;
            index = dgvTutorUpdtDelClassInfo_ClassInfo.CurrentCell.RowIndex;
            dgvTutorUpdtDelClassInfo_ClassInfo.Rows.RemoveAt(index);

            sb = new SqlCommandBuilder(sda);
            sda.Update(dt);

            MessageBox.Show($"Delete Successfully");
        }
    }
}
