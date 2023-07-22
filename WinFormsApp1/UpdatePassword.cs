using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class UpdatePassword : Form
    {
        public static string username;
        public UpdatePassword(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User obj1 = new User(username);
            if (txtAdminewPass.Text != txtAdminConfNewPass.Text)
                MessageBox.Show("Password does not match", "error");
            else
                MessageBox.Show(obj1.UpdatePasswordTutor(txtAdminewPass.Text));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
