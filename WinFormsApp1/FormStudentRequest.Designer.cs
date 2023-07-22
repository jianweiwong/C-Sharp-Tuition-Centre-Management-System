namespace WinFormsApp1
{
    partial class FormStudentRequest
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
            this.labelStudentRequest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSelectSubjectConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChangeTo = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectSubject = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxDeleteRequestTable = new System.Windows.Forms.ListBox();
            this.listBoxDeleteRequest = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStudentDeleteRequestConfirm = new System.Windows.Forms.Button();
            this.buttonStudentRequestBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStudentRequest
            // 
            this.labelStudentRequest.AutoSize = true;
            this.labelStudentRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentRequest.Location = new System.Drawing.Point(464, 9);
            this.labelStudentRequest.Name = "labelStudentRequest";
            this.labelStudentRequest.Size = new System.Drawing.Size(156, 30);
            this.labelStudentRequest.TabIndex = 2;
            this.labelStudentRequest.Text = "Student Request";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSelectSubjectConfirm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxChangeTo);
            this.groupBox1.Controls.Add(this.comboBoxSelectSubject);
            this.groupBox1.Location = new System.Drawing.Point(29, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Subject";
            // 
            // buttonSelectSubjectConfirm
            // 
            this.buttonSelectSubjectConfirm.Location = new System.Drawing.Point(435, 118);
            this.buttonSelectSubjectConfirm.Name = "buttonSelectSubjectConfirm";
            this.buttonSelectSubjectConfirm.Size = new System.Drawing.Size(132, 29);
            this.buttonSelectSubjectConfirm.TabIndex = 4;
            this.buttonSelectSubjectConfirm.Text = "Confirm Request";
            this.buttonSelectSubjectConfirm.UseVisualStyleBackColor = true;
            this.buttonSelectSubjectConfirm.Click += new System.EventHandler(this.buttonSelectSubjectConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Subject";
            // 
            // comboBoxChangeTo
            // 
            this.comboBoxChangeTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxChangeTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxChangeTo.FormattingEnabled = true;
            this.comboBoxChangeTo.Location = new System.Drawing.Point(51, 167);
            this.comboBoxChangeTo.Name = "comboBoxChangeTo";
            this.comboBoxChangeTo.Size = new System.Drawing.Size(329, 28);
            this.comboBoxChangeTo.TabIndex = 1;
            // 
            // comboBoxSelectSubject
            // 
            this.comboBoxSelectSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSelectSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSelectSubject.FormattingEnabled = true;
            this.comboBoxSelectSubject.Location = new System.Drawing.Point(51, 61);
            this.comboBoxSelectSubject.Name = "comboBoxSelectSubject";
            this.comboBoxSelectSubject.Size = new System.Drawing.Size(329, 28);
            this.comboBoxSelectSubject.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxDeleteRequestTable);
            this.groupBox4.Controls.Add(this.listBoxDeleteRequest);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buttonStudentDeleteRequestConfirm);
            this.groupBox4.Location = new System.Drawing.Point(12, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(903, 230);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Request";
            // 
            // listBoxDeleteRequestTable
            // 
            this.listBoxDeleteRequestTable.FormattingEnabled = true;
            this.listBoxDeleteRequestTable.ItemHeight = 20;
            this.listBoxDeleteRequestTable.Location = new System.Drawing.Point(30, 35);
            this.listBoxDeleteRequestTable.Name = "listBoxDeleteRequestTable";
            this.listBoxDeleteRequestTable.Size = new System.Drawing.Size(629, 184);
            this.listBoxDeleteRequestTable.TabIndex = 11;
            // 
            // listBoxDeleteRequest
            // 
            this.listBoxDeleteRequest.FormattingEnabled = true;
            this.listBoxDeleteRequest.ItemHeight = 20;
            this.listBoxDeleteRequest.Location = new System.Drawing.Point(676, 55);
            this.listBoxDeleteRequest.Name = "listBoxDeleteRequest";
            this.listBoxDeleteRequest.Size = new System.Drawing.Size(208, 104);
            this.listBoxDeleteRequest.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Request ID To Delete: -";
            // 
            // buttonStudentDeleteRequestConfirm
            // 
            this.buttonStudentDeleteRequestConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStudentDeleteRequestConfirm.Location = new System.Drawing.Point(676, 180);
            this.buttonStudentDeleteRequestConfirm.Name = "buttonStudentDeleteRequestConfirm";
            this.buttonStudentDeleteRequestConfirm.Size = new System.Drawing.Size(156, 34);
            this.buttonStudentDeleteRequestConfirm.TabIndex = 8;
            this.buttonStudentDeleteRequestConfirm.Text = "Confirm Delete";
            this.buttonStudentDeleteRequestConfirm.UseVisualStyleBackColor = true;
            this.buttonStudentDeleteRequestConfirm.Click += new System.EventHandler(this.buttonStudentDeleteRequestConfirm_Click);
            // 
            // buttonStudentRequestBack
            // 
            this.buttonStudentRequestBack.Location = new System.Drawing.Point(935, 462);
            this.buttonStudentRequestBack.Name = "buttonStudentRequestBack";
            this.buttonStudentRequestBack.Size = new System.Drawing.Size(118, 34);
            this.buttonStudentRequestBack.TabIndex = 9;
            this.buttonStudentRequestBack.Text = "Back";
            this.buttonStudentRequestBack.UseVisualStyleBackColor = true;
            this.buttonStudentRequestBack.Click += new System.EventHandler(this.buttonStudentRequestBack_Click);
            // 
            // FormStudentRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 523);
            this.Controls.Add(this.buttonStudentRequestBack);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelStudentRequest);
            this.Name = "FormStudentRequest";
            this.Text = "Student Request";
            this.Load += new System.EventHandler(this.FormStudentRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelStudentRequest;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Button buttonStudentDeleteRequestConfirm;
        private Button buttonSelectSubjectConfirm;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxChangeTo;
        private ComboBox comboBoxSelectSubject;
        private Button buttonStudentRequestBack;
        private Label label3;
        private ListBox listBoxDeleteRequest;
        private ListBox listBoxDeleteRequestTable;
    }
}