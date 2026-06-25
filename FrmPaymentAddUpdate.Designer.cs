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
            this.tbPayments = new System.Windows.Forms.TabControl();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.uscStudentFilter1 = new Training_Center.UscStudentFilter();
            this.tgAdd = new System.Windows.Forms.TabPage();
            this.dgEnrollment = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPaymentID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.dpEnrollmetDate = new System.Windows.Forms.DateTimePicker();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.tbPayments.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.tgAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnrollment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPayments
            // 
            this.tbPayments.Controls.Add(this.tpSearch);
            this.tbPayments.Controls.Add(this.tgAdd);
            this.tbPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPayments.Location = new System.Drawing.Point(23, 49);
            this.tbPayments.Name = "tbPayments";
            this.tbPayments.SelectedIndex = 0;
            this.tbPayments.Size = new System.Drawing.Size(1127, 564);
            this.tbPayments.TabIndex = 0;
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.btnNext);
            this.tpSearch.Controls.Add(this.uscStudentFilter1);
            this.tpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpSearch.Location = new System.Drawing.Point(4, 27);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(1119, 533);
            this.tpSearch.TabIndex = 0;
            this.tpSearch.Text = "Search";
            this.tpSearch.UseVisualStyleBackColor = true;
            this.tpSearch.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::Training_Center.Properties.Resources.Next_64;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(955, 453);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 43);
            this.btnNext.TabIndex = 120;
            this.btnNext.Text = "Next         ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // uscStudentFilter1
            // 
            this.uscStudentFilter1.Location = new System.Drawing.Point(64, 46);
            this.uscStudentFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.uscStudentFilter1.Name = "uscStudentFilter1";
            this.uscStudentFilter1.Size = new System.Drawing.Size(692, 318);
            this.uscStudentFilter1.TabIndex = 0;
            // 
            // tgAdd
            // 
            this.tgAdd.Controls.Add(this.dgEnrollment);
            this.tgAdd.Controls.Add(this.label3);
            this.tgAdd.Controls.Add(this.lbPaymentID);
            this.tgAdd.Controls.Add(this.label4);
            this.tgAdd.Controls.Add(this.lbCourseName);
            this.tgAdd.Controls.Add(this.label2);
            this.tgAdd.Controls.Add(this.lbStudentName);
            this.tgAdd.Controls.Add(this.txtPaid);
            this.tgAdd.Controls.Add(this.dpEnrollmetDate);
            this.tgAdd.Controls.Add(this.cbPaymentMethod);
            this.tgAdd.Controls.Add(this.label22);
            this.tgAdd.Controls.Add(this.label5);
            this.tgAdd.Controls.Add(this.pictureBox4);
            this.tgAdd.Controls.Add(this.label6);
            this.tgAdd.Controls.Add(this.pictureBox5);
            this.tgAdd.Location = new System.Drawing.Point(4, 27);
            this.tgAdd.Name = "tgAdd";
            this.tgAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tgAdd.Size = new System.Drawing.Size(1119, 533);
            this.tgAdd.TabIndex = 1;
            this.tgAdd.Text = "add";
            this.tgAdd.UseVisualStyleBackColor = true;
            // 
            // dgEnrollment
            // 
            this.dgEnrollment.BackgroundColor = System.Drawing.Color.White;
            this.dgEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEnrollment.Location = new System.Drawing.Point(6, 283);
            this.dgEnrollment.Name = "dgEnrollment";
            this.dgEnrollment.Size = new System.Drawing.Size(775, 162);
            this.dgEnrollment.TabIndex = 238;
            this.dgEnrollment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.Location = new System.Drawing.Point(646, 58);
            this.lbStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(53, 20);
            this.lbStudentName.TabIndex = 233;
            this.lbStudentName.Text = "[????]";
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
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::Training_Center.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(912, 654);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 240;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Image = global::Training_Center.Properties.Resources.Save_32;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(1046, 654);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(126, 37);
            this.btnPay.TabIndex = 239;
            this.btnPay.Text = "Save";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // FrmPaymentAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 742);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPayments);
            this.Name = "FrmPaymentAddUpdate";
            this.Text = "FrmPaymentAddUpdate";
            this.Load += new System.EventHandler(this.FrmPaymentAddUpdate_Load);
            this.tbPayments.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.tgAdd.ResumeLayout(false);
            this.tgAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnrollment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbPayments;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tgAdd;
        private System.Windows.Forms.Label label1;
        private UscStudentFilter uscStudentFilter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStudentName;
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgEnrollment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPay;
    }
}