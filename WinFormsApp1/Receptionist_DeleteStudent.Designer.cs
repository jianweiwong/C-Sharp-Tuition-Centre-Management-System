namespace WinFormsApp1
{
    partial class Receptionist_DeleteStudent
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
            this.lblReceptionistDeleteStudent_Username = new System.Windows.Forms.Label();
            this.cmbReceptionistDeleteStudent_StudentID = new System.Windows.Forms.ComboBox();
            this.btnReceptionistDeleteStudent_Find = new System.Windows.Forms.Button();
            this.lblReceptionistDeleteStudent_StudentIDLabel = new System.Windows.Forms.Label();
            this.lblReceptionistDeleteStudent_UsernameLabel = new System.Windows.Forms.Label();
            this.btnReceptionistDeleteStudent_Refresh = new System.Windows.Forms.Button();
            this.lblReceptionistDeleteStudent_LevelColumn = new System.Windows.Forms.Label();
            this.lblReceptionistDeleteStudent_UsernameColumn = new System.Windows.Forms.Label();
            this.lblReceptionistDeleteStudent_StudentIDColumn = new System.Windows.Forms.Label();
            this.lstReceptionistDeleteStudent_Level = new System.Windows.Forms.ListBox();
            this.lstReceptionistDeleteStudent_Username = new System.Windows.Forms.ListBox();
            this.lstReceptionistDeleteStudent_StudentID = new System.Windows.Forms.ListBox();
            this.btnReceptionistDeleteStudent_Cancel = new System.Windows.Forms.Button();
            this.btnReceptionistDeleteStudent_DeleteStudent = new System.Windows.Forms.Button();
            this.lblReceptionistDeleteStudent_PageDescription = new System.Windows.Forms.Label();
            this.lblReceptionistDeleteStudent_CurrentEnrolledStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReceptionistDeleteStudent_Username
            // 
            this.lblReceptionistDeleteStudent_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceptionistDeleteStudent_Username.Location = new System.Drawing.Point(152, 481);
            this.lblReceptionistDeleteStudent_Username.Name = "lblReceptionistDeleteStudent_Username";
            this.lblReceptionistDeleteStudent_Username.Size = new System.Drawing.Size(213, 28);
            this.lblReceptionistDeleteStudent_Username.TabIndex = 121;
            // 
            // cmbReceptionistDeleteStudent_StudentID
            // 
            this.cmbReceptionistDeleteStudent_StudentID.AutoCompleteCustomSource.AddRange(new string[] {
            "F1_Melayu",
            "F2_Melayu",
            "F3_Melayu",
            "F4_Melayu",
            "F5_Melayu",
            "F1_English",
            "F2_English",
            "F3_English",
            "F4_English",
            "F5_English",
            "F1_Chinese",
            "F2_Chinese",
            "F3_Chinese",
            "F4_Chinese",
            "F5_Chinese",
            "F1_Maths",
            "F2_Maths",
            "F3_Maths",
            "F4_Maths",
            "F5_Maths",
            "F1_Science",
            "F2_Science",
            "F3_Science",
            "F4_Science",
            "F5_Science"});
            this.cmbReceptionistDeleteStudent_StudentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbReceptionistDeleteStudent_StudentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReceptionistDeleteStudent_StudentID.FormattingEnabled = true;
            this.cmbReceptionistDeleteStudent_StudentID.Items.AddRange(new object[] {
            "F1_Melayu",
            "F2_Melayu",
            "F3_Melayu",
            "F4_Melayu",
            "F5_Melayu",
            "F1_English",
            "F2_English",
            "F3_English",
            "F4_English",
            "F5_English",
            "F1_Chinese",
            "F2_Chinese",
            "F3_Chinese",
            "F4_Chinese",
            "F5_Chinese",
            "F1_Maths",
            "F2_Maths",
            "F3_Maths",
            "F4_Maths",
            "F5_Maths",
            "F1_Science",
            "F2_Science",
            "F3_Science",
            "F4_Science",
            "F5_Science"});
            this.cmbReceptionistDeleteStudent_StudentID.Location = new System.Drawing.Point(152, 437);
            this.cmbReceptionistDeleteStudent_StudentID.Name = "cmbReceptionistDeleteStudent_StudentID";
            this.cmbReceptionistDeleteStudent_StudentID.Size = new System.Drawing.Size(213, 28);
            this.cmbReceptionistDeleteStudent_StudentID.TabIndex = 120;
            // 
            // btnReceptionistDeleteStudent_Find
            // 
            this.btnReceptionistDeleteStudent_Find.Location = new System.Drawing.Point(371, 437);
            this.btnReceptionistDeleteStudent_Find.Name = "btnReceptionistDeleteStudent_Find";
            this.btnReceptionistDeleteStudent_Find.Size = new System.Drawing.Size(72, 29);
            this.btnReceptionistDeleteStudent_Find.TabIndex = 119;
            this.btnReceptionistDeleteStudent_Find.Text = "Show";
            this.btnReceptionistDeleteStudent_Find.UseVisualStyleBackColor = true;
            this.btnReceptionistDeleteStudent_Find.Click += new System.EventHandler(this.btnReceptionistDeleteStudent_Find_Click);
            // 
            // lblReceptionistDeleteStudent_StudentIDLabel
            // 
            this.lblReceptionistDeleteStudent_StudentIDLabel.AutoSize = true;
            this.lblReceptionistDeleteStudent_StudentIDLabel.Location = new System.Drawing.Point(52, 440);
            this.lblReceptionistDeleteStudent_StudentIDLabel.Name = "lblReceptionistDeleteStudent_StudentIDLabel";
            this.lblReceptionistDeleteStudent_StudentIDLabel.Size = new System.Drawing.Size(78, 20);
            this.lblReceptionistDeleteStudent_StudentIDLabel.TabIndex = 118;
            this.lblReceptionistDeleteStudent_StudentIDLabel.Text = "StudentID:";
            // 
            // lblReceptionistDeleteStudent_UsernameLabel
            // 
            this.lblReceptionistDeleteStudent_UsernameLabel.AutoSize = true;
            this.lblReceptionistDeleteStudent_UsernameLabel.Location = new System.Drawing.Point(51, 483);
            this.lblReceptionistDeleteStudent_UsernameLabel.Name = "lblReceptionistDeleteStudent_UsernameLabel";
            this.lblReceptionistDeleteStudent_UsernameLabel.Size = new System.Drawing.Size(78, 20);
            this.lblReceptionistDeleteStudent_UsernameLabel.TabIndex = 117;
            this.lblReceptionistDeleteStudent_UsernameLabel.Text = "Username:";
            // 
            // btnReceptionistDeleteStudent_Refresh
            // 
            this.btnReceptionistDeleteStudent_Refresh.Location = new System.Drawing.Point(402, 52);
            this.btnReceptionistDeleteStudent_Refresh.Name = "btnReceptionistDeleteStudent_Refresh";
            this.btnReceptionistDeleteStudent_Refresh.Size = new System.Drawing.Size(94, 29);
            this.btnReceptionistDeleteStudent_Refresh.TabIndex = 116;
            this.btnReceptionistDeleteStudent_Refresh.Text = "Refresh";
            this.btnReceptionistDeleteStudent_Refresh.UseVisualStyleBackColor = true;
            this.btnReceptionistDeleteStudent_Refresh.Click += new System.EventHandler(this.btnReceptionistDeleteStudent_Refresh_Click);
            // 
            // lblReceptionistDeleteStudent_LevelColumn
            // 
            this.lblReceptionistDeleteStudent_LevelColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceptionistDeleteStudent_LevelColumn.Location = new System.Drawing.Point(442, 84);
            this.lblReceptionistDeleteStudent_LevelColumn.Name = "lblReceptionistDeleteStudent_LevelColumn";
            this.lblReceptionistDeleteStudent_LevelColumn.Size = new System.Drawing.Size(53, 24);
            this.lblReceptionistDeleteStudent_LevelColumn.TabIndex = 115;
            this.lblReceptionistDeleteStudent_LevelColumn.Text = "Level";
            // 
            // lblReceptionistDeleteStudent_UsernameColumn
            // 
            this.lblReceptionistDeleteStudent_UsernameColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceptionistDeleteStudent_UsernameColumn.Location = new System.Drawing.Point(96, 84);
            this.lblReceptionistDeleteStudent_UsernameColumn.Name = "lblReceptionistDeleteStudent_UsernameColumn";
            this.lblReceptionistDeleteStudent_UsernameColumn.Size = new System.Drawing.Size(347, 24);
            this.lblReceptionistDeleteStudent_UsernameColumn.TabIndex = 114;
            this.lblReceptionistDeleteStudent_UsernameColumn.Text = "Username";
            // 
            // lblReceptionistDeleteStudent_StudentIDColumn
            // 
            this.lblReceptionistDeleteStudent_StudentIDColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceptionistDeleteStudent_StudentIDColumn.Location = new System.Drawing.Point(20, 84);
            this.lblReceptionistDeleteStudent_StudentIDColumn.Name = "lblReceptionistDeleteStudent_StudentIDColumn";
            this.lblReceptionistDeleteStudent_StudentIDColumn.Size = new System.Drawing.Size(77, 24);
            this.lblReceptionistDeleteStudent_StudentIDColumn.TabIndex = 113;
            this.lblReceptionistDeleteStudent_StudentIDColumn.Text = "StudentID";
            // 
            // lstReceptionistDeleteStudent_Level
            // 
            this.lstReceptionistDeleteStudent_Level.FormattingEnabled = true;
            this.lstReceptionistDeleteStudent_Level.ItemHeight = 20;
            this.lstReceptionistDeleteStudent_Level.Location = new System.Drawing.Point(442, 84);
            this.lstReceptionistDeleteStudent_Level.Name = "lstReceptionistDeleteStudent_Level";
            this.lstReceptionistDeleteStudent_Level.Size = new System.Drawing.Size(53, 324);
            this.lstReceptionistDeleteStudent_Level.TabIndex = 112;
            // 
            // lstReceptionistDeleteStudent_Username
            // 
            this.lstReceptionistDeleteStudent_Username.FormattingEnabled = true;
            this.lstReceptionistDeleteStudent_Username.ItemHeight = 20;
            this.lstReceptionistDeleteStudent_Username.Location = new System.Drawing.Point(96, 84);
            this.lstReceptionistDeleteStudent_Username.Name = "lstReceptionistDeleteStudent_Username";
            this.lstReceptionistDeleteStudent_Username.Size = new System.Drawing.Size(347, 324);
            this.lstReceptionistDeleteStudent_Username.TabIndex = 111;
            // 
            // lstReceptionistDeleteStudent_StudentID
            // 
            this.lstReceptionistDeleteStudent_StudentID.FormattingEnabled = true;
            this.lstReceptionistDeleteStudent_StudentID.ItemHeight = 20;
            this.lstReceptionistDeleteStudent_StudentID.Location = new System.Drawing.Point(20, 84);
            this.lstReceptionistDeleteStudent_StudentID.Name = "lstReceptionistDeleteStudent_StudentID";
            this.lstReceptionistDeleteStudent_StudentID.Size = new System.Drawing.Size(77, 324);
            this.lstReceptionistDeleteStudent_StudentID.TabIndex = 110;
            // 
            // btnReceptionistDeleteStudent_Cancel
            // 
            this.btnReceptionistDeleteStudent_Cancel.Location = new System.Drawing.Point(210, 570);
            this.btnReceptionistDeleteStudent_Cancel.Name = "btnReceptionistDeleteStudent_Cancel";
            this.btnReceptionistDeleteStudent_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btnReceptionistDeleteStudent_Cancel.TabIndex = 109;
            this.btnReceptionistDeleteStudent_Cancel.Text = "Cancel";
            this.btnReceptionistDeleteStudent_Cancel.UseVisualStyleBackColor = true;
            this.btnReceptionistDeleteStudent_Cancel.Click += new System.EventHandler(this.btnReceptionistDeleteStudent_Cancel_Click);
            // 
            // btnReceptionistDeleteStudent_DeleteStudent
            // 
            this.btnReceptionistDeleteStudent_DeleteStudent.Location = new System.Drawing.Point(187, 534);
            this.btnReceptionistDeleteStudent_DeleteStudent.Name = "btnReceptionistDeleteStudent_DeleteStudent";
            this.btnReceptionistDeleteStudent_DeleteStudent.Size = new System.Drawing.Size(137, 29);
            this.btnReceptionistDeleteStudent_DeleteStudent.TabIndex = 108;
            this.btnReceptionistDeleteStudent_DeleteStudent.Text = "Delete Student";
            this.btnReceptionistDeleteStudent_DeleteStudent.UseVisualStyleBackColor = true;
            this.btnReceptionistDeleteStudent_DeleteStudent.Click += new System.EventHandler(this.btnReceptionistDeleteStudent_DeleteStudent_Click);
            // 
            // lblReceptionistDeleteStudent_PageDescription
            // 
            this.lblReceptionistDeleteStudent_PageDescription.AutoSize = true;
            this.lblReceptionistDeleteStudent_PageDescription.Location = new System.Drawing.Point(87, 9);
            this.lblReceptionistDeleteStudent_PageDescription.Name = "lblReceptionistDeleteStudent_PageDescription";
            this.lblReceptionistDeleteStudent_PageDescription.Size = new System.Drawing.Size(336, 20);
            this.lblReceptionistDeleteStudent_PageDescription.TabIndex = 122;
            this.lblReceptionistDeleteStudent_PageDescription.Text = "Delete student who have completed their studies.";
            // 
            // lblReceptionistDeleteStudent_CurrentEnrolledStudent
            // 
            this.lblReceptionistDeleteStudent_CurrentEnrolledStudent.AutoSize = true;
            this.lblReceptionistDeleteStudent_CurrentEnrolledStudent.Location = new System.Drawing.Point(20, 61);
            this.lblReceptionistDeleteStudent_CurrentEnrolledStudent.Name = "lblReceptionistDeleteStudent_CurrentEnrolledStudent";
            this.lblReceptionistDeleteStudent_CurrentEnrolledStudent.Size = new System.Drawing.Size(177, 20);
            this.lblReceptionistDeleteStudent_CurrentEnrolledStudent.TabIndex = 123;
            this.lblReceptionistDeleteStudent_CurrentEnrolledStudent.Text = "Current Enrolled Students";
            // 
            // Receptionist_DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 609);
            this.Controls.Add(this.lblReceptionistDeleteStudent_CurrentEnrolledStudent);
            this.Controls.Add(this.lblReceptionistDeleteStudent_PageDescription);
            this.Controls.Add(this.lblReceptionistDeleteStudent_Username);
            this.Controls.Add(this.cmbReceptionistDeleteStudent_StudentID);
            this.Controls.Add(this.btnReceptionistDeleteStudent_Find);
            this.Controls.Add(this.lblReceptionistDeleteStudent_StudentIDLabel);
            this.Controls.Add(this.lblReceptionistDeleteStudent_UsernameLabel);
            this.Controls.Add(this.btnReceptionistDeleteStudent_Refresh);
            this.Controls.Add(this.lblReceptionistDeleteStudent_LevelColumn);
            this.Controls.Add(this.lblReceptionistDeleteStudent_UsernameColumn);
            this.Controls.Add(this.lblReceptionistDeleteStudent_StudentIDColumn);
            this.Controls.Add(this.lstReceptionistDeleteStudent_Level);
            this.Controls.Add(this.lstReceptionistDeleteStudent_Username);
            this.Controls.Add(this.lstReceptionistDeleteStudent_StudentID);
            this.Controls.Add(this.btnReceptionistDeleteStudent_Cancel);
            this.Controls.Add(this.btnReceptionistDeleteStudent_DeleteStudent);
            this.Name = "Receptionist_DeleteStudent";
            this.Text = "Receptionist_DeleteStudent";
            this.Load += new System.EventHandler(this.Receptionist_DeleteStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblReceptionistDeleteStudent_Username;
        private ComboBox cmbReceptionistDeleteStudent_StudentID;
        private Button btnReceptionistDeleteStudent_Find;
        private Label lblReceptionistDeleteStudent_StudentIDLabel;
        private Label lblReceptionistDeleteStudent_UsernameLabel;
        private Button btnReceptionistDeleteStudent_Refresh;
        private Label lblReceptionistDeleteStudent_LevelColumn;
        private Label lblReceptionistDeleteStudent_UsernameColumn;
        private Label lblReceptionistDeleteStudent_StudentIDColumn;
        private ListBox lstReceptionistDeleteStudent_Level;
        private ListBox lstReceptionistDeleteStudent_Username;
        private ListBox lstReceptionistDeleteStudent_StudentID;
        private Button btnReceptionistDeleteStudent_Cancel;
        private Button btnReceptionistDeleteStudent_DeleteStudent;
        private Label lblReceptionistDeleteStudent_PageDescription;
        private Label lblReceptionistDeleteStudent_CurrentEnrolledStudent;
    }
}