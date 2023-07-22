using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class FormStudentUpdatePassword : Form
    {
        public static string name;
        public static string password;

        public FormStudentUpdatePassword(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void buttonStudentConfirmUpdatePassword_Click(object sender, EventArgs e)
        {
            Student obj1 = new Student(name);
            MessageBox.Show(obj1.updatePassword(textBoxStudentCurrentPassword.Text, textBoxStudentNewPassword.Text));
        }

        private void buttonStudentUpdatePasswordBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxStudentOldPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelStudentOldPassword_Click(object sender, EventArgs e)
        {

        }

        private void FormStudentUpdatePassword_Load(object sender, EventArgs e)
        {

        }
    }
}