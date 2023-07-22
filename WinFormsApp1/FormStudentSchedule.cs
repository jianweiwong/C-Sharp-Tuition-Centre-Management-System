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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class FormStudentSchedule : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string name;

        public FormStudentSchedule(string n)
        {
            InitializeComponent();
            name = n;
        }


        private void buttonStudentScheduleBackMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStudentSchedule_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void TimeTable()
        {

        }

        private void DisplayData()
        {
            listBoxSchedule.Items.Clear();
            ArrayList listTable = new ArrayList();
            listTable = Student.viewSchedule(name);
            listBoxSchedule.Items.Add("Subject                     Day                     Time                Duration(Hours)                Lecturer");
            foreach (var items in listTable)
            {
                listBoxSchedule.Items.Add(items);
            }
            this.Refresh();
        }

        private void labelStudentSelectCourse_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
