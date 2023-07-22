namespace WinFormsApp1
{
    partial class updtAndDltClass
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
            this.dgvTutorUpdtDelClassInfo_ClassInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTutorUpdtDelClassInfo_Cancel = new System.Windows.Forms.Button();
            this.btnTutorUpdtDelClassInfo_Delete = new System.Windows.Forms.Button();
            this.btnTutorUpdtDelClassInfo_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorUpdtDelClassInfo_ClassInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTutorUpdtDelClassInfo_ClassInfo
            // 
            this.dgvTutorUpdtDelClassInfo_ClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutorUpdtDelClassInfo_ClassInfo.Location = new System.Drawing.Point(124, 85);
            this.dgvTutorUpdtDelClassInfo_ClassInfo.Name = "dgvTutorUpdtDelClassInfo_ClassInfo";
            this.dgvTutorUpdtDelClassInfo_ClassInfo.RowHeadersWidth = 51;
            this.dgvTutorUpdtDelClassInfo_ClassInfo.RowTemplate.Height = 29;
            this.dgvTutorUpdtDelClassInfo_ClassInfo.Size = new System.Drawing.Size(552, 214);
            this.dgvTutorUpdtDelClassInfo_ClassInfo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Class Information";
            // 
            // btnTutorUpdtDelClassInfo_Cancel
            // 
            this.btnTutorUpdtDelClassInfo_Cancel.Location = new System.Drawing.Point(510, 325);
            this.btnTutorUpdtDelClassInfo_Cancel.Name = "btnTutorUpdtDelClassInfo_Cancel";
            this.btnTutorUpdtDelClassInfo_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btnTutorUpdtDelClassInfo_Cancel.TabIndex = 8;
            this.btnTutorUpdtDelClassInfo_Cancel.Text = "Cancel";
            this.btnTutorUpdtDelClassInfo_Cancel.UseVisualStyleBackColor = true;
            this.btnTutorUpdtDelClassInfo_Cancel.Click += new System.EventHandler(this.btnTutorUpdtDelClassInfo_Cancel_Click);
            // 
            // btnTutorUpdtDelClassInfo_Delete
            // 
            this.btnTutorUpdtDelClassInfo_Delete.Location = new System.Drawing.Point(211, 377);
            this.btnTutorUpdtDelClassInfo_Delete.Name = "btnTutorUpdtDelClassInfo_Delete";
            this.btnTutorUpdtDelClassInfo_Delete.Size = new System.Drawing.Size(94, 29);
            this.btnTutorUpdtDelClassInfo_Delete.TabIndex = 7;
            this.btnTutorUpdtDelClassInfo_Delete.Text = "Delete";
            this.btnTutorUpdtDelClassInfo_Delete.UseVisualStyleBackColor = true;
            this.btnTutorUpdtDelClassInfo_Delete.Click += new System.EventHandler(this.btnTutorUpdtDelClassInfo_Delete_Click);
            // 
            // btnTutorUpdtDelClassInfo_Update
            // 
            this.btnTutorUpdtDelClassInfo_Update.Location = new System.Drawing.Point(211, 325);
            this.btnTutorUpdtDelClassInfo_Update.Name = "btnTutorUpdtDelClassInfo_Update";
            this.btnTutorUpdtDelClassInfo_Update.Size = new System.Drawing.Size(94, 29);
            this.btnTutorUpdtDelClassInfo_Update.TabIndex = 6;
            this.btnTutorUpdtDelClassInfo_Update.Text = "Update";
            this.btnTutorUpdtDelClassInfo_Update.UseVisualStyleBackColor = true;
            this.btnTutorUpdtDelClassInfo_Update.Click += new System.EventHandler(this.btnTutorUpdtDelClassInfo_Update_Click);
            // 
            // updtAndDltClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTutorUpdtDelClassInfo_ClassInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTutorUpdtDelClassInfo_Cancel);
            this.Controls.Add(this.btnTutorUpdtDelClassInfo_Delete);
            this.Controls.Add(this.btnTutorUpdtDelClassInfo_Update);
            this.Name = "updtAndDltClass";
            this.Text = "updtAndDltClass";
            this.Load += new System.EventHandler(this.updtAndDltClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorUpdtDelClassInfo_ClassInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvTutorUpdtDelClassInfo_ClassInfo;
        private Label label1;
        private Button btnTutorUpdtDelClassInfo_Cancel;
        private Button btnTutorUpdtDelClassInfo_Delete;
        private Button btnTutorUpdtDelClassInfo_Update;
    }
}