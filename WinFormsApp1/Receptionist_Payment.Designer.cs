namespace WinFormsApp1
{
    partial class Receptionist_Payment
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
            this.lblReceptionistPayment_StudentIDLabel = new System.Windows.Forms.Label();
            this.lblReceptionistPayment_PageDescription = new System.Windows.Forms.Label();
            this.txtReceptionistPayment_AmountPaid = new System.Windows.Forms.TextBox();
            this.lblReceptionistPayment_AmountPaidLabel = new System.Windows.Forms.Label();
            this.lblReceptionistPayment_MonthLabel = new System.Windows.Forms.Label();
            this.lblReceptionistPayment_NameLabel = new System.Windows.Forms.Label();
            this.btnReceptionistPayment_Cancel = new System.Windows.Forms.Button();
            this.btnReceptionistPayment_GenerateReceipt = new System.Windows.Forms.Button();
            this.lblReceptionistPayment_ViewDate = new System.Windows.Forms.Label();
            this.lblReceptionistPayment_DateLabel = new System.Windows.Forms.Label();
            this.cmbReceptionistPayment_Name = new System.Windows.Forms.ComboBox();
            this.btnReceptionistPayment_Find = new System.Windows.Forms.Button();
            this.lblReceptionistPayment_Month = new System.Windows.Forms.Label();
            this.lblReceptionistPayment_ShowStudentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReceptionistPayment_StudentIDLabel
            // 
            this.lblReceptionistPayment_StudentIDLabel.AutoSize = true;
            this.lblReceptionistPayment_StudentIDLabel.Location = new System.Drawing.Point(89, 141);
            this.lblReceptionistPayment_StudentIDLabel.Name = "lblReceptionistPayment_StudentIDLabel";
            this.lblReceptionistPayment_StudentIDLabel.Size = new System.Drawing.Size(78, 20);
            this.lblReceptionistPayment_StudentIDLabel.TabIndex = 56;
            this.lblReceptionistPayment_StudentIDLabel.Text = "StudentID:";
            this.lblReceptionistPayment_StudentIDLabel.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblReceptionistPayment_PageDescription
            // 
            this.lblReceptionistPayment_PageDescription.AutoSize = true;
            this.lblReceptionistPayment_PageDescription.Location = new System.Drawing.Point(89, 30);
            this.lblReceptionistPayment_PageDescription.Name = "lblReceptionistPayment_PageDescription";
            this.lblReceptionistPayment_PageDescription.Size = new System.Drawing.Size(357, 20);
            this.lblReceptionistPayment_PageDescription.TabIndex = 55;
            this.lblReceptionistPayment_PageDescription.Text = "Accept payment from students and generate receipt.";
            this.lblReceptionistPayment_PageDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtReceptionistPayment_AmountPaid
            // 
            this.txtReceptionistPayment_AmountPaid.Location = new System.Drawing.Point(186, 290);
            this.txtReceptionistPayment_AmountPaid.Name = "txtReceptionistPayment_AmountPaid";
            this.txtReceptionistPayment_AmountPaid.Size = new System.Drawing.Size(262, 27);
            this.txtReceptionistPayment_AmountPaid.TabIndex = 66;
            this.txtReceptionistPayment_AmountPaid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblReceptionistPayment_AmountPaidLabel
            // 
            this.lblReceptionistPayment_AmountPaidLabel.AutoSize = true;
            this.lblReceptionistPayment_AmountPaidLabel.Location = new System.Drawing.Point(24, 290);
            this.lblReceptionistPayment_AmountPaidLabel.Name = "lblReceptionistPayment_AmountPaidLabel";
            this.lblReceptionistPayment_AmountPaidLabel.Size = new System.Drawing.Size(135, 20);
            this.lblReceptionistPayment_AmountPaidLabel.TabIndex = 65;
            this.lblReceptionistPayment_AmountPaidLabel.Text = "Amount paid (RM):";
            this.lblReceptionistPayment_AmountPaidLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblReceptionistPayment_MonthLabel
            // 
            this.lblReceptionistPayment_MonthLabel.AutoSize = true;
            this.lblReceptionistPayment_MonthLabel.Location = new System.Drawing.Point(104, 237);
            this.lblReceptionistPayment_MonthLabel.Name = "lblReceptionistPayment_MonthLabel";
            this.lblReceptionistPayment_MonthLabel.Size = new System.Drawing.Size(55, 20);
            this.lblReceptionistPayment_MonthLabel.TabIndex = 68;
            this.lblReceptionistPayment_MonthLabel.Text = "Month:";
            this.lblReceptionistPayment_MonthLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblReceptionistPayment_NameLabel
            // 
            this.lblReceptionistPayment_NameLabel.AutoSize = true;
            this.lblReceptionistPayment_NameLabel.Location = new System.Drawing.Point(115, 91);
            this.lblReceptionistPayment_NameLabel.Name = "lblReceptionistPayment_NameLabel";
            this.lblReceptionistPayment_NameLabel.Size = new System.Drawing.Size(52, 20);
            this.lblReceptionistPayment_NameLabel.TabIndex = 71;
            this.lblReceptionistPayment_NameLabel.Text = "Name:";
            // 
            // btnReceptionistPayment_Cancel
            // 
            this.btnReceptionistPayment_Cancel.Location = new System.Drawing.Point(223, 399);
            this.btnReceptionistPayment_Cancel.Name = "btnReceptionistPayment_Cancel";
            this.btnReceptionistPayment_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btnReceptionistPayment_Cancel.TabIndex = 74;
            this.btnReceptionistPayment_Cancel.Text = "Cancel";
            this.btnReceptionistPayment_Cancel.UseVisualStyleBackColor = true;
            this.btnReceptionistPayment_Cancel.Click += new System.EventHandler(this.btnReceptionistPayment_Cancel_Click);
            // 
            // btnReceptionistPayment_GenerateReceipt
            // 
            this.btnReceptionistPayment_GenerateReceipt.Location = new System.Drawing.Point(201, 356);
            this.btnReceptionistPayment_GenerateReceipt.Name = "btnReceptionistPayment_GenerateReceipt";
            this.btnReceptionistPayment_GenerateReceipt.Size = new System.Drawing.Size(137, 29);
            this.btnReceptionistPayment_GenerateReceipt.TabIndex = 73;
            this.btnReceptionistPayment_GenerateReceipt.Text = "Generate Receipt";
            this.btnReceptionistPayment_GenerateReceipt.UseVisualStyleBackColor = true;
            this.btnReceptionistPayment_GenerateReceipt.Click += new System.EventHandler(this.btnReceptionistPayment_GenerateReceipt_Click);
            // 
            // lblReceptionistPayment_ViewDate
            // 
            this.lblReceptionistPayment_ViewDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceptionistPayment_ViewDate.Location = new System.Drawing.Point(186, 189);
            this.lblReceptionistPayment_ViewDate.Name = "lblReceptionistPayment_ViewDate";
            this.lblReceptionistPayment_ViewDate.Size = new System.Drawing.Size(262, 28);
            this.lblReceptionistPayment_ViewDate.TabIndex = 77;
            // 
            // lblReceptionistPayment_DateLabel
            // 
            this.lblReceptionistPayment_DateLabel.AutoSize = true;
            this.lblReceptionistPayment_DateLabel.Location = new System.Drawing.Point(115, 191);
            this.lblReceptionistPayment_DateLabel.Name = "lblReceptionistPayment_DateLabel";
            this.lblReceptionistPayment_DateLabel.Size = new System.Drawing.Size(44, 20);
            this.lblReceptionistPayment_DateLabel.TabIndex = 76;
            this.lblReceptionistPayment_DateLabel.Text = "Date:";
            // 
            // cmbReceptionistPayment_Name
            // 
            this.cmbReceptionistPayment_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbReceptionistPayment_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReceptionistPayment_Name.FormattingEnabled = true;
            this.cmbReceptionistPayment_Name.Location = new System.Drawing.Point(186, 90);
            this.cmbReceptionistPayment_Name.Name = "cmbReceptionistPayment_Name";
            this.cmbReceptionistPayment_Name.Size = new System.Drawing.Size(262, 28);
            this.cmbReceptionistPayment_Name.TabIndex = 78;
            this.cmbReceptionistPayment_Name.SelectedIndexChanged += new System.EventHandler(this.cmbReceptionistPayment_Name_SelectedIndexChanged);
            // 
            // btnReceptionistPayment_Find
            // 
            this.btnReceptionistPayment_Find.Location = new System.Drawing.Point(454, 138);
            this.btnReceptionistPayment_Find.Name = "btnReceptionistPayment_Find";
            this.btnReceptionistPayment_Find.Size = new System.Drawing.Size(57, 29);
            this.btnReceptionistPayment_Find.TabIndex = 75;
            this.btnReceptionistPayment_Find.Text = "Show";
            this.btnReceptionistPayment_Find.UseVisualStyleBackColor = true;
            this.btnReceptionistPayment_Find.Click += new System.EventHandler(this.btnReceptionistPayment_Find_Click);
            // 
            // lblReceptionistPayment_Month
            // 
            this.lblReceptionistPayment_Month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceptionistPayment_Month.Location = new System.Drawing.Point(186, 236);
            this.lblReceptionistPayment_Month.Name = "lblReceptionistPayment_Month";
            this.lblReceptionistPayment_Month.Size = new System.Drawing.Size(262, 28);
            this.lblReceptionistPayment_Month.TabIndex = 81;
            // 
            // lblReceptionistPayment_ShowStudentID
            // 
            this.lblReceptionistPayment_ShowStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceptionistPayment_ShowStudentID.Location = new System.Drawing.Point(186, 139);
            this.lblReceptionistPayment_ShowStudentID.Name = "lblReceptionistPayment_ShowStudentID";
            this.lblReceptionistPayment_ShowStudentID.Size = new System.Drawing.Size(262, 28);
            this.lblReceptionistPayment_ShowStudentID.TabIndex = 77;
            // 
            // Receptionist_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.lblReceptionistPayment_Month);
            this.Controls.Add(this.cmbReceptionistPayment_Name);
            this.Controls.Add(this.lblReceptionistPayment_ShowStudentID);
            this.Controls.Add(this.lblReceptionistPayment_ViewDate);
            this.Controls.Add(this.lblReceptionistPayment_DateLabel);
            this.Controls.Add(this.btnReceptionistPayment_Find);
            this.Controls.Add(this.btnReceptionistPayment_Cancel);
            this.Controls.Add(this.btnReceptionistPayment_GenerateReceipt);
            this.Controls.Add(this.lblReceptionistPayment_NameLabel);
            this.Controls.Add(this.lblReceptionistPayment_MonthLabel);
            this.Controls.Add(this.txtReceptionistPayment_AmountPaid);
            this.Controls.Add(this.lblReceptionistPayment_AmountPaidLabel);
            this.Controls.Add(this.lblReceptionistPayment_StudentIDLabel);
            this.Controls.Add(this.lblReceptionistPayment_PageDescription);
            this.Name = "Receptionist_Payment";
            this.Text = "Receptionist_Payment";
            this.Load += new System.EventHandler(this.Receptionist_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblReceptionistPayment_StudentIDLabel;
        private Label lblReceptionistPayment_PageDescription;
        private TextBox txtReceptionistPayment_AmountPaid;
        private Label lblReceptionistPayment_AmountPaidLabel;
        private Label lblReceptionistPayment_MonthLabel;
        private Label lblReceptionistPayment_NameLabel;
        private Button btnReceptionistPayment_Cancel;
        private Button btnReceptionistPayment_GenerateReceipt;
        private Label lblReceptionistPayment_ViewDate;
        private Label lblReceptionistPayment_DateLabel;
        private ComboBox cmbReceptionistPayment_Name;
        private Label lblReceptionistPayment_StudentID;
        private Label lblReceptionistPayment_ShowStudentID;
        private Button btnReceptionistPayment_Find;
        private Label lblReceptionistPayment_Month;
        //private Label lblReceptionistPayment_StudentID;
    }
}