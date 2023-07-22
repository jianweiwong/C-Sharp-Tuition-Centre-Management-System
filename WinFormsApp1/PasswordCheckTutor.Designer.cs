namespace WinFormsApp1
{
    partial class PasswordCheckTutor
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
            this.btnPasswordCheckTutor_Identify = new System.Windows.Forms.Button();
            this.txtPasswordCheckTutor_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPasswordCheckTutor_Identify
            // 
            this.btnPasswordCheckTutor_Identify.Location = new System.Drawing.Point(349, 254);
            this.btnPasswordCheckTutor_Identify.Name = "btnPasswordCheckTutor_Identify";
            this.btnPasswordCheckTutor_Identify.Size = new System.Drawing.Size(94, 29);
            this.btnPasswordCheckTutor_Identify.TabIndex = 7;
            this.btnPasswordCheckTutor_Identify.Text = "Identify";
            this.btnPasswordCheckTutor_Identify.UseVisualStyleBackColor = true;
            this.btnPasswordCheckTutor_Identify.Click += new System.EventHandler(this.btnPasswordCheckTutor_Identify_Click);
            // 
            // txtPasswordCheckTutor_Password
            // 
            this.txtPasswordCheckTutor_Password.Location = new System.Drawing.Point(349, 178);
            this.txtPasswordCheckTutor_Password.Name = "txtPasswordCheckTutor_Password";
            this.txtPasswordCheckTutor_Password.PasswordChar = '*';
            this.txtPasswordCheckTutor_Password.Size = new System.Drawing.Size(125, 27);
            this.txtPasswordCheckTutor_Password.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please insert password to identify yourself";
            // 
            // PasswordCheckTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPasswordCheckTutor_Identify);
            this.Controls.Add(this.txtPasswordCheckTutor_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PasswordCheckTutor";
            this.Text = "PasswordCheckTutor";
            this.Load += new System.EventHandler(this.PasswordCheckTutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPasswordCheckTutor_Identify;
        private TextBox txtPasswordCheckTutor_Password;
        private Label label2;
        private Label label1;
    }
}