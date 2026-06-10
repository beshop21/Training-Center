namespace Training_Center
{
    partial class frmFindCourse
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
            this.uscCourseDetailsWithFilter1 = new Training_Center.UscCourseDetailsWithFilter();
            this.SuspendLayout();
            // 
            // uscCourseDetailsWithFilter1
            // 
            this.uscCourseDetailsWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.uscCourseDetailsWithFilter1.Name = "uscCourseDetailsWithFilter1";
            this.uscCourseDetailsWithFilter1.Size = new System.Drawing.Size(798, 373);
            this.uscCourseDetailsWithFilter1.TabIndex = 0;
            this.uscCourseDetailsWithFilter1.Load += new System.EventHandler(this.uscCourseDetailsWithFilter1_Load);
            // 
            // frmFindCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.uscCourseDetailsWithFilter1);
            this.Name = "frmFindCourse";
            this.Text = "frmFindCourse";
            this.ResumeLayout(false);

        }

        #endregion

        private UscCourseDetailsWithFilter uscCourseDetailsWithFilter1;
    }
}