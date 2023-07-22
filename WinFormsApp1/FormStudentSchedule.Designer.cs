namespace WinFormsApp1
{
    partial class FormStudentSchedule
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
            this.buttonStudentScheduleBackMainMenu = new System.Windows.Forms.Button();
            this.labelStudentSelectCourse = new System.Windows.Forms.Label();
            this.listBoxSchedule = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonStudentScheduleBackMainMenu
            // 
            this.buttonStudentScheduleBackMainMenu.Location = new System.Drawing.Point(330, 366);
            this.buttonStudentScheduleBackMainMenu.Name = "buttonStudentScheduleBackMainMenu";
            this.buttonStudentScheduleBackMainMenu.Size = new System.Drawing.Size(109, 29);
            this.buttonStudentScheduleBackMainMenu.TabIndex = 6;
            this.buttonStudentScheduleBackMainMenu.Text = "Back";
            this.buttonStudentScheduleBackMainMenu.UseVisualStyleBackColor = true;
            this.buttonStudentScheduleBackMainMenu.Click += new System.EventHandler(this.buttonStudentScheduleBackMainMenu_Click);
            // 
            // labelStudentSelectCourse
            // 
            this.labelStudentSelectCourse.AutoSize = true;
            this.labelStudentSelectCourse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentSelectCourse.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStudentSelectCourse.Location = new System.Drawing.Point(330, 55);
            this.labelStudentSelectCourse.Name = "labelStudentSelectCourse";
            this.labelStudentSelectCourse.Size = new System.Drawing.Size(109, 33);
            this.labelStudentSelectCourse.TabIndex = 0;
            this.labelStudentSelectCourse.Text = "Schedule";
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.FormattingEnabled = true;
            this.listBoxSchedule.ItemHeight = 20;
            this.listBoxSchedule.Location = new System.Drawing.Point(52, 121);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.Size = new System.Drawing.Size(700, 204);
            this.listBoxSchedule.TabIndex = 7;
            this.listBoxSchedule.SelectedIndexChanged += new System.EventHandler(this.listBoxSchedule_SelectedIndexChanged);
            // 
            // FormStudentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 448);
            this.Controls.Add(this.listBoxSchedule);
            this.Controls.Add(this.buttonStudentScheduleBackMainMenu);
            this.Controls.Add(this.labelStudentSelectCourse);
            this.Name = "FormStudentSchedule";
            this.Text = "FormSchedule";
            this.Load += new System.EventHandler(this.FormStudentSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonStudentScheduleBackMainMenu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label labelStudentSelectCourse;
        private ListBox listBoxSchedule;
    }
}