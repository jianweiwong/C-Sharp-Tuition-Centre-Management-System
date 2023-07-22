namespace WinFormsApp1
{
    partial class AdminHomepage
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
            this.btnAdminOut = new System.Windows.Forms.Button();
            this.lblAdminHomepageWel = new System.Windows.Forms.Label();
            this.btnAdminViewTutors = new System.Windows.Forms.Button();
            this.btnAdminViewReceptionist = new System.Windows.Forms.Button();
            this.btnAdminViewProfile = new System.Windows.Forms.Button();
            this.btnAdminHomepageReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminOut
            // 
            this.btnAdminOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminOut.Location = new System.Drawing.Point(255, 305);
            this.btnAdminOut.Name = "btnAdminOut";
            this.btnAdminOut.Size = new System.Drawing.Size(250, 70);
            this.btnAdminOut.TabIndex = 11;
            this.btnAdminOut.Text = "Exit";
            this.btnAdminOut.UseVisualStyleBackColor = false;
            this.btnAdminOut.Click += new System.EventHandler(this.btnAdminOut_Click);
            // 
            // lblAdminHomepageWel
            // 
            this.lblAdminHomepageWel.AutoSize = true;
            this.lblAdminHomepageWel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminHomepageWel.Location = new System.Drawing.Point(114, 53);
            this.lblAdminHomepageWel.Name = "lblAdminHomepageWel";
            this.lblAdminHomepageWel.Size = new System.Drawing.Size(313, 54);
            this.lblAdminHomepageWel.TabIndex = 6;
            this.lblAdminHomepageWel.Text = "Welcome Admin";
            // 
            // btnAdminViewTutors
            // 
            this.btnAdminViewTutors.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminViewTutors.Location = new System.Drawing.Point(130, 229);
            this.btnAdminViewTutors.Name = "btnAdminViewTutors";
            this.btnAdminViewTutors.Size = new System.Drawing.Size(250, 70);
            this.btnAdminViewTutors.TabIndex = 12;
            this.btnAdminViewTutors.Text = "Tutor";
            this.btnAdminViewTutors.UseVisualStyleBackColor = true;
            this.btnAdminViewTutors.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdminViewReceptionist
            // 
            this.btnAdminViewReceptionist.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminViewReceptionist.Location = new System.Drawing.Point(395, 153);
            this.btnAdminViewReceptionist.Name = "btnAdminViewReceptionist";
            this.btnAdminViewReceptionist.Size = new System.Drawing.Size(250, 70);
            this.btnAdminViewReceptionist.TabIndex = 13;
            this.btnAdminViewReceptionist.Text = "Receptionist";
            this.btnAdminViewReceptionist.UseVisualStyleBackColor = true;
            this.btnAdminViewReceptionist.Click += new System.EventHandler(this.btnAdminViewReceptionist_Click);
            // 
            // btnAdminViewProfile
            // 
            this.btnAdminViewProfile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminViewProfile.Location = new System.Drawing.Point(395, 229);
            this.btnAdminViewProfile.Name = "btnAdminViewProfile";
            this.btnAdminViewProfile.Size = new System.Drawing.Size(250, 70);
            this.btnAdminViewProfile.TabIndex = 15;
            this.btnAdminViewProfile.Text = "View Profile";
            this.btnAdminViewProfile.UseVisualStyleBackColor = true;
            this.btnAdminViewProfile.Click += new System.EventHandler(this.btnAdminViewProfile_Click);
            // 
            // btnAdminHomepageReport
            // 
            this.btnAdminHomepageReport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminHomepageReport.Location = new System.Drawing.Point(130, 153);
            this.btnAdminHomepageReport.Name = "btnAdminHomepageReport";
            this.btnAdminHomepageReport.Size = new System.Drawing.Size(250, 70);
            this.btnAdminHomepageReport.TabIndex = 16;
            this.btnAdminHomepageReport.Text = "View Report";
            this.btnAdminHomepageReport.UseVisualStyleBackColor = true;
            this.btnAdminHomepageReport.Click += new System.EventHandler(this.btnAdminHomepageReport_Click);
            // 
            // AdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminHomepageReport);
            this.Controls.Add(this.btnAdminViewProfile);
            this.Controls.Add(this.btnAdminViewReceptionist);
            this.Controls.Add(this.btnAdminViewTutors);
            this.Controls.Add(this.btnAdminOut);
            this.Controls.Add(this.lblAdminHomepageWel);
            this.Name = "AdminHomepage";
            this.Text = "AdminHomepage";
            this.Load += new System.EventHandler(this.AdminHomepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdminOut;
        private Label lblAdminHomepageWel;
        private Button btnAdminViewTutors;
        private Button btnAdminViewReceptionist;
        private Button btnAdminViewProfile;
        private Button btnAdminHomepageReport;
    }
}