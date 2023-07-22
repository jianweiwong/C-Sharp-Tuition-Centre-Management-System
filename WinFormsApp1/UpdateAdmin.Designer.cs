namespace WinFormsApp1
{
    partial class UpdateAdmin
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
            this.btnAdminExit = new System.Windows.Forms.Button();
            this.btnAdminDoneProfile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdminewEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdminewContact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdminewAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdminExit
            // 
            this.btnAdminExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminExit.Location = new System.Drawing.Point(619, 379);
            this.btnAdminExit.Name = "btnAdminExit";
            this.btnAdminExit.Size = new System.Drawing.Size(250, 60);
            this.btnAdminExit.TabIndex = 17;
            this.btnAdminExit.Text = "Exit";
            this.btnAdminExit.UseVisualStyleBackColor = true;
            this.btnAdminExit.Click += new System.EventHandler(this.btnAdminExit_Click);
            // 
            // btnAdminDoneProfile
            // 
            this.btnAdminDoneProfile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminDoneProfile.Location = new System.Drawing.Point(185, 379);
            this.btnAdminDoneProfile.Name = "btnAdminDoneProfile";
            this.btnAdminDoneProfile.Size = new System.Drawing.Size(250, 60);
            this.btnAdminDoneProfile.TabIndex = 16;
            this.btnAdminDoneProfile.Text = "Done";
            this.btnAdminDoneProfile.UseVisualStyleBackColor = true;
            this.btnAdminDoneProfile.Click += new System.EventHandler(this.btnAdminDoneProfile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 50);
            this.label4.TabIndex = 12;
            this.label4.Text = "Update Profile";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(101, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Email :";
            // 
            // txtAdminewEmail
            // 
            this.txtAdminewEmail.Location = new System.Drawing.Point(183, 289);
            this.txtAdminewEmail.Name = "txtAdminewEmail";
            this.txtAdminewEmail.Size = new System.Drawing.Size(730, 27);
            this.txtAdminewEmail.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(74, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "Contact :";
            // 
            // txtAdminewContact
            // 
            this.txtAdminewContact.Location = new System.Drawing.Point(185, 152);
            this.txtAdminewContact.Name = "txtAdminewContact";
            this.txtAdminewContact.Size = new System.Drawing.Size(302, 27);
            this.txtAdminewContact.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(74, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 31);
            this.label8.TabIndex = 24;
            this.label8.Text = "Address :";
            // 
            // txtAdminewAddress
            // 
            this.txtAdminewAddress.Location = new System.Drawing.Point(183, 224);
            this.txtAdminewAddress.Name = "txtAdminewAddress";
            this.txtAdminewAddress.Size = new System.Drawing.Size(730, 27);
            this.txtAdminewAddress.TabIndex = 25;
            // 
            // UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1044, 510);
            this.Controls.Add(this.txtAdminewAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAdminewContact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdminewEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdminExit);
            this.Controls.Add(this.btnAdminDoneProfile);
            this.Controls.Add(this.label4);
            this.Name = "UpdateAdmin";
            this.Text = "UpdateAdmin";
            this.Load += new System.EventHandler(this.UpdateAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdminExit;
        private Button btnAdminDoneProfile;
        private Label label4;
        private Label label6;
        private TextBox txtAdminewEmail;
        private Label label7;
        private TextBox txtAdminewContact;
        private Label label8;
        private TextBox txtAdminewAddress;
    }
}