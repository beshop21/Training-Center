namespace Training_Center
{
    partial class frmStudentDetails
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
            this.usStudentDetials1 = new Training_Center.UsStudentDetials();
            this.SuspendLayout();
            // 
            // usStudentDetials1
            // 
            this.usStudentDetials1.Location = new System.Drawing.Point(27, 53);
            this.usStudentDetials1.Name = "usStudentDetials1";
            this.usStudentDetials1.Size = new System.Drawing.Size(722, 271);
            this.usStudentDetials1.TabIndex = 0;
            // 
            // frmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usStudentDetials1);
            this.Name = "frmStudentDetails";
            this.Text = "frmStudentDetails";
            this.Load += new System.EventHandler(this.frmStudentDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UsStudentDetials usStudentDetials1;
    }
}