namespace WinFormsApp1
{
    public partial class Receptionist_Login : Form
    {
        public Receptionist_Login()
        {
            InitializeComponent();
        }

        private void Receptionist_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnMainPage_Login_Click(object sender, EventArgs e)
        {
            string status;
            Users obj1 = new Users(txtMainPage_EnterUsername.Text, txtMainPage_EnterPassword.Text);
            Hide();
            status = obj1.login(txtMainPage_EnterUsername.Text);
            if (status != null)
            {
                MessageBox.Show(status);
            }
            Show();

            txtMainPage_EnterUsername.Text = String.Empty;
            txtMainPage_EnterPassword.Text = String.Empty;
        }

        private void btnMainPage_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //close window
            }
        }
    }
}