namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtLoginPage_EnterPassword = new System.Windows.Forms.TextBox();
            this.txtLoginPage_EnterUsername = new System.Windows.Forms.TextBox();
            this.lblLoginPage_Username = new System.Windows.Forms.Label();
            this.lblLoginPage_Password = new System.Windows.Forms.Label();
            this.btnLoginPage_Login = new System.Windows.Forms.Button();
            this.lblLoginPage_SignIn = new System.Windows.Forms.Label();
            this.picLoginPage_Logo = new System.Windows.Forms.PictureBox();
            this.lblLoginPage_ETC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginPage_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoginPage_EnterPassword
            // 
            this.txtLoginPage_EnterPassword.Location = new System.Drawing.Point(378, 350);
            this.txtLoginPage_EnterPassword.Name = "txtLoginPage_EnterPassword";
            this.txtLoginPage_EnterPassword.PasswordChar = '*';
            this.txtLoginPage_EnterPassword.PlaceholderText = "Password";
            this.txtLoginPage_EnterPassword.Size = new System.Drawing.Size(205, 27);
            this.txtLoginPage_EnterPassword.TabIndex = 23;
            // 
            // txtLoginPage_EnterUsername
            // 
            this.txtLoginPage_EnterUsername.Location = new System.Drawing.Point(378, 264);
            this.txtLoginPage_EnterUsername.Name = "txtLoginPage_EnterUsername";
            this.txtLoginPage_EnterUsername.PlaceholderText = "Username";
            this.txtLoginPage_EnterUsername.Size = new System.Drawing.Size(205, 27);
            this.txtLoginPage_EnterUsername.TabIndex = 22;
            // 
            // lblLoginPage_Username
            // 
            this.lblLoginPage_Username.AutoSize = true;
            this.lblLoginPage_Username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginPage_Username.Location = new System.Drawing.Point(221, 260);
            this.lblLoginPage_Username.Name = "lblLoginPage_Username";
            this.lblLoginPage_Username.Size = new System.Drawing.Size(117, 31);
            this.lblLoginPage_Username.TabIndex = 21;
            this.lblLoginPage_Username.Text = "Username";
            // 
            // lblLoginPage_Password
            // 
            this.lblLoginPage_Password.AutoSize = true;
            this.lblLoginPage_Password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginPage_Password.Location = new System.Drawing.Point(221, 346);
            this.lblLoginPage_Password.Name = "lblLoginPage_Password";
            this.lblLoginPage_Password.Size = new System.Drawing.Size(110, 31);
            this.lblLoginPage_Password.TabIndex = 20;
            this.lblLoginPage_Password.Text = "Password";
            // 
            // btnLoginPage_Login
            // 
            this.btnLoginPage_Login.Location = new System.Drawing.Point(345, 418);
            this.btnLoginPage_Login.Name = "btnLoginPage_Login";
            this.btnLoginPage_Login.Size = new System.Drawing.Size(94, 29);
            this.btnLoginPage_Login.TabIndex = 19;
            this.btnLoginPage_Login.Text = "Login";
            this.btnLoginPage_Login.UseVisualStyleBackColor = true;
            this.btnLoginPage_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLoginPage_SignIn
            // 
            this.lblLoginPage_SignIn.AutoSize = true;
            this.lblLoginPage_SignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginPage_SignIn.Location = new System.Drawing.Point(357, 208);
            this.lblLoginPage_SignIn.Name = "lblLoginPage_SignIn";
            this.lblLoginPage_SignIn.Size = new System.Drawing.Size(72, 28);
            this.lblLoginPage_SignIn.TabIndex = 18;
            this.lblLoginPage_SignIn.Text = "Sign In";
            // 
            // picLoginPage_Logo
            // 
            this.picLoginPage_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picLoginPage_Logo.Image")));
            this.picLoginPage_Logo.Location = new System.Drawing.Point(328, 12);
            this.picLoginPage_Logo.Name = "picLoginPage_Logo";
            this.picLoginPage_Logo.Size = new System.Drawing.Size(132, 136);
            this.picLoginPage_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoginPage_Logo.TabIndex = 24;
            this.picLoginPage_Logo.TabStop = false;
            this.picLoginPage_Logo.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblLoginPage_ETC
            // 
            this.lblLoginPage_ETC.AutoSize = true;
            this.lblLoginPage_ETC.Font = new System.Drawing.Font("Brush Script MT", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblLoginPage_ETC.Location = new System.Drawing.Point(242, 163);
            this.lblLoginPage_ETC.Name = "lblLoginPage_ETC";
            this.lblLoginPage_ETC.Size = new System.Drawing.Size(308, 34);
            this.lblLoginPage_ETC.TabIndex = 25;
            this.lblLoginPage_ETC.Text = "Excellent Tuition Centre (ETC)";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.lblLoginPage_ETC);
            this.Controls.Add(this.picLoginPage_Logo);
            this.Controls.Add(this.txtLoginPage_EnterPassword);
            this.Controls.Add(this.txtLoginPage_EnterUsername);
            this.Controls.Add(this.lblLoginPage_Username);
            this.Controls.Add(this.lblLoginPage_Password);
            this.Controls.Add(this.btnLoginPage_Login);
            this.Controls.Add(this.lblLoginPage_SignIn);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picLoginPage_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtLoginPage_EnterPassword;
        private TextBox txtLoginPage_EnterUsername;
        private Label lblLoginPage_Username;
        private Label lblLoginPage_Password;
        private Button btnLoginPage_Login;
        private Label lblLoginPage_SignIn;
        private PictureBox picLoginPage_Logo;
        private Label lblLoginPage_ETC;
    }
}