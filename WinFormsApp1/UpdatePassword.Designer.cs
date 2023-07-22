namespace WinFormsApp1
{
    partial class UpdatePassword
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
            this.txtAdminConfNewPass = new System.Windows.Forms.TextBox();
            this.txtAdminewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminChgPassDone = new System.Windows.Forms.Button();
            this.btnAdminExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdminConfNewPass
            // 
            this.txtAdminConfNewPass.Location = new System.Drawing.Point(298, 229);
            this.txtAdminConfNewPass.Name = "txtAdminConfNewPass";
            this.txtAdminConfNewPass.Size = new System.Drawing.Size(302, 27);
            this.txtAdminConfNewPass.TabIndex = 19;
            // 
            // txtAdminewPass
            // 
            this.txtAdminewPass.Location = new System.Drawing.Point(211, 179);
            this.txtAdminewPass.Name = "txtAdminewPass";
            this.txtAdminewPass.Size = new System.Drawing.Size(302, 27);
            this.txtAdminewPass.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Confirm New Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "New Password :";
            // 
            // btnAdminChgPassDone
            // 
            this.btnAdminChgPassDone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminChgPassDone.Location = new System.Drawing.Point(119, 328);
            this.btnAdminChgPassDone.Name = "btnAdminChgPassDone";
            this.btnAdminChgPassDone.Size = new System.Drawing.Size(230, 50);
            this.btnAdminChgPassDone.TabIndex = 20;
            this.btnAdminChgPassDone.Text = "Done";
            this.btnAdminChgPassDone.UseVisualStyleBackColor = true;
            this.btnAdminChgPassDone.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdminExit
            // 
            this.btnAdminExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminExit.Location = new System.Drawing.Point(418, 328);
            this.btnAdminExit.Name = "btnAdminExit";
            this.btnAdminExit.Size = new System.Drawing.Size(230, 50);
            this.btnAdminExit.TabIndex = 21;
            this.btnAdminExit.Text = "Exit";
            this.btnAdminExit.UseVisualStyleBackColor = true;
            this.btnAdminExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "Password";
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdminExit);
            this.Controls.Add(this.btnAdminChgPassDone);
            this.Controls.Add(this.txtAdminConfNewPass);
            this.Controls.Add(this.txtAdminewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAdminConfNewPass;
        private TextBox txtAdminewPass;
        private Label label3;
        private Label label2;
        private Button btnAdminChgPassDone;
        private Button btnAdminExit;
        private Label label1;
    }
}