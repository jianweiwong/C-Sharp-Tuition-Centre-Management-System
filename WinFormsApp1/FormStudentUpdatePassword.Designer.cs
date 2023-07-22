namespace WinFormsApp1
{
    partial class FormStudentUpdatePassword
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
            this.labelStudentPasswordUpdate = new System.Windows.Forms.Label();
            this.labelStudentOldPassword = new System.Windows.Forms.Label();
            this.textBoxStudentCurrentPassword = new System.Windows.Forms.TextBox();
            this.buttonStudentConfirmUpdatePassword = new System.Windows.Forms.Button();
            this.buttonStudentUpdatePasswordBack = new System.Windows.Forms.Button();
            this.textBoxStudentNewPassword = new System.Windows.Forms.TextBox();
            this.labelStudentNewPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStudentPasswordUpdate
            // 
            this.labelStudentPasswordUpdate.AutoSize = true;
            this.labelStudentPasswordUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentPasswordUpdate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentPasswordUpdate.Location = new System.Drawing.Point(281, 36);
            this.labelStudentPasswordUpdate.Name = "labelStudentPasswordUpdate";
            this.labelStudentPasswordUpdate.Size = new System.Drawing.Size(231, 40);
            this.labelStudentPasswordUpdate.TabIndex = 0;
            this.labelStudentPasswordUpdate.Text = "Update Password";
            // 
            // labelStudentOldPassword
            // 
            this.labelStudentOldPassword.AutoSize = true;
            this.labelStudentOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentOldPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentOldPassword.Location = new System.Drawing.Point(136, 145);
            this.labelStudentOldPassword.Name = "labelStudentOldPassword";
            this.labelStudentOldPassword.Size = new System.Drawing.Size(165, 30);
            this.labelStudentOldPassword.TabIndex = 2;
            this.labelStudentOldPassword.Text = "Current Password";
            this.labelStudentOldPassword.Click += new System.EventHandler(this.labelStudentOldPassword_Click);
            // 
            // textBoxStudentCurrentPassword
            // 
            this.textBoxStudentCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStudentCurrentPassword.Location = new System.Drawing.Point(332, 145);
            this.textBoxStudentCurrentPassword.Name = "textBoxStudentCurrentPassword";
            this.textBoxStudentCurrentPassword.PasswordChar = '#';
            this.textBoxStudentCurrentPassword.PlaceholderText = "12345abc";
            this.textBoxStudentCurrentPassword.Size = new System.Drawing.Size(300, 34);
            this.textBoxStudentCurrentPassword.TabIndex = 4;
            this.textBoxStudentCurrentPassword.TextChanged += new System.EventHandler(this.textBoxStudentOldPassword_TextChanged);
            // 
            // buttonStudentConfirmUpdatePassword
            // 
            this.buttonStudentConfirmUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentConfirmUpdatePassword.Location = new System.Drawing.Point(210, 317);
            this.buttonStudentConfirmUpdatePassword.Name = "buttonStudentConfirmUpdatePassword";
            this.buttonStudentConfirmUpdatePassword.Size = new System.Drawing.Size(152, 37);
            this.buttonStudentConfirmUpdatePassword.TabIndex = 5;
            this.buttonStudentConfirmUpdatePassword.Text = "Confirm Update";
            this.buttonStudentConfirmUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonStudentConfirmUpdatePassword.Click += new System.EventHandler(this.buttonStudentConfirmUpdatePassword_Click);
            // 
            // buttonStudentUpdatePasswordBack
            // 
            this.buttonStudentUpdatePasswordBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentUpdatePasswordBack.Location = new System.Drawing.Point(448, 317);
            this.buttonStudentUpdatePasswordBack.Name = "buttonStudentUpdatePasswordBack";
            this.buttonStudentUpdatePasswordBack.Size = new System.Drawing.Size(106, 37);
            this.buttonStudentUpdatePasswordBack.TabIndex = 6;
            this.buttonStudentUpdatePasswordBack.Text = "Back";
            this.buttonStudentUpdatePasswordBack.UseVisualStyleBackColor = true;
            this.buttonStudentUpdatePasswordBack.Click += new System.EventHandler(this.buttonStudentUpdatePasswordBack_Click);
            // 
            // textBoxStudentNewPassword
            // 
            this.textBoxStudentNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStudentNewPassword.Location = new System.Drawing.Point(332, 198);
            this.textBoxStudentNewPassword.Name = "textBoxStudentNewPassword";
            this.textBoxStudentNewPassword.PlaceholderText = "12345abc";
            this.textBoxStudentNewPassword.Size = new System.Drawing.Size(300, 34);
            this.textBoxStudentNewPassword.TabIndex = 9;
            // 
            // labelStudentNewPassword
            // 
            this.labelStudentNewPassword.AutoSize = true;
            this.labelStudentNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentNewPassword.Location = new System.Drawing.Point(162, 198);
            this.labelStudentNewPassword.Name = "labelStudentNewPassword";
            this.labelStudentNewPassword.Size = new System.Drawing.Size(139, 30);
            this.labelStudentNewPassword.TabIndex = 8;
            this.labelStudentNewPassword.Text = "New Password";
            // 
            // FormStudentUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxStudentNewPassword);
            this.Controls.Add(this.labelStudentNewPassword);
            this.Controls.Add(this.buttonStudentUpdatePasswordBack);
            this.Controls.Add(this.buttonStudentConfirmUpdatePassword);
            this.Controls.Add(this.textBoxStudentCurrentPassword);
            this.Controls.Add(this.labelStudentOldPassword);
            this.Controls.Add(this.labelStudentPasswordUpdate);
            this.Name = "FormStudentUpdatePassword";
            this.Text = "Student Login";
            this.Load += new System.EventHandler(this.FormStudentUpdatePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelStudentPasswordUpdate;
        private Label labelStudentOldPassword;
        private Button buttonStudentConfirmUpdatePassword;
        private Button buttonStudentUpdatePasswordBack;
        private TextBox textBoxStudentNewPassword;
        private Label labelStudentNewPassword;
        private TextBox textBoxStudentCurrentPassword;
    }
}