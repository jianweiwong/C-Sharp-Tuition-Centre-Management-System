using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class FormStudentMainMenu : Form
    {
        public static string name;


        public FormStudentMainMenu()
        {
            InitializeComponent();
        }

        public FormStudentMainMenu(string n)
        {
            InitializeComponent();
            name = n;
        }


        private void buttonStudentSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStudentSchedule schedule = new FormStudentSchedule(name);
            schedule.ShowDialog();
            schedule = null;
            this.Show();
        }

        private void buttonStudentRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStudentRequest request = new FormStudentRequest(name);
            request.ShowDialog();
            request = null;
            this.Show();
        }

        private void buttonStudentProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStudentProfile profile = new FormStudentProfile(name);
            profile.ShowDialog();
            profile = null;
            this.Show();
        }

        private void FormStudentMainMenu_Load(object sender, EventArgs e)
        {
            labelStudentMainMenu.Text = "Welcome, " + name;
        }

        private void labelStudentMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void buttonStudentLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
