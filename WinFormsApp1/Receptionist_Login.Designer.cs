namespace WinFormsApp1
{
    partial class Receptionist_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMainPage_EnterUsername = new System.Windows.Forms.TextBox();
            this.txtMainPage_EnterPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMainPage_Login = new System.Windows.Forms.Button();
            this.btnMainPage_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtMainPage_EnterUsername
            // 
            this.txtMainPage_EnterUsername.Location = new System.Drawing.Point(363, 178);
            this.txtMainPage_EnterUsername.Name = "txtMainPage_EnterUsername";
            this.txtMainPage_EnterUsername.Size = new System.Drawing.Size(200, 27);
            this.txtMainPage_EnterUsername.TabIndex = 2;
            // 
            // txtMainPage_EnterPassword
            // 
            this.txtMainPage_EnterPassword.Location = new System.Drawing.Point(363, 226);
            this.txtMainPage_EnterPassword.Name = "txtMainPage_EnterPassword";
            this.txtMainPage_EnterPassword.PasswordChar = '*';
            this.txtMainPage_EnterPassword.Size = new System.Drawing.Size(200, 27);
            this.txtMainPage_EnterPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 80);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome to Excellent Tuition Centre(ETC) Management System.\r\n\r\n\r\nEnter your usern" +
    "ame and password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainPage_Login
            // 
            this.btnMainPage_Login.Location = new System.Drawing.Point(353, 291);
            this.btnMainPage_Login.Name = "btnMainPage_Login";
            this.btnMainPage_Login.Size = new System.Drawing.Size(94, 29);
            this.btnMainPage_Login.TabIndex = 5;
            this.btnMainPage_Login.Text = "Login";
            this.btnMainPage_Login.UseVisualStyleBackColor = true;
            this.btnMainPage_Login.Click += new System.EventHandler(this.btnMainPage_Login_Click);
            // 
            // btnMainPage_Exit
            // 
            this.btnMainPage_Exit.Location = new System.Drawing.Point(353, 380);
            this.btnMainPage_Exit.Name = "btnMainPage_Exit";
            this.btnMainPage_Exit.Size = new System.Drawing.Size(94, 29);
            this.btnMainPage_Exit.TabIndex = 6;
            this.btnMainPage_Exit.Text = "Exit";
            this.btnMainPage_Exit.UseVisualStyleBackColor = true;
            this.btnMainPage_Exit.Click += new System.EventHandler(this.btnMainPage_Exit_Click);
            // 
            // Receptionist_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainPage_Exit);
            this.Controls.Add(this.btnMainPage_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMainPage_EnterPassword);
            this.Controls.Add(this.txtMainPage_EnterUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Receptionist_Login";
            this.Text = "Main_Page_Login";
            this.Load += new System.EventHandler(this.Receptionist_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMainPage_EnterUsername;
        private TextBox txtMainPage_EnterPassword;
        private Label label3;
        private Button btnMainPage_Login;
        private Button btnMainPage_Exit;
    }
}