namespace Training_Center
{
    partial class FrmPaymentAddUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgEnrollment = new System.Windows.Forms.DataGridView();
            this.uscStudentFilter1 = new Training_Center.UscStudentFilter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPaymentID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.dpEnrollmetDate = new System.Windows.Forms.DateTimePicker();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonInfoNext = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnrollment)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(23, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPersonInfoNext);
            this.tabPage1.Controls.Add(this.dgEnrollment);
            this.tabPage1.Controls.Add(this.uscStudentFilter1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgEnrollment
            // 
            this.dgEnrollment.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEnrollment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEnrollment.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgEnrollment.Location = new System.Drawing.Point(23, 379);
            this.dgEnrollment.Name = "dgEnrollment";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEnrollment.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgEnrollment.Size = new System.Drawing.Size(775, 162);
            this.dgEnrollment.TabIndex = 1;
            // 
            // uscStudentFilter1
            // 
            this.uscStudentFilter1.Location = new System.Drawing.Point(23, 20);
            this.uscStudentFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.uscStudentFilter1.Name = "uscStudentFilter1";
            this.uscStudentFilter1.Size = new System.Drawing.Size(563, 318);
            this.uscStudentFilter1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbPaymentID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lbCourseName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbStudentID);
            this.tabPage2.Controls.Add(this.txtPaid);
            this.tabPage2.Controls.Add(this.dpEnrollmetDate);
            this.tabPage2.Controls.Add(this.cbPaymentMethod);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 236;
            this.label3.Text = "PaymentID :";
            // 
            // lbPaymentID
            // 
            this.lbPaymentID.AutoSize = true;
            this.lbPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentID.Location = new System.Drawing.Point(136, 33);
            this.lbPaymentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaymentID.Name = "lbPaymentID";
            this.lbPaymentID.Size = new System.Drawing.Size(53, 20);
            this.lbPaymentID.TabIndex = 237;
            this.lbPaymentID.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 234;
            this.label4.Text = "Course Name  :";
            // 
            // lbCourseName
            // 
            this.lbCourseName.AutoSize = true;
            this.lbCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseName.Location = new System.Drawing.Point(651, 97);
            this.lbCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(53, 20);
            this.lbCourseName.TabIndex = 235;
            this.lbCourseName.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 232;
            this.label2.Text = "Student Name :";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(646, 58);
            this.lbStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(53, 20);
            this.lbStudentID.TabIndex = 233;
            this.lbStudentID.Text = "[????]";
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(214, 192);
            this.txtPaid.Multiline = true;
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(215, 26);
            this.txtPaid.TabIndex = 231;
            // 
            // dpEnrollmetDate
            // 
            this.dpEnrollmetDate.Location = new System.Drawing.Point(233, 144);
            this.dpEnrollmetDate.Name = "dpEnrollmetDate";
            this.dpEnrollmetDate.Size = new System.Drawing.Size(270, 24);
            this.dpEnrollmetDate.TabIndex = 230;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash ",
            " Visa ",
            "Transfer"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(171, 85);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(192, 26);
            this.cbPaymentMethod.TabIndex = 228;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(21, 87);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(153, 20);
            this.label22.TabIndex = 221;
            this.label22.Text = "Payment Method :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 223;
            this.label5.Text = "Amount OF Paid :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Training_Center.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(177, 192);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 225;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 224;
            this.label6.Text = "PaymentDate : ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Training_Center.Properties.Resources.Calendar_322;
            this.pictureBox5.Location = new System.Drawing.Point(187, 140);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 226;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Payment ";
            // 
            // btnPersonInfoNext
            // 
            this.btnPersonInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonInfoNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonInfoNext.Image = global::Training_Center.Properties.Resources.Next_64;
            this.btnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonInfoNext.Location = new System.Drawing.Point(963, 514);
            this.btnPersonInfoNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonInfoNext.Name = "btnPersonInfoNext";
            this.btnPersonInfoNext.Size = new System.Drawing.Size(126, 43);
            this.btnPersonInfoNext.TabIndex = 120;
            this.btnPersonInfoNext.Text = "Next         ";
            this.btnPersonInfoNext.UseVisualStyleBackColor = true;
            // 
            // FrmPaymentAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPaymentAddUpdate";
            this.Text = "FrmPaymentAddUpdate";
            this.Load += new System.EventHandler(this.FrmPaymentAddUpdate_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEnrollment)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private UscStudentFilter uscStudentFilter1;
        private System.Windows.Forms.DataGridView dgEnrollment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.DateTimePicker dpEnrollmetDate;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPaymentID;
        private System.Windows.Forms.Button btnPersonInfoNext;
    }
}