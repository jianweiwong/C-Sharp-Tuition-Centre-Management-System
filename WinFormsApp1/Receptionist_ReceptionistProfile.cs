using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    internal class Receptionist_ReceptionistProfile
    {
        private string Username;
        private string ICPassport;
        private string Email;
        private string Contact;
        private string Address;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Username1 { get => Username; set => Username = value; }
        public string ICPassport1 { get => ICPassport; set => ICPassport = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Contact1 { get => Contact; set => Contact = value; }
        public string Address1 { get => Address; set => Address = value; }

        public Receptionist_ReceptionistProfile(string un)
        {
            Username = un;
        }

        public static void ViewProfile(Receptionist_ReceptionistProfile o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Receptionist where Username='" + o1.Username + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                try
                {
                    o1.Username = rd.GetString(1);
                    o1.ICPassport = rd.GetString(2);
                    o1.Email = rd.GetString(3);
                    o1.Contact = rd.GetString(4);
                    o1.Address = rd.GetString(5);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }

            }
            con.Close();
        }

        public string UpdateProfile(string em, string cn, string ad)
        {
            string status;
            con.Open();
            Email = em;
            Contact = cn;
            Address = ad;

            SqlCommand cmd = new SqlCommand("update Receptionist set Email='" + Email + "', Contact='" + Contact + "', Address='" + Address + "' where Username ='" + Username + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }
    }
}
