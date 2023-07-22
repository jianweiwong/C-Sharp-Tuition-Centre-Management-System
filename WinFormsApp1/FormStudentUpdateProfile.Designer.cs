namespace WinFormsApp1
{
    partial class FormStudentUpdateProfile
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
            this.buttonUpdateProfileBack = new System.Windows.Forms.Button();
            this.buttonUpdateProfileConfirm = new System.Windows.Forms.Button();
            this.groupBoxUpdateProfile = new System.Windows.Forms.GroupBox();
            this.textBoxStudentUpdateAddress = new System.Windows.Forms.TextBox();
            this.textBoxStudentUpdateContactNumber = new System.Windows.Forms.TextBox();
            this.textBoxStudentUpdateEmail = new System.Windows.Forms.TextBox();
            this.labelStudentICValue = new System.Windows.Forms.Label();
            this.labelStudentNameValue = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelIC = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.groupBoxUpdateProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdateProfileBack
            // 
            this.buttonUpdateProfileBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateProfileBack.Location = new System.Drawing.Point(719, 304);
            this.buttonUpdateProfileBack.Name = "buttonUpdateProfileBack";
            this.buttonUpdateProfileBack.Size = new System.Drawing.Size(155, 34);
            this.buttonUpdateProfileBack.TabIndex = 13;
            this.buttonUpdateProfileBack.Text = "Back";
            this.buttonUpdateProfileBack.UseVisualStyleBackColor = true;
            this.buttonUpdateProfileBack.Click += new System.EventHandler(this.buttonUpdateProfileBack_Click);
            // 
            // buttonUpdateProfileConfirm
            // 
            this.buttonUpdateProfileConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateProfileConfirm.Location = new System.Drawing.Point(719, 252);
            this.buttonUpdateProfileConfirm.Name = "buttonUpdateProfileConfirm";
            this.buttonUpdateProfileConfirm.Size = new System.Drawing.Size(155, 34);
            this.buttonUpdateProfileConfirm.TabIndex = 12;
            this.buttonUpdateProfileConfirm.Text = "Confirm Update";
            this.buttonUpdateProfileConfirm.UseVisualStyleBackColor = true;
            this.buttonUpdateProfileConfirm.Click += new System.EventHandler(this.buttonUpdateProfileConfirm_Click);
            // 
            // groupBoxUpdateProfile
            // 
            this.groupBoxUpdateProfile.Controls.Add(this.buttonUpdateProfileBack);
            this.groupBoxUpdateProfile.Controls.Add(this.textBoxStudentUpdateAddress);
            this.groupBoxUpdateProfile.Controls.Add(this.buttonUpdateProfileConfirm);
            this.groupBoxUpdateProfile.Controls.Add(this.textBoxStudentUpdateContactNumber);
            this.groupBoxUpdateProfile.Controls.Add(this.textBoxStudentUpdateEmail);
            this.groupBoxUpdateProfile.Controls.Add(this.labelStudentICValue);
            this.groupBoxUpdateProfile.Controls.Add(this.labelStudentNameValue);
            this.groupBoxUpdateProfile.Controls.Add(this.labelName);
            this.groupBoxUpdateProfile.Controls.Add(this.labelAddress);
            this.groupBoxUpdateProfile.Controls.Add(this.labelIC);
            this.groupBoxUpdateProfile.Controls.Add(this.labelEmail);
            this.groupBoxUpdateProfile.Controls.Add(this.labelContact);
            this.groupBoxUpdateProfile.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxUpdateProfile.Location = new System.Drawing.Point(37, 45);
            this.groupBoxUpdateProfile.Name = "groupBoxUpdateProfile";
            this.groupBoxUpdateProfile.Size = new System.Drawing.Size(903, 363);
            this.groupBoxUpdateProfile.TabIndex = 11;
            this.groupBoxUpdateProfile.TabStop = false;
            this.groupBoxUpdateProfile.Text = "Update Student Profile";
            this.groupBoxUpdateProfile.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxStudentUpdateAddress
            // 
            this.textBoxStudentUpdateAddress.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStudentUpdateAddress.Location = new System.Drawing.Point(120, 284);
            this.textBoxStudentUpdateAddress.Name = "textBoxStudentUpdateAddress";
            this.textBoxStudentUpdateAddress.Size = new System.Drawing.Size(569, 29);
            this.textBoxStudentUpdateAddress.TabIndex = 28;
            // 
            // textBoxStudentUpdateContactNumber
            // 
            this.textBoxStudentUpdateContactNumber.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStudentUpdateContactNumber.Location = new System.Drawing.Point(187, 214);
            this.textBoxStudentUpdateContactNumber.Name = "textBoxStudentUpdateContactNumber";
            this.textBoxStudentUpdateContactNumber.Size = new System.Drawing.Size(348, 29);
            this.textBoxStudentUpdateContactNumber.TabIndex = 27;
            // 
            // textBoxStudentUpdateEmail
            // 
            this.textBoxStudentUpdateEmail.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStudentUpdateEmail.Location = new System.Drawing.Point(93, 154);
            this.textBoxStudentUpdateEmail.Name = "textBoxStudentUpdateEmail";
            this.textBoxStudentUpdateEmail.Size = new System.Drawing.Size(359, 29);
            this.textBoxStudentUpdateEmail.TabIndex = 26;
            // 
            // labelStudentICValue
            // 
            this.labelStudentICValue.AutoSize = true;
            this.labelStudentICValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentICValue.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentICValue.Location = new System.Drawing.Point(146, 94);
            this.labelStudentICValue.Name = "labelStudentICValue";
            this.labelStudentICValue.Size = new System.Drawing.Size(2, 26);
            this.labelStudentICValue.TabIndex = 18;
            // 
            // labelStudentNameValue
            // 
            this.labelStudentNameValue.AutoSize = true;
            this.labelStudentNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentNameValue.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentNameValue.Location = new System.Drawing.Point(102, 36);
            this.labelStudentNameValue.Name = "labelStudentNameValue";
            this.labelStudentNameValue.Size = new System.Drawing.Size(2, 26);
            this.labelStudentNameValue.TabIndex = 17;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(25, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 27);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(25, 284);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(79, 27);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Address";
            // 
            // labelIC
            // 
            this.labelIC.AutoSize = true;
            this.labelIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIC.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIC.Location = new System.Drawing.Point(25, 97);
            this.labelIC.Name = "labelIC";
            this.labelIC.Size = new System.Drawing.Size(105, 27);
            this.labelIC.TabIndex = 2;
            this.labelIC.Text = "IC/Passport";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(25, 157);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 27);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelContact.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContact.Location = new System.Drawing.Point(25, 216);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(145, 27);
            this.labelContact.TabIndex = 4;
            this.labelContact.Text = "Contact Number";
            // 
            // FormStudentUpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 496);
            this.Controls.Add(this.groupBoxUpdateProfile);
            this.Name = "FormStudentUpdateProfile";
            this.Text = "Student Update Profile";
            this.Load += new System.EventHandler(this.FormStudentUpdateProfile_Load);
            this.groupBoxUpdateProfile.ResumeLayout(false);
            this.groupBoxUpdateProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonUpdateProfileBack;
        private Button buttonUpdateProfileConfirm;
        private GroupBox groupBoxUpdateProfile;
        private TextBox textBoxStudentUpdateContactNumber;
        private TextBox textBoxStudentUpdateEmail;
        private Label labelStudentICValue;
        private Label labelStudentNameValue;
        private Label labelName;
        private Label labelAddress;
        private Label labelIC;
        private Label labelEmail;
        private Label labelContact;
        private TextBox textBoxStudentUpdateAddress;
    }
}