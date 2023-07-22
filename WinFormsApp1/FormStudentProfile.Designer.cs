namespace WinFormsApp1
{
    partial class FormStudentProfile
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
            this.buttonStudentUpdateProfile = new System.Windows.Forms.Button();
            this.buttonStudentProfileBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMonthofEnrollment = new System.Windows.Forms.Label();
            this.labelStudentProfileNameValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStudentIDValue = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.listBoxSubject = new System.Windows.Forms.ListBox();
            this.buttonStudentUpdatePassword = new System.Windows.Forms.Button();
            this.labelStudentProfilePhoneValue = new System.Windows.Forms.Label();
            this.labelStudentProfileAddressValue = new System.Windows.Forms.Label();
            this.labelStudentProfileLevelValue = new System.Windows.Forms.Label();
            this.labelStudentProfileMonthValue = new System.Windows.Forms.Label();
            this.labelStudentProfileEmailValue = new System.Windows.Forms.Label();
            this.labelStudentProfileICValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStudentUpdateProfile
            // 
            this.buttonStudentUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentUpdateProfile.Location = new System.Drawing.Point(686, 291);
            this.buttonStudentUpdateProfile.Name = "buttonStudentUpdateProfile";
            this.buttonStudentUpdateProfile.Size = new System.Drawing.Size(155, 34);
            this.buttonStudentUpdateProfile.TabIndex = 8;
            this.buttonStudentUpdateProfile.Text = "Update Profile";
            this.buttonStudentUpdateProfile.UseVisualStyleBackColor = true;
            this.buttonStudentUpdateProfile.Click += new System.EventHandler(this.buttonStudentUpdateProfile_Click);
            // 
            // buttonStudentProfileBack
            // 
            this.buttonStudentProfileBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentProfileBack.Location = new System.Drawing.Point(686, 400);
            this.buttonStudentProfileBack.Name = "buttonStudentProfileBack";
            this.buttonStudentProfileBack.Size = new System.Drawing.Size(155, 34);
            this.buttonStudentProfileBack.TabIndex = 9;
            this.buttonStudentProfileBack.Text = "Back";
            this.buttonStudentProfileBack.UseVisualStyleBackColor = true;
            this.buttonStudentProfileBack.Click += new System.EventHandler(this.buttonStudentProfileBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "IC/Passport";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(288, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // labelMonthofEnrollment
            // 
            this.labelMonthofEnrollment.AutoSize = true;
            this.labelMonthofEnrollment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMonthofEnrollment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMonthofEnrollment.Location = new System.Drawing.Point(25, 406);
            this.labelMonthofEnrollment.Name = "labelMonthofEnrollment";
            this.labelMonthofEnrollment.Size = new System.Drawing.Size(179, 27);
            this.labelMonthofEnrollment.TabIndex = 8;
            this.labelMonthofEnrollment.Text = "Month of Enrollment";
            // 
            // labelStudentProfileNameValue
            // 
            this.labelStudentProfileNameValue.AutoSize = true;
            this.labelStudentProfileNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentProfileNameValue.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentProfileNameValue.Location = new System.Drawing.Point(365, 44);
            this.labelStudentProfileNameValue.Name = "labelStudentProfileNameValue";
            this.labelStudentProfileNameValue.Size = new System.Drawing.Size(2, 31);
            this.labelStudentProfileNameValue.TabIndex = 17;
            this.labelStudentProfileNameValue.Click += new System.EventHandler(this.label15_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelStudentIDValue);
            this.groupBox1.Controls.Add(this.labelStudentID);
            this.groupBox1.Controls.Add(this.listBoxSubject);
            this.groupBox1.Controls.Add(this.buttonStudentUpdatePassword);
            this.groupBox1.Controls.Add(this.labelStudentProfilePhoneValue);
            this.groupBox1.Controls.Add(this.buttonStudentProfileBack);
            this.groupBox1.Controls.Add(this.labelStudentProfileAddressValue);
            this.groupBox1.Controls.Add(this.buttonStudentUpdateProfile);
            this.groupBox1.Controls.Add(this.labelStudentProfileLevelValue);
            this.groupBox1.Controls.Add(this.labelStudentProfileMonthValue);
            this.groupBox1.Controls.Add(this.labelStudentProfileEmailValue);
            this.groupBox1.Controls.Add(this.labelStudentProfileICValue);
            this.groupBox1.Controls.Add(this.labelStudentProfileNameValue);
            this.groupBox1.Controls.Add(this.labelMonthofEnrollment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(49, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 455);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Profile";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelStudentIDValue
            // 
            this.labelStudentIDValue.AutoSize = true;
            this.labelStudentIDValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentIDValue.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentIDValue.Location = new System.Drawing.Point(146, 44);
            this.labelStudentIDValue.Name = "labelStudentIDValue";
            this.labelStudentIDValue.Size = new System.Drawing.Size(2, 31);
            this.labelStudentIDValue.TabIndex = 28;
            this.labelStudentIDValue.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentID.Location = new System.Drawing.Point(25, 48);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(98, 27);
            this.labelStudentID.TabIndex = 27;
            this.labelStudentID.Text = "Student ID";
            // 
            // listBoxSubject
            // 
            this.listBoxSubject.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBoxSubject.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxSubject.FormattingEnabled = true;
            this.listBoxSubject.ItemHeight = 26;
            this.listBoxSubject.Location = new System.Drawing.Point(650, 47);
            this.listBoxSubject.Name = "listBoxSubject";
            this.listBoxSubject.Size = new System.Drawing.Size(191, 108);
            this.listBoxSubject.TabIndex = 26;
            this.listBoxSubject.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonStudentUpdatePassword
            // 
            this.buttonStudentUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentUpdatePassword.Location = new System.Drawing.Point(686, 344);
            this.buttonStudentUpdatePassword.Name = "buttonStudentUpdatePassword";
            this.buttonStudentUpdatePassword.Size = new System.Drawing.Size(155, 39);
            this.buttonStudentUpdatePassword.TabIndex = 10;
            this.buttonStudentUpdatePassword.Text = "Update Password";
            this.buttonStudentUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonStudentUpdatePassword.Click += new System.EventHandler(this.buttonStudentUpdatePassword_Click);
            // 
            // labelStudentProfilePhoneValue
            // 
            this.labelStudentProfilePhoneValue.AutoSize = true;
            this.labelStudentProfilePhoneValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentProfilePhoneValue.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentProfilePhoneValue.Location = new System.Drawing.Point(187, 239);
            this.labelStudentProfilePhoneValue.Name = "labelStudentProfilePhoneValue";
            this.labelStudentProfilePhoneValue.Size = new System.Drawing.Size(2, 31);
            this.labelStudentProfilePhoneValue.TabIndex = 25;
            // 
            // labelStudentProfileAddressValue
            // 
            this.labelStudentProfileAddressValue.AutoSize = true;
            this.labelStudentProfileAddressValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentProfileAddressValue.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentProfileAddressValue.Location = new System.Drawing.Point(118, 297);
            this.labelStudentProfileAddressValue.Name = "labelStudentProfileAddressValue";
            this.labelStudentProfileAddressValue.Size = new System.Drawing.Size(2, 28);
            this.labelStudentProfileAddressValue.TabIndex = 24;
            this.labelStudentProfileAddressValue.Click += new System.EventHandler(this.labelStudentProfileAddress1Value_Click);
            // 
            // labelStudentProfileLevelValue
            // 
            this.labelStudentProfileLevelValue.AutoSize = true;
            this.labelStudentProfileLevelValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentProfileLevelValue.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentProfileLevelValue.Location = new System.Drawing.Point(93, 350);
            this.labelStudentProfileLevelValue.Name = "labelStudentProfileLevelValue";
            this.labelStudentProfileLevelValue.Size = new System.Drawing.Size(2, 31);
            this.labelStudentProfileLevelValue.TabIndex = 22;
            // 
            // labelStudentProfileMonthValue
            // 
            this.labelStudentProfileMonthValue.AutoSize = true;
            this.labelStudentProfileMonthValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentProfileMonthValue.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentProfileMonthValue.Location = new System.Drawing.Point(222, 406);
            this.labelStudentProfileMonthValue.Name = "labelStudentProfileMonthValue";
            this.labelStudentProfileMonthValue.Size = new System.Drawing.Size(2, 31);
            this.labelStudentProfileMonthValue.TabIndex = 21;
            // 
            // labelStudentProfileEmailValue
            // 
            this.labelStudentProfileEmailValue.AutoSize = true;
            this.labelStudentProfileEmailValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentProfileEmailValue.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentProfileEmailValue.Location = new System.Drawing.Point(102, 177);
            this.labelStudentProfileEmailValue.Name = "labelStudentProfileEmailValue";
            this.labelStudentProfileEmailValue.Size = new System.Drawing.Size(2, 31);
            this.labelStudentProfileEmailValue.TabIndex = 19;
            // 
            // labelStudentProfileICValue
            // 
            this.labelStudentProfileICValue.AutoSize = true;
            this.labelStudentProfileICValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentProfileICValue.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentProfileICValue.Location = new System.Drawing.Point(146, 114);
            this.labelStudentProfileICValue.Name = "labelStudentProfileICValue";
            this.labelStudentProfileICValue.Size = new System.Drawing.Size(2, 31);
            this.labelStudentProfileICValue.TabIndex = 18;
            this.labelStudentProfileICValue.Click += new System.EventHandler(this.label7_Click);
            // 
            // FormStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormStudentProfile";
            this.Text = "FormStudentProfile";
            this.Load += new System.EventHandler(this.FormStudentProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonStudentUpdateProfile;
        private Button buttonStudentProfileBack;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label label1;
        private Label labelMonthofEnrollment;
        private Label labelStudentProfileNameValue;
        private GroupBox groupBox1;
        private Label labelStudentProfilePhoneValue;
        private Label labelStudentProfileAddressValue;
        private Label labelStudentProfileLevelValue;
        private Label labelStudentProfileMonthValue;
        private Label labelStudentProfileEmailValue;
        private Label labelStudentProfileICValue;
        private Button buttonStudentUpdatePassword;
        private ListBox listBoxSubject;
        private Label labelStudentIDValue;
        private Label labelStudentID;
    }
}