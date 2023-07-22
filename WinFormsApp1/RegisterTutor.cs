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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class RegisterTutor : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public RegisterTutor()
        {
            InitializeComponent();

        }

        private void btnAdminTutorDone_Click(object sender, EventArgs e)
        {
            Match match1 = Regex.Match(txtAdminTutorEmail.Text, @"^[^@\s]+@[^@\s]+.[^@\s]+$"); // validate email
            Match match2 = Regex.Match(txtAdminTutorICNum.Text, @"^[0-9-]+$");//validate ic
            Match match3 = Regex.Match(txtAdminTutorContact.Text, @"^[0-9-]+$");//validate contact
            Match match4 = Regex.Match(txtAdminTutorUserName.Text, @"^[a-zA-Z ]+$");//validate username
            if (match1.Success && match2.Success && match3.Success && match4.Success)
            {
                AdminADDTutor obj1 = new AdminADDTutor(txtAdminTutorUserName.Text, txtAdminTutorPass.Text, int.Parse(txtAdminTutorLevel.Text.ToString()), txtAdminTutorICNum.Text, txtAdminTutorEmail.Text, txtAdminTutorContact.Text, txtAdminTutorAddress.Text);
                AdminADDTutor obj2 = new AdminADDTutor(CboxAdminRegTutorSubj1.Text);
                AdminADDTutor obj3 = new AdminADDTutor(CboxAdminRegTutorSubj2.Text);
                AdminADDTutor obj4 = new AdminADDTutor(CboxAdminRegTutorSubj3.Text);
                AdminADDTutor obj5 = new AdminADDTutor(CboxAdminRegTutorSubj4.Text);
                AdminADDTutor obj6 = new AdminADDTutor(CboxAdminRegTutorSubj5.Text);
                if (txtAdminTutorConPass.Text != txtAdminTutorPass.Text)
                    MessageBox.Show("Password does not match", "error");
                else if (txtAdminTutorUserName.Text == "" || txtAdminTutorPass.Text == "" || txtAdminTutorLevel.Text == "" || txtAdminTutorICNum.Text == "" || txtAdminTutorEmail.Text == "" || txtAdminTutorContact.Text == "" || txtAdminTutorAddress.Text == "" || CboxAdminRegTutorSubj1.Text == "")
                    MessageBox.Show("Cannot leave it blank!!!");
                else if (CboxAdminRegTutorSubj1.Text == CboxAdminRegTutorSubj2.Text || CboxAdminRegTutorSubj1.Text == CboxAdminRegTutorSubj3.Text || CboxAdminRegTutorSubj1.Text == CboxAdminRegTutorSubj4.Text || CboxAdminRegTutorSubj1.Text == CboxAdminRegTutorSubj5.Text)
                    MessageBox.Show("Subject cannot choose the same");
                else if (int.Parse(txtAdminTutorLevel.Text.ToString()) != 1 && int.Parse(txtAdminTutorLevel.Text.ToString()) != 2 && int.Parse(txtAdminTutorLevel.Text.ToString()) != 3 && int.Parse(txtAdminTutorLevel.Text.ToString()) != 4 && int.Parse(txtAdminTutorLevel.Text.ToString()) != 5)
                    MessageBox.Show("Level out of range");

                else
                {
                    string status = "0";
                    con.Open();
                    SqlCommand test = new SqlCommand("select count(*) as row from Tutor", con);
                    string test1 = test.ExecuteScalar().ToString();
                    if (test1 != "0")
                    {
                        SqlCommand cmd2 = new SqlCommand("select username from Users where username=@user", con);
                        cmd2.Parameters.AddWithValue("@user", txtAdminTutorUserName.Text);
                        SqlDataReader rd;
                        rd = cmd2.ExecuteReader();
                        if (rd.Read())
                        {
                            MessageBox.Show("Username has been used");
                        }
                        else
                        {
                            string test3 = obj1.addTutor();
                            SqlCommand cmd3 = new SqlCommand("select TutorID from Tutor where Username='" + txtAdminTutorUserName.Text + "'", con);
                            rd.Close();
                            string test2 = cmd3.ExecuteScalar().ToString();
                            obj2.addsubj(test2, CboxAdminRegTutorSubj1.Text);
                            if (CboxAdminRegTutorSubj2.Text != "")
                                obj3.addsubj(test2, CboxAdminRegTutorSubj2.Text);
                            if (CboxAdminRegTutorSubj3.Text != "")
                                obj4.addsubj(test2, CboxAdminRegTutorSubj3.Text);

                            if (CboxAdminRegTutorSubj4.Text != "")
                                obj5.addsubj(test2, CboxAdminRegTutorSubj4.Text);

                            if (CboxAdminRegTutorSubj5.Text != "")
                                obj6.addsubj(test2, CboxAdminRegTutorSubj5.Text);
                            MessageBox.Show(test3);
                        }
                    }
                    else
                    {
                        string test3 = obj1.addTutor();
                        SqlCommand cmd3 = new SqlCommand("select TutorID from Tutor where Username='" + txtAdminTutorUserName.Text + "'", con);
                        string test2 = cmd3.ExecuteScalar().ToString();
                        obj2.addsubj(test2, CboxAdminRegTutorSubj1.Text);
                        if (CboxAdminRegTutorSubj2.Text != "")
                            obj3.addsubj(test2, CboxAdminRegTutorSubj2.Text);
                        if (CboxAdminRegTutorSubj3.Text != "")
                            obj4.addsubj(test2, CboxAdminRegTutorSubj3.Text);

                        if (CboxAdminRegTutorSubj4.Text != "")
                            obj5.addsubj(test2, CboxAdminRegTutorSubj4.Text);

                        if (CboxAdminRegTutorSubj5.Text != "")
                            obj6.addsubj(test2, CboxAdminRegTutorSubj5.Text);
                        MessageBox.Show(test3);
                    }
                    con.Close();
                    Close();
                }
            }
            else
                MessageBox.Show("Username/IC/COntact/Email Validation Error!");
        }
        private void RegisterTutor_Load(object sender, EventArgs e)
        {
            ArrayList subject  = new ArrayList();
            subject = AdminADDTutor.viewcombo();
            foreach (var item in subject)
            {
                CboxAdminRegTutorSubj1.Items.Add(item);
                CboxAdminRegTutorSubj2.Items.Add(item);
                CboxAdminRegTutorSubj3.Items.Add(item);
                CboxAdminRegTutorSubj4.Items.Add(item);
                CboxAdminRegTutorSubj5.Items.Add(item);
            }
        }

        private void txtAdminTutorPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
