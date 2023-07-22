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
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class addClassInfoTutor : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string TutorID;
        public addClassInfoTutor()
        {
            InitializeComponent();
        }

        public addClassInfoTutor(string n)
        {
            InitializeComponent();
            TutorID = n;
        }

        private void btnTutorAddClassInfo_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTutorAddClassInfo_Add_Click(object sender, EventArgs e)
        {
            ClassInfo obj1 = new ClassInfo(TutorID, comboBoxSubject.Text,
                cboTutorAddClassInfo_Day.SelectedItem.ToString(),
                txtTutorAddClassInfo_Time.Text, txtTutorAddClassInfo_Duration.Text);


            MessageBox.Show(obj1.addClassInfo());
        }

        private void addClassInfoTutor_Load(object sender, EventArgs e)
        {
            lblTutorAddClassInfo_TutorID.Text = TutorID;

            con.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter("select TutorProfession.* from TutorProfession where TutorID= '" + TutorID + "'", con);
            adapt.Fill(dt, "Subject");
            comboBoxSubject.DataSource = dt.Tables["Subject"];
            comboBoxSubject.DisplayMember = "Subject";
            con.Close();
        }
    }
}
