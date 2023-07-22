using System;
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

namespace WinFormsApp1
{
    public partial class Receptionist_Register_Enroll : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static string username;

        public Receptionist_Register_Enroll(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void Receptionist_Register_Enroll_Load(object sender, EventArgs e)
        {
            btnReceptionistRegisterEnroll_ConfirmFirstSubject.Enabled = false;
            btnReceptionistRegisterEnroll_ConfirmSecondSubject.Enabled = false;
            btnReceptionistRegisterEnroll_ConfirmThirdSubject.Enabled = false;
            cmbReceptionistRegisterEnroll_FirstSubject.Enabled = false;
            cmbReceptionistRegisterEnroll_SecondSubject.Enabled=false;
            cmbReceptionistRegisterEnroll_ThirdSubject.Enabled=false;

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReceptionistRegisterEnroll_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReceptionistRegisterEnroll_Confirm_Click(object sender, EventArgs e)
        {
            

            lblReceptionistRegisterEnroll_StudentID.Text = "";
            Match match1 = Regex.Match(txtReceptionistRegisterEnroll_EnterEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // use to validate '@' and '.' in the Email textbox
            Match match2 = Regex.Match(txtReceptionistRegisterEnroll_EnterIDNumber.Text, "^\\d{6}\\-\\d{2}\\-\\d{4}$"); // use to validate correct format '-' in the IC Number textbox
            Match match3 = Regex.Match(txtReceptionistRegisterEnroll_EnterContactNumber.Text, @"^\+?\d{0,3}\-?\d{5,9}"); // use to validate correct format for 

            if (cmbReceptionistRegisterEnroll_ChooseLevel.SelectedItem != null && cmbReceptionistRegisterEnroll_MonthOfEnrollment.SelectedItem != null)
            {
                Receptionist_RegisterStudentAndSubject obj1 = new Receptionist_RegisterStudentAndSubject(txtReceptionistRegisterEnroll_EnterName.Text, 
                                    txtReceptionistRegisterEnroll_EnterIDNumber.Text,
                                    txtReceptionistRegisterEnroll_EnterEmail.Text, 
                                    txtReceptionistRegisterEnroll_EnterContactNumber.Text,
                                    txtReceptionistRegisterEnroll_EnterAddress.Text, 
                                    txtReceptionistRegisterEnroll_EnterAccountPassword.Text,
                                    int.Parse(cmbReceptionistRegisterEnroll_ChooseLevel.SelectedItem.ToString()),
                                    cmbReceptionistRegisterEnroll_MonthOfEnrollment.GetItemText(cmbReceptionistRegisterEnroll_MonthOfEnrollment.SelectedItem));

                string status = "0";
                con.Open();
                SqlCommand test2 = new SqlCommand("select count(*) as row from Users", con);
                string test1 = test2.ExecuteScalar().ToString();
                if (test1 != "0")
                {
                    SqlCommand cmd2 = new SqlCommand("select Username from Users where Username=@Username", con);
                    cmd2.Parameters.AddWithValue("@Username", txtReceptionistRegisterEnroll_EnterName.Text);
                    SqlDataReader rd;
                    rd = cmd2.ExecuteReader();
                    if (rd.Read())
                    {
                        MessageBox.Show("Username has been used");
                    }
                    else
                    {
                        if (match2.Success)
                        {
                            if (match1.Success)
                            {
                                if (match3.Success)
                                {

                                    if (txtReceptionistRegisterEnroll_EnterName.Text == "" || txtReceptionistRegisterEnroll_EnterIDNumber.Text == "" || txtReceptionistRegisterEnroll_EnterEmail.Text == "" ||
                                        txtReceptionistRegisterEnroll_EnterContactNumber.Text == "" || txtReceptionistRegisterEnroll_EnterAddress.Text == "" || txtReceptionistRegisterEnroll_EnterAccountPassword.Text == "")
                                    {
                                        MessageBox.Show("Please fill up all required information in Student Details.");
                                    }



                                    else
                                    {
                                        MessageBox.Show(obj1.RegisterEnrollStudent() + "\n" + "New StudentID is: " + obj1.StudentID1);
                                        lblReceptionistRegisterEnroll_StudentID.Text = obj1.StudentID1;
                                        btnReceptionistRegisterEnroll_ConfirmFirstSubject.Enabled = true;
                                        cmbReceptionistRegisterEnroll_FirstSubject.Enabled = true;                                      
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Contact Number format.");
                                    txtReceptionistRegisterEnroll_EnterContactNumber.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email format.");
                                txtReceptionistRegisterEnroll_EnterEmail.Focus();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid IC Number or Passport Number format.");
                            txtReceptionistRegisterEnroll_EnterIDNumber.Focus();
                        };
                    }
                }
                else
                {
                    MessageBox.Show("Can register Stuident with the username, pt1");
                }
                con.Close();
                

                


            }
            else
            {
                MessageBox.Show("Please fill up all required information in Student Details.");
            }
        }
            




            

       





        private void btnReceptionistRegisterEnroll_ConfirmFirstSubject_Click(object sender, EventArgs e)
        {

            if (cmbReceptionistRegisterEnroll_FirstSubject.SelectedItem != null)
            {
                Receptionist_RegisterStudentAndSubject obj2 = new Receptionist_RegisterStudentAndSubject(cmbReceptionistRegisterEnroll_FirstSubject.GetItemText(cmbReceptionistRegisterEnroll_FirstSubject.SelectedItem));
                MessageBox.Show(obj2.SubjectEnrollStudent1(lblReceptionistRegisterEnroll_StudentID.Text, cmbReceptionistRegisterEnroll_FirstSubject.GetItemText(cmbReceptionistRegisterEnroll_FirstSubject.SelectedItem)));

                cmbReceptionistRegisterEnroll_SecondSubject.Items.Remove(cmbReceptionistRegisterEnroll_FirstSubject.SelectedItem);
                cmbReceptionistRegisterEnroll_ThirdSubject.Items.Remove(cmbReceptionistRegisterEnroll_FirstSubject.SelectedItem);
                btnReceptionistRegisterEnroll_ConfirmFirstSubject.Enabled = false;
                btnReceptionistRegisterEnroll_ConfirmSecondSubject.Enabled = true;
                cmbReceptionistRegisterEnroll_SecondSubject.Enabled = true;
                cmbReceptionistRegisterEnroll_FirstSubject.Enabled = false;
            }
            else
            {
                MessageBox.Show("First subject not chosen");
                cmbReceptionistRegisterEnroll_FirstSubject.Focus();
            }
        }

        private void btnReceptionistRegisterEnroll_ConfirmSecondSubject_Click(object sender, EventArgs e)
        {

            if (cmbReceptionistRegisterEnroll_FirstSubject.SelectedItem != null)
            {
                if (cmbReceptionistRegisterEnroll_SecondSubject.SelectedItem != null)
                {
                    Receptionist_RegisterStudentAndSubject obj2 = new Receptionist_RegisterStudentAndSubject(cmbReceptionistRegisterEnroll_SecondSubject.GetItemText(cmbReceptionistRegisterEnroll_SecondSubject.SelectedItem));
                    MessageBox.Show(obj2.SubjectEnrollStudent1(lblReceptionistRegisterEnroll_StudentID.Text, cmbReceptionistRegisterEnroll_SecondSubject.GetItemText(cmbReceptionistRegisterEnroll_SecondSubject.SelectedItem)));
                    cmbReceptionistRegisterEnroll_FirstSubject.Items.Remove(cmbReceptionistRegisterEnroll_SecondSubject.SelectedItem);
                    cmbReceptionistRegisterEnroll_ThirdSubject.Items.Remove(cmbReceptionistRegisterEnroll_SecondSubject.SelectedItem);
                    btnReceptionistRegisterEnroll_ConfirmSecondSubject.Enabled = false;
                    btnReceptionistRegisterEnroll_ConfirmThirdSubject.Enabled = true;
                    cmbReceptionistRegisterEnroll_ThirdSubject.Enabled = true;
                    cmbReceptionistRegisterEnroll_SecondSubject.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Second subject not chosen");
                    cmbReceptionistRegisterEnroll_SecondSubject.Focus();
                }
            }
            else
            {
                MessageBox.Show("First subject not chosen");
                cmbReceptionistRegisterEnroll_FirstSubject.Focus();
            }

        }

        private void btnReceptionistRegisterEnroll_ConfirmThirdSubject_Click(object sender, EventArgs e)
        {
            if (cmbReceptionistRegisterEnroll_FirstSubject.SelectedItem != null)
            {
                if (cmbReceptionistRegisterEnroll_SecondSubject.SelectedItem != null)
                {
                    if(cmbReceptionistRegisterEnroll_ThirdSubject.SelectedItem != null)
                    {
                        Receptionist_RegisterStudentAndSubject obj2 = new Receptionist_RegisterStudentAndSubject(cmbReceptionistRegisterEnroll_ThirdSubject.GetItemText(cmbReceptionistRegisterEnroll_ThirdSubject.SelectedItem));
                        MessageBox.Show(obj2.SubjectEnrollStudent1(lblReceptionistRegisterEnroll_StudentID.Text, cmbReceptionistRegisterEnroll_ThirdSubject.GetItemText(cmbReceptionistRegisterEnroll_ThirdSubject.SelectedItem)));
                        cmbReceptionistRegisterEnroll_FirstSubject.Items.Remove(cmbReceptionistRegisterEnroll_ThirdSubject.SelectedItem);
                        cmbReceptionistRegisterEnroll_SecondSubject.Items.Remove(cmbReceptionistRegisterEnroll_ThirdSubject.SelectedItem);
                        btnReceptionistRegisterEnroll_ConfirmThirdSubject.Enabled = false;
                        cmbReceptionistRegisterEnroll_ThirdSubject.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("Third subject not chosen");
                        cmbReceptionistRegisterEnroll_ThirdSubject.Focus();
                    }
                

                }
                else
                {
                    MessageBox.Show("Second subject not chosen");
                    cmbReceptionistRegisterEnroll_SecondSubject.Focus();
                }
            }
            else
            {
                MessageBox.Show("First subject not chosen");
                cmbReceptionistRegisterEnroll_FirstSubject.Focus();
            }
            
        }

        

    }

}