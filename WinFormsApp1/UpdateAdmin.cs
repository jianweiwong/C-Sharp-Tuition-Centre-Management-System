using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class UpdateAdmin : Form
    {
        public static string username;
        public UpdateAdmin()
        {
            InitializeComponent();
        }
        public UpdateAdmin(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {
            Admin obj1 = new Admin(username);
            Admin.viewprofile(obj1);

            txtAdminewEmail.Text = obj1.Email1;
            txtAdminewContact.Text = obj1.Contact1;
            txtAdminewAddress.Text = obj1.Address1;
        }

        private void btnAdminDoneProfile_Click(object sender, EventArgs e)
        {
            Admin obj1 = new Admin(username);
            MessageBox.Show(obj1.updateProfile(txtAdminewEmail.Text, txtAdminewContact.Text,txtAdminewAddress.Text));
            this.Close();
        }

        private void txtAdminConfNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
