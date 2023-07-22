namespace WinFormsApp1
{
    partial class ViewEnrolledStudent
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
            this.LstTutorViewEnrolledStudentLevel = new System.Windows.Forms.ListBox();
            this.btnTutorBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LstTutorViewEnrolledStudentName = new System.Windows.Forms.ListBox();
            this.LstTutorViewEnrolledStudentSubject = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstTutorViewEnrolledStudentLevel
            // 
            this.LstTutorViewEnrolledStudentLevel.FormattingEnabled = true;
            this.LstTutorViewEnrolledStudentLevel.ItemHeight = 20;
            this.LstTutorViewEnrolledStudentLevel.Location = new System.Drawing.Point(288, 120);
            this.LstTutorViewEnrolledStudentLevel.Name = "LstTutorViewEnrolledStudentLevel";
            this.LstTutorViewEnrolledStudentLevel.Size = new System.Drawing.Size(206, 184);
            this.LstTutorViewEnrolledStudentLevel.TabIndex = 7;
            // 
            // btnTutorBack
            // 
            this.btnTutorBack.Location = new System.Drawing.Point(348, 352);
            this.btnTutorBack.Name = "btnTutorBack";
            this.btnTutorBack.Size = new System.Drawing.Size(94, 29);
            this.btnTutorBack.TabIndex = 6;
            this.btnTutorBack.Text = "Back";
            this.btnTutorBack.UseVisualStyleBackColor = true;
            this.btnTutorBack.Click += new System.EventHandler(this.btnTutorBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student List";
            // 
            // LstTutorViewEnrolledStudentName
            // 
            this.LstTutorViewEnrolledStudentName.FormattingEnabled = true;
            this.LstTutorViewEnrolledStudentName.ItemHeight = 20;
            this.LstTutorViewEnrolledStudentName.Location = new System.Drawing.Point(76, 120);
            this.LstTutorViewEnrolledStudentName.Name = "LstTutorViewEnrolledStudentName";
            this.LstTutorViewEnrolledStudentName.Size = new System.Drawing.Size(206, 184);
            this.LstTutorViewEnrolledStudentName.TabIndex = 4;
            // 
            // LstTutorViewEnrolledStudentSubject
            // 
            this.LstTutorViewEnrolledStudentSubject.FormattingEnabled = true;
            this.LstTutorViewEnrolledStudentSubject.ItemHeight = 20;
            this.LstTutorViewEnrolledStudentSubject.Location = new System.Drawing.Point(500, 120);
            this.LstTutorViewEnrolledStudentSubject.Name = "LstTutorViewEnrolledStudentSubject";
            this.LstTutorViewEnrolledStudentSubject.Size = new System.Drawing.Size(206, 184);
            this.LstTutorViewEnrolledStudentSubject.TabIndex = 8;
            this.LstTutorViewEnrolledStudentSubject.SelectedIndexChanged += new System.EventHandler(this.LstTutorViewEnrolledStudentSubject_SelectedIndexChanged);
            // 
            // ViewEnrolledStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstTutorViewEnrolledStudentSubject);
            this.Controls.Add(this.LstTutorViewEnrolledStudentLevel);
            this.Controls.Add(this.btnTutorBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstTutorViewEnrolledStudentName);
            this.Name = "ViewEnrolledStudent";
            this.Text = "ViewEnrolledStudent";
            this.Load += new System.EventHandler(this.ViewEnrolledStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LstTutorViewEnrolledStudentLevel;
        private Button btnTutorBack;
        private Label label1;
        private ListBox LstTutorViewEnrolledStudentName;
        private ListBox LstTutorViewEnrolledStudentSubject;
    }
}