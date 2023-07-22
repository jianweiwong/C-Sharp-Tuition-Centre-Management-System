namespace WinFormsApp1
{
    partial class FormStudentMainMenu
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
            this.labelStudentMainMenu = new System.Windows.Forms.Label();
            this.buttonStudentSchedule = new System.Windows.Forms.Button();
            this.buttonStudentRequest = new System.Windows.Forms.Button();
            this.buttonStudentProfile = new System.Windows.Forms.Button();
            this.buttonStudentLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStudentMainMenu
            // 
            this.labelStudentMainMenu.AutoSize = true;
            this.labelStudentMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentMainMenu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelStudentMainMenu.Location = new System.Drawing.Point(238, 39);
            this.labelStudentMainMenu.Name = "labelStudentMainMenu";
            this.labelStudentMainMenu.Size = new System.Drawing.Size(2, 40);
            this.labelStudentMainMenu.TabIndex = 1;
            this.labelStudentMainMenu.Click += new System.EventHandler(this.labelStudentMainMenu_Click);
            // 
            // buttonStudentSchedule
            // 
            this.buttonStudentSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStudentSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentSchedule.Location = new System.Drawing.Point(176, 128);
            this.buttonStudentSchedule.Name = "buttonStudentSchedule";
            this.buttonStudentSchedule.Size = new System.Drawing.Size(141, 82);
            this.buttonStudentSchedule.TabIndex = 2;
            this.buttonStudentSchedule.Text = "Schedule";
            this.buttonStudentSchedule.UseVisualStyleBackColor = true;
            this.buttonStudentSchedule.Click += new System.EventHandler(this.buttonStudentSchedule_Click);
            // 
            // buttonStudentRequest
            // 
            this.buttonStudentRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentRequest.Location = new System.Drawing.Point(444, 128);
            this.buttonStudentRequest.Name = "buttonStudentRequest";
            this.buttonStudentRequest.Size = new System.Drawing.Size(141, 82);
            this.buttonStudentRequest.TabIndex = 3;
            this.buttonStudentRequest.Text = "Request";
            this.buttonStudentRequest.UseVisualStyleBackColor = true;
            this.buttonStudentRequest.Click += new System.EventHandler(this.buttonStudentRequest_Click);
            // 
            // buttonStudentProfile
            // 
            this.buttonStudentProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentProfile.Location = new System.Drawing.Point(176, 266);
            this.buttonStudentProfile.Name = "buttonStudentProfile";
            this.buttonStudentProfile.Size = new System.Drawing.Size(141, 82);
            this.buttonStudentProfile.TabIndex = 4;
            this.buttonStudentProfile.Text = "Profile";
            this.buttonStudentProfile.UseVisualStyleBackColor = true;
            this.buttonStudentProfile.Click += new System.EventHandler(this.buttonStudentProfile_Click);
            // 
            // buttonStudentLogOut
            // 
            this.buttonStudentLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentLogOut.Location = new System.Drawing.Point(444, 266);
            this.buttonStudentLogOut.Name = "buttonStudentLogOut";
            this.buttonStudentLogOut.Size = new System.Drawing.Size(141, 82);
            this.buttonStudentLogOut.TabIndex = 5;
            this.buttonStudentLogOut.Text = "Log Out";
            this.buttonStudentLogOut.UseVisualStyleBackColor = true;
            this.buttonStudentLogOut.Click += new System.EventHandler(this.buttonStudentLogOut_Click);
            // 
            // FormStudentMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 447);
            this.Controls.Add(this.buttonStudentSchedule);
            this.Controls.Add(this.buttonStudentLogOut);
            this.Controls.Add(this.labelStudentMainMenu);
            this.Controls.Add(this.buttonStudentRequest);
            this.Controls.Add(this.buttonStudentProfile);
            this.Name = "FormStudentMainMenu";
            this.Text = "Student Main Menu";
            this.Load += new System.EventHandler(this.FormStudentMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelStudentMainMenu;
        private Button buttonStudentSchedule;
        private Button buttonStudentRequest;
        private Button buttonStudentProfile;
        private Button buttonStudentLogOut;
    }
}