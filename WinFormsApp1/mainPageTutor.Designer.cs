namespace WinFormsApp1
{
    partial class mainPageTutor
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
            this.btnTutorRefresh = new System.Windows.Forms.Button();
            this.dgvTutorMainPage_ViewAllClassInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTutorUpdtDelClassInfo = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnTutorUpdtProfile = new System.Windows.Forms.Button();
            this.btnTutorViewStudentList = new System.Windows.Forms.Button();
            this.btnTutorAddClassInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorMainPage_ViewAllClassInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTutorRefresh
            // 
            this.btnTutorRefresh.Location = new System.Drawing.Point(580, 65);
            this.btnTutorRefresh.Name = "btnTutorRefresh";
            this.btnTutorRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnTutorRefresh.TabIndex = 18;
            this.btnTutorRefresh.Text = "Refresh";
            this.btnTutorRefresh.UseVisualStyleBackColor = true;
            this.btnTutorRefresh.Click += new System.EventHandler(this.btnTutorRefresh_Click);
            // 
            // dgvTutorMainPage_ViewAllClassInfo
            // 
            this.dgvTutorMainPage_ViewAllClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutorMainPage_ViewAllClassInfo.Location = new System.Drawing.Point(84, 100);
            this.dgvTutorMainPage_ViewAllClassInfo.Name = "dgvTutorMainPage_ViewAllClassInfo";
            this.dgvTutorMainPage_ViewAllClassInfo.RowHeadersWidth = 51;
            this.dgvTutorMainPage_ViewAllClassInfo.RowTemplate.Height = 29;
            this.dgvTutorMainPage_ViewAllClassInfo.Size = new System.Drawing.Size(590, 188);
            this.dgvTutorMainPage_ViewAllClassInfo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Current Exist Class";
            // 
            // btnTutorUpdtDelClassInfo
            // 
            this.btnTutorUpdtDelClassInfo.Location = new System.Drawing.Point(84, 354);
            this.btnTutorUpdtDelClassInfo.Name = "btnTutorUpdtDelClassInfo";
            this.btnTutorUpdtDelClassInfo.Size = new System.Drawing.Size(266, 51);
            this.btnTutorUpdtDelClassInfo.TabIndex = 15;
            this.btnTutorUpdtDelClassInfo.Text = "Update or Delete Class Information ";
            this.btnTutorUpdtDelClassInfo.UseVisualStyleBackColor = true;
            this.btnTutorUpdtDelClassInfo.Click += new System.EventHandler(this.btnTutorUpdtDelClassInfo_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(200, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 20);
            this.lblWelcome.TabIndex = 14;
            // 
            // btnTutorUpdtProfile
            // 
            this.btnTutorUpdtProfile.Location = new System.Drawing.Point(408, 354);
            this.btnTutorUpdtProfile.Name = "btnTutorUpdtProfile";
            this.btnTutorUpdtProfile.Size = new System.Drawing.Size(266, 51);
            this.btnTutorUpdtProfile.TabIndex = 13;
            this.btnTutorUpdtProfile.Text = "Update Own Profile";
            this.btnTutorUpdtProfile.UseVisualStyleBackColor = true;
            this.btnTutorUpdtProfile.Click += new System.EventHandler(this.btnTutorUpdtProfile_Click);
            // 
            // btnTutorViewStudentList
            // 
            this.btnTutorViewStudentList.Location = new System.Drawing.Point(408, 294);
            this.btnTutorViewStudentList.Name = "btnTutorViewStudentList";
            this.btnTutorViewStudentList.Size = new System.Drawing.Size(266, 48);
            this.btnTutorViewStudentList.TabIndex = 12;
            this.btnTutorViewStudentList.Text = "View Enrolled Student List";
            this.btnTutorViewStudentList.UseVisualStyleBackColor = true;
            this.btnTutorViewStudentList.Click += new System.EventHandler(this.btnTutorViewStudentList_Click);
            // 
            // btnTutorAddClassInfo
            // 
            this.btnTutorAddClassInfo.Location = new System.Drawing.Point(84, 294);
            this.btnTutorAddClassInfo.Name = "btnTutorAddClassInfo";
            this.btnTutorAddClassInfo.Size = new System.Drawing.Size(266, 48);
            this.btnTutorAddClassInfo.TabIndex = 11;
            this.btnTutorAddClassInfo.Text = "Add Class Information";
            this.btnTutorAddClassInfo.UseVisualStyleBackColor = true;
            this.btnTutorAddClassInfo.Click += new System.EventHandler(this.btnTutorAddClassInfo_Click);
            // 
            // mainPageTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTutorRefresh);
            this.Controls.Add(this.dgvTutorMainPage_ViewAllClassInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTutorUpdtDelClassInfo);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnTutorUpdtProfile);
            this.Controls.Add(this.btnTutorViewStudentList);
            this.Controls.Add(this.btnTutorAddClassInfo);
            this.Name = "mainPageTutor";
            this.Text = "mainPageTutor";
            this.Load += new System.EventHandler(this.mainPageTutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorMainPage_ViewAllClassInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTutorRefresh;
        private DataGridView dgvTutorMainPage_ViewAllClassInfo;
        private Label label1;
        private Button btnTutorUpdtDelClassInfo;
        private Label lblWelcome;
        private Button btnTutorUpdtProfile;
        private Button btnTutorViewStudentList;
        private Button btnTutorAddClassInfo;
    }
}