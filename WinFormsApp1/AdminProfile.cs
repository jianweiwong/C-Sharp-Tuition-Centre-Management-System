using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminProfile : Form
    {
        public static string username;
        public AdminProfile()
        {
            InitializeComponent();
        }
        public AdminProfile(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            ArrayList username = new ArrayList();
            username = Admin.viewusername();
            foreach (var item in username)
            {
                lstAdminProfileUsername.Items.Add(item);
            }
            ArrayList IC_Num = new ArrayList();
            IC_Num = Admin.viewic_num();
            foreach (var item in IC_Num)
            {
                lstAdminProfileIC.Items.Add(item);
            }
            ArrayList Email = new ArrayList();
            Email = Admin.viewemail();
            foreach (var item in Email)
            {
                lstAdminProfileEmail.Items.Add(item);
            }
            ArrayList Contact = new ArrayList();
            Contact = Admin.viewcontact();
            foreach (var item in Contact)
            {
                lstAdminProfileContact.Items.Add(item);
            }
            ArrayList Address = new ArrayList();
            Address = Admin.viewaddress();
            foreach (var item in Address)
            {
                lstAdminProfileAddress.Items.Add(item);
            }
        }

        private void btnAdminProfileEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateAdmin profile = new UpdateAdmin(username);
            profile.ShowDialog();
            profile = null;
            this.Show();
        }

        private void btnAdminProfileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstAdminProfileUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstAdminProfileEmail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstAdminProfileAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdminProfileChgPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePassword pass = new UpdatePassword(username);
            pass.ShowDialog();
            pass = null;
            this.Show();
        }
    }
}
