namespace Training_Center
{
    partial class frmMain
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
            this.TrainingStrip = new System.Windows.Forms.MenuStrip();
            this.StudentToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CoursestoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EnrollmentstoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.UserstoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingstoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainingStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainingStrip
            // 
            this.TrainingStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentToolstrip,
            this.CoursestoolStrip,
            this.EnrollmentstoolStrip,
            this.UserstoolStrip,
            this.toolStripPayments,
            this.SettingstoolStrip});
            this.TrainingStrip.Location = new System.Drawing.Point(0, 0);
            this.TrainingStrip.Name = "TrainingStrip";
            this.TrainingStrip.Size = new System.Drawing.Size(1003, 72);
            this.TrainingStrip.TabIndex = 1;
            this.TrainingStrip.Text = "TrainingStrip";
            // 
            // StudentToolstrip
            // 
            this.StudentToolstrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentToolstrip.Image = global::Training_Center.Properties.Resources.People_64;
            this.StudentToolstrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StudentToolstrip.Name = "StudentToolstrip";
            this.StudentToolstrip.Size = new System.Drawing.Size(153, 68);
            this.StudentToolstrip.Text = "Students";
            this.StudentToolstrip.Click += new System.EventHandler(this.StudentToolstrip_Click);
            // 
            // CoursestoolStrip
            // 
            this.CoursestoolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursestoolStrip.Image = global::Training_Center.Properties.Resources.Test_Type_64;
            this.CoursestoolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CoursestoolStrip.Name = "CoursestoolStrip";
            this.CoursestoolStrip.Size = new System.Drawing.Size(145, 68);
            this.CoursestoolStrip.Text = "Courses";
            this.CoursestoolStrip.Click += new System.EventHandler(this.CoursestoolStrip_Click);
            // 
            // EnrollmentstoolStrip
            // 
            this.EnrollmentstoolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentstoolStrip.Image = global::Training_Center.Properties.Resources.Add_New_User_72;
            this.EnrollmentstoolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EnrollmentstoolStrip.Name = "EnrollmentstoolStrip";
            this.EnrollmentstoolStrip.Size = new System.Drawing.Size(291, 68);
            this.EnrollmentstoolStrip.Text = "Enrollments (Registration) ";
            this.EnrollmentstoolStrip.Click += new System.EventHandler(this.EnrollmentstoolStrip_Click);
            // 
            // UserstoolStrip
            // 
            this.UserstoolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserstoolStrip.Image = global::Training_Center.Properties.Resources.users_64;
            this.UserstoolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UserstoolStrip.Name = "UserstoolStrip";
            this.UserstoolStrip.Size = new System.Drawing.Size(127, 68);
            this.UserstoolStrip.Text = "Users";
            // 
            // SettingstoolStrip
            // 
            this.SettingstoolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingstoolStrip.Image = global::Training_Center.Properties.Resources.account_settings_64;
            this.SettingstoolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingstoolStrip.Name = "SettingstoolStrip";
            this.SettingstoolStrip.Size = new System.Drawing.Size(148, 68);
            this.SettingstoolStrip.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Training_Center.Properties.Resources.online_banking_black_icon_bundle_for_secure_digital_finance_payment_and_account_management_vector;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1003, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripPayments
            // 
            this.toolStripPayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPayments.Image = global::Training_Center.Properties.Resources.money_32;
            this.toolStripPayments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPayments.Name = "toolStripPayments";
            this.toolStripPayments.Size = new System.Drawing.Size(129, 68);
            this.toolStripPayments.Text = "Payments";
            this.toolStripPayments.Click += new System.EventHandler(this.toolStripPayments_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TrainingStrip);
            this.Name = "frmMain";
            this.Text = "FrmMain";
            this.TrainingStrip.ResumeLayout(false);
            this.TrainingStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TrainingStrip;
        private System.Windows.Forms.ToolStripMenuItem StudentToolstrip;
        private System.Windows.Forms.ToolStripMenuItem CoursestoolStrip;
        private System.Windows.Forms.ToolStripMenuItem EnrollmentstoolStrip;
        private System.Windows.Forms.ToolStripMenuItem UserstoolStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingstoolStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripPayments;
    }
}

