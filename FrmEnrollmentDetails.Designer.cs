namespace Training_Center
{
    partial class FrmEnrollmentDetails
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
            this.usEnrollmentDetails1 = new Training_Center.UsEnrollmentDetails();
            this.SuspendLayout();
            // 
            // usEnrollmentDetails1
            // 
            this.usEnrollmentDetails1.Location = new System.Drawing.Point(29, 94);
            this.usEnrollmentDetails1.Name = "usEnrollmentDetails1";
            this.usEnrollmentDetails1.Size = new System.Drawing.Size(732, 255);
            this.usEnrollmentDetails1.TabIndex = 0;
            // 
            // FrmEnrollmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usEnrollmentDetails1);
            this.Name = "FrmEnrollmentDetails";
            this.Text = "FrmEnrollmentDetails";
            this.Load += new System.EventHandler(this.FrmEnrollmentDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UsEnrollmentDetails usEnrollmentDetails1;
    }
}