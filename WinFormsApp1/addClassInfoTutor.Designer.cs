namespace WinFormsApp1
{
    partial class addClassInfoTutor
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
            this.lblTutorAddClassInfo_TutorID = new System.Windows.Forms.Label();
            this.txtTutorAddClassInfo_Duration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTutorAddClassInfo_Day = new System.Windows.Forms.ComboBox();
            this.btnTutorAddClassInfo_Cancel = new System.Windows.Forms.Button();
            this.btnTutorAddClassInfo_Add = new System.Windows.Forms.Button();
            this.txtTutorAddClassInfo_Time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTutorAddClassInfo_TutorID
            // 
            this.lblTutorAddClassInfo_TutorID.AutoSize = true;
            this.lblTutorAddClassInfo_TutorID.Location = new System.Drawing.Point(208, 146);
            this.lblTutorAddClassInfo_TutorID.Name = "lblTutorAddClassInfo_TutorID";
            this.lblTutorAddClassInfo_TutorID.Size = new System.Drawing.Size(0, 20);
            this.lblTutorAddClassInfo_TutorID.TabIndex = 35;
            // 
            // txtTutorAddClassInfo_Duration
            // 
            this.txtTutorAddClassInfo_Duration.Location = new System.Drawing.Point(486, 188);
            this.txtTutorAddClassInfo_Duration.Name = "txtTutorAddClassInfo_Duration";
            this.txtTutorAddClassInfo_Duration.PlaceholderText = "1 Hour";
            this.txtTutorAddClassInfo_Duration.Size = new System.Drawing.Size(125, 27);
            this.txtTutorAddClassInfo_Duration.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "TutorID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Add Class Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Duration (h) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Time :";
            // 
            // cboTutorAddClassInfo_Day
            // 
            this.cboTutorAddClassInfo_Day.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTutorAddClassInfo_Day.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTutorAddClassInfo_Day.FormattingEnabled = true;
            this.cboTutorAddClassInfo_Day.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cboTutorAddClassInfo_Day.Location = new System.Drawing.Point(208, 239);
            this.cboTutorAddClassInfo_Day.Name = "cboTutorAddClassInfo_Day";
            this.cboTutorAddClassInfo_Day.Size = new System.Drawing.Size(151, 28);
            this.cboTutorAddClassInfo_Day.TabIndex = 29;
            // 
            // btnTutorAddClassInfo_Cancel
            // 
            this.btnTutorAddClassInfo_Cancel.Location = new System.Drawing.Point(407, 323);
            this.btnTutorAddClassInfo_Cancel.Name = "btnTutorAddClassInfo_Cancel";
            this.btnTutorAddClassInfo_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btnTutorAddClassInfo_Cancel.TabIndex = 28;
            this.btnTutorAddClassInfo_Cancel.Text = "Cancel";
            this.btnTutorAddClassInfo_Cancel.UseVisualStyleBackColor = true;
            this.btnTutorAddClassInfo_Cancel.Click += new System.EventHandler(this.btnTutorAddClassInfo_Cancel_Click);
            // 
            // btnTutorAddClassInfo_Add
            // 
            this.btnTutorAddClassInfo_Add.Location = new System.Drawing.Point(260, 323);
            this.btnTutorAddClassInfo_Add.Name = "btnTutorAddClassInfo_Add";
            this.btnTutorAddClassInfo_Add.Size = new System.Drawing.Size(94, 29);
            this.btnTutorAddClassInfo_Add.TabIndex = 27;
            this.btnTutorAddClassInfo_Add.Text = "Add";
            this.btnTutorAddClassInfo_Add.UseVisualStyleBackColor = true;
            this.btnTutorAddClassInfo_Add.Click += new System.EventHandler(this.btnTutorAddClassInfo_Add_Click);
            // 
            // txtTutorAddClassInfo_Time
            // 
            this.txtTutorAddClassInfo_Time.Location = new System.Drawing.Point(486, 140);
            this.txtTutorAddClassInfo_Time.Name = "txtTutorAddClassInfo_Time";
            this.txtTutorAddClassInfo_Time.PlaceholderText = "12 P.M.";
            this.txtTutorAddClassInfo_Time.Size = new System.Drawing.Size(125, 27);
            this.txtTutorAddClassInfo_Time.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Day :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Subject :";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxSubject.Location = new System.Drawing.Point(208, 192);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSubject.TabIndex = 36;
            // 
            // addClassInfoTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.lblTutorAddClassInfo_TutorID);
            this.Controls.Add(this.txtTutorAddClassInfo_Duration);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTutorAddClassInfo_Day);
            this.Controls.Add(this.btnTutorAddClassInfo_Cancel);
            this.Controls.Add(this.btnTutorAddClassInfo_Add);
            this.Controls.Add(this.txtTutorAddClassInfo_Time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "addClassInfoTutor";
            this.Text = "addClassInfoTutor";
            this.Load += new System.EventHandler(this.addClassInfoTutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTutorAddClassInfo_TutorID;
        private TextBox txtTutorAddClassInfo_Duration;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cboTutorAddClassInfo_Day;
        private Button btnTutorAddClassInfo_Cancel;
        private Button btnTutorAddClassInfo_Add;
        private TextBox txtTutorAddClassInfo_Time;
        private Label label5;
        private Label label3;
        private Label label1;
        private ComboBox comboBoxSubject;
    }
}