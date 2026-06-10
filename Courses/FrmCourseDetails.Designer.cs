namespace Training_Center
{
    partial class FrmCourseDetails
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
            this.usCoursesInfo1 = new Training_Center.UsCoursesInfo();
            this.SuspendLayout();
            // 
            // usCoursesInfo1
            // 
            this.usCoursesInfo1.Location = new System.Drawing.Point(12, 110);
            this.usCoursesInfo1.Name = "usCoursesInfo1";
            this.usCoursesInfo1.Size = new System.Drawing.Size(754, 232);
            this.usCoursesInfo1.TabIndex = 0;
            // 
            // FrmCourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.usCoursesInfo1);
            this.Name = "FrmCourseDetails";
            this.Text = "FrmCourseDetails";
            this.Load += new System.EventHandler(this.FrmCourseDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UsCoursesInfo usCoursesInfo1;
    }
}