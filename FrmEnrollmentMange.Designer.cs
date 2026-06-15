namespace Training_Center
{
    partial class FrmEnrollmentMange
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgEnrollment = new System.Windows.Forms.DataGridView();
            this.CtmEnrollment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlEnrollmentInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStripAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnrollment)).BeginInit();
            this.CtmEnrollment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(306, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Enrollment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Training_Center.Properties.Resources.Schedule_Test_5121;
            this.pictureBox1.Location = new System.Drawing.Point(327, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgEnrollment
            // 
            this.dgEnrollment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEnrollment.ContextMenuStrip = this.CtmEnrollment;
            this.dgEnrollment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEnrollment.Location = new System.Drawing.Point(2, 216);
            this.dgEnrollment.Name = "dgEnrollment";
            this.dgEnrollment.Size = new System.Drawing.Size(1031, 336);
            this.dgEnrollment.TabIndex = 2;
            // 
            // CtmEnrollment
            // 
            this.CtmEnrollment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlEnrollmentInfo,
            this.toolStripSeparator1,
            this.tlsUpdate,
            this.tlStripAdd,
            this.tlsDelete});
            this.CtmEnrollment.Name = "contextMenuStrip1";
            this.CtmEnrollment.Size = new System.Drawing.Size(226, 216);
            // 
            // tlEnrollmentInfo
            // 
            this.tlEnrollmentInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlEnrollmentInfo.Image = global::Training_Center.Properties.Resources.PersonDetails_32;
            this.tlEnrollmentInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlEnrollmentInfo.Name = "tlEnrollmentInfo";
            this.tlEnrollmentInfo.Size = new System.Drawing.Size(225, 46);
            this.tlEnrollmentInfo.Text = "Enrollment Info";
            this.tlEnrollmentInfo.Click += new System.EventHandler(this.tlEnrollmentInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // tlsUpdate
            // 
            this.tlsUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsUpdate.Image = global::Training_Center.Properties.Resources.edit_32;
            this.tlsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsUpdate.Name = "tlsUpdate";
            this.tlsUpdate.Size = new System.Drawing.Size(225, 46);
            this.tlsUpdate.Text = "Update Enrollment";
            this.tlsUpdate.Click += new System.EventHandler(this.tlsUpdate_Click);
            // 
            // tlStripAdd
            // 
            this.tlStripAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlStripAdd.Image = global::Training_Center.Properties.Resources.Add_Person_40;
            this.tlStripAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlStripAdd.Name = "tlStripAdd";
            this.tlStripAdd.Size = new System.Drawing.Size(225, 46);
            this.tlStripAdd.Text = "Add Enrollment";
            this.tlStripAdd.Click += new System.EventHandler(this.tlStripAdd_Click);
            // 
            // tlsDelete
            // 
            this.tlsDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsDelete.Image = global::Training_Center.Properties.Resources.Delete_32_2;
            this.tlsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsDelete.Name = "tlsDelete";
            this.tlsDelete.Size = new System.Drawing.Size(225, 46);
            this.tlsDelete.Text = "Delete";
            this.tlsDelete.Click += new System.EventHandler(this.tlsDelete_Click);
            // 
            // FrmEnrollmentMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 564);
            this.Controls.Add(this.dgEnrollment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmEnrollmentMange";
            this.Text = "FrmEnrollmentMange";
            this.Load += new System.EventHandler(this.FrmEnrollmentMange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnrollment)).EndInit();
            this.CtmEnrollment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgEnrollment;
        private System.Windows.Forms.ContextMenuStrip CtmEnrollment;
        private System.Windows.Forms.ToolStripMenuItem tlEnrollmentInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tlsUpdate;
        private System.Windows.Forms.ToolStripMenuItem tlStripAdd;
        private System.Windows.Forms.ToolStripMenuItem tlsDelete;
    }
}