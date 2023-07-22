using System;
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
    public partial class UpdateProfileTutor : Form
    {
        public static string username;
        public UpdateProfileTutor()
        {
            InitializeComponent();
        }
        public UpdateProfileTutor(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void btnTutorUpdtProfile_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTutorUpdtProfile_Update_Click(object sender, EventArgs e)
        {
            Tutor obj1 = new Tutor(username);
            MessageBox.Show(obj1.UpdateProfileTutor(txtTutorUpdtProfile_Email.Text,
                txtTutorUpdtProfile_Contact.Text, txtTutorUpdtProfile_Address.Text));

            User obj2 = new User(username);
            MessageBox.Show(obj2.UpdatePasswordTutor(txtTutorUpdtProfile_Password.Text));
        }

        private void UpdateProfileTutor_Load(object sender, EventArgs e)
        {
            User obj2 = new User(username);
            User.viewPasswordTutor(obj2);
            txtTutorUpdtProfile_Password.Text = obj2.Password;

            Tutor obj1 = new Tutor(username);
            Tutor.viewProfile(obj1);
            lblTutorUpdtProfile_ID.Text = obj1.TutorID;
            lblTutorUpdtProfile_Username.Text = obj1.Username;
            lblTutorUpdtProfile_ICPassport.Text = obj1.ICPass1;
            txtTutorUpdtProfile_Email.Text = obj1.Email;
            txtTutorUpdtProfile_Contact.Text = obj1.Contact;
            txtTutorUpdtProfile_Address.Text = obj1.Address;
        }
    }
}
