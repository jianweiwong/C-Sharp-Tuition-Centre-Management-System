namespace WinFormsApp1
{
    partial class AdminProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminProfileEdit = new System.Windows.Forms.Button();
            this.btnAdminProfileExit = new System.Windows.Forms.Button();
            this.lstAdminProfileUsername = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstAdminProfileIC = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstAdminProfileEmail = new System.Windows.Forms.ListBox();
            this.lstAdminProfileContact = new System.Windows.Forms.ListBox();
            this.lstAdminProfileAddress = new System.Windows.Forms.ListBox();
            this.btnAdminProfileChgPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // btnAdminProfileEdit
            // 
            this.btnAdminProfileEdit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminProfileEdit.Location = new System.Drawing.Point(395, 371);
            this.btnAdminProfileEdit.Name = "btnAdminProfileEdit";
            this.btnAdminProfileEdit.Size = new System.Drawing.Size(230, 50);
            this.btnAdminProfileEdit.TabIndex = 2;
            this.btnAdminProfileEdit.Text = "Edit";
            this.btnAdminProfileEdit.UseVisualStyleBackColor = true;
            this.btnAdminProfileEdit.Click += new System.EventHandler(this.btnAdminProfileEdit_Click);
            // 
            // btnAdminProfileExit
            // 
            this.btnAdminProfileExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminProfileExit.Location = new System.Drawing.Point(631, 371);
            this.btnAdminProfileExit.Name = "btnAdminProfileExit";
            this.btnAdminProfileExit.Size = new System.Drawing.Size(230, 50);
            this.btnAdminProfileExit.TabIndex = 6;
            this.btnAdminProfileExit.Text = "Exit";
            this.btnAdminProfileExit.UseVisualStyleBackColor = true;
            this.btnAdminProfileExit.Click += new System.EventHandler(this.btnAdminProfileExit_Click);
            // 
            // lstAdminProfileUsername
            // 
            this.lstAdminProfileUsername.FormattingEnabled = true;
            this.lstAdminProfileUsername.ItemHeight = 20;
            this.lstAdminProfileUsername.Location = new System.Drawing.Point(150, 126);
            this.lstAdminProfileUsername.Name = "lstAdminProfileUsername";
            this.lstAdminProfileUsername.Size = new System.Drawing.Size(208, 24);
            this.lstAdminProfileUsername.TabIndex = 7;
            this.lstAdminProfileUsername.SelectedIndexChanged += new System.EventHandler(this.lstAdminProfileUsername_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "IC_Num :";
            // 
            // lstAdminProfileIC
            // 
            this.lstAdminProfileIC.FormattingEnabled = true;
            this.lstAdminProfileIC.ItemHeight = 20;
            this.lstAdminProfileIC.Location = new System.Drawing.Point(150, 188);
            this.lstAdminProfileIC.Name = "lstAdminProfileIC";
            this.lstAdminProfileIC.Size = new System.Drawing.Size(208, 24);
            this.lstAdminProfileIC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(449, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(426, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contact :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(36, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address :";
            // 
            // lstAdminProfileEmail
            // 
            this.lstAdminProfileEmail.FormattingEnabled = true;
            this.lstAdminProfileEmail.ItemHeight = 20;
            this.lstAdminProfileEmail.Location = new System.Drawing.Point(536, 181);
            this.lstAdminProfileEmail.Name = "lstAdminProfileEmail";
            this.lstAdminProfileEmail.Size = new System.Drawing.Size(208, 24);
            this.lstAdminProfileEmail.TabIndex = 14;
            this.lstAdminProfileEmail.SelectedIndexChanged += new System.EventHandler(this.lstAdminProfileEmail_SelectedIndexChanged);
            // 
            // lstAdminProfileContact
            // 
            this.lstAdminProfileContact.FormattingEnabled = true;
            this.lstAdminProfileContact.ItemHeight = 20;
            this.lstAdminProfileContact.Location = new System.Drawing.Point(536, 127);
            this.lstAdminProfileContact.Name = "lstAdminProfileContact";
            this.lstAdminProfileContact.Size = new System.Drawing.Size(208, 24);
            this.lstAdminProfileContact.TabIndex = 15;
            // 
            // lstAdminProfileAddress
            // 
            this.lstAdminProfileAddress.FormattingEnabled = true;
            this.lstAdminProfileAddress.ItemHeight = 20;
            this.lstAdminProfileAddress.Location = new System.Drawing.Point(150, 248);
            this.lstAdminProfileAddress.Name = "lstAdminProfileAddress";
            this.lstAdminProfileAddress.Size = new System.Drawing.Size(531, 24);
            this.lstAdminProfileAddress.TabIndex = 16;
            this.lstAdminProfileAddress.SelectedIndexChanged += new System.EventHandler(this.lstAdminProfileAddress_SelectedIndexChanged);
            // 
            // btnAdminProfileChgPass
            // 
            this.btnAdminProfileChgPass.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminProfileChgPass.Location = new System.Drawing.Point(37, 371);
            this.btnAdminProfileChgPass.Name = "btnAdminProfileChgPass";
            this.btnAdminProfileChgPass.Size = new System.Drawing.Size(352, 50);
            this.btnAdminProfileChgPass.TabIndex = 17;
            this.btnAdminProfileChgPass.Text = "Change Password";
            this.btnAdminProfileChgPass.UseVisualStyleBackColor = true;
            this.btnAdminProfileChgPass.Click += new System.EventHandler(this.btnAdminProfileChgPass_Click);
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.btnAdminProfileChgPass);
            this.Controls.Add(this.lstAdminProfileAddress);
            this.Controls.Add(this.lstAdminProfileContact);
            this.Controls.Add(this.lstAdminProfileEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstAdminProfileIC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstAdminProfileUsername);
            this.Controls.Add(this.btnAdminProfileExit);
            this.Controls.Add(this.btnAdminProfileEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAdminProfileEdit;
        private Button btnAdminProfileExit;
        private ListBox lstAdminProfileUsername;
        private Label label4;
        private ListBox lstAdminProfileIC;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox lstAdminProfileEmail;
        private ListBox lstAdminProfileContact;
        private ListBox lstAdminProfileAddress;
        private Button btnAdminProfileChgPass;
    }
}