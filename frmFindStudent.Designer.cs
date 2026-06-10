namespace Training_Center
{
    partial class frmFindStudent
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
            this.uscStudentFilter1 = new Training_Center.UscStudentFilter();
            this.SuspendLayout();
            // 
            // uscStudentFilter1
            // 
            this.uscStudentFilter1.Location = new System.Drawing.Point(-13, 12);
            this.uscStudentFilter1.Name = "uscStudentFilter1";
            this.uscStudentFilter1.Size = new System.Drawing.Size(863, 365);
            this.uscStudentFilter1.TabIndex = 0;
            // 
            // frmFindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.uscStudentFilter1);
            this.Name = "frmFindStudent";
            this.Text = "frmFindStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private UscStudentFilter uscStudentFilter1;
    }
}