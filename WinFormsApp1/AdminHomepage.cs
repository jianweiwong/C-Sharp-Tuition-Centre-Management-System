using System.Configuration;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class AdminHomepage : Form
    {
        public static string username;
        public AdminHomepage(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTutors vs = new ViewTutors();
            vs.ShowDialog();
            vs = null;
            this.Show();
        }

        private void btnAdminRegisterTutor_Click(object sender, EventArgs e)
        {

        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {
            lblAdminHomepageWel.Text="Welcome, "+username;
        }

        private void btnAdminViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProfile profile = new AdminProfile(username);
            profile.ShowDialog();
            profile=null;
            this.Show();
            
        }

        private void btnAdminHomepageReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Report report=new View_Report();
            report.ShowDialog();
            report = null;
            this.Show();
        }

        private void btnAdminRegisterReceptionist_Click(object sender, EventArgs e)
        {
        }

        private void btnAdminViewReceptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recep recep = new Recep();
            recep.ShowDialog();
            recep= null;
            this.Show();
        }

        private void btnAdminOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}