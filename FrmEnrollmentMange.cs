using BusLayaer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_Center
{
    public partial class FrmEnrollmentMange : Form
    {

        private void _GetallEnrollment()
        {
            dgEnrollment.DataSource = ClsEnrollment.GetAll();
        }






        public FrmEnrollmentMange()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEnrollmentMange_Load(object sender, EventArgs e)
        {

            dgEnrollment.DataSource = ClsEnrollment.GetAll();

            if (dgEnrollment.Rows.Count > 0)
            {


                dgEnrollment.Columns[0].HeaderText = "Enrollment ID";
                dgEnrollment.Columns[0].Width = 124;

                dgEnrollment.Columns[1].HeaderText = "Status";
                dgEnrollment.Columns[1].Width = 120;
                dgEnrollment.Columns[2].HeaderText = "StudentID";
                dgEnrollment.Columns[2].Width = 100;
                dgEnrollment.Columns[3].HeaderText = "CourseID";
                dgEnrollment.Columns[3].Width = 100;
                dgEnrollment.Columns[4].HeaderText = "Grade";
                dgEnrollment.Columns[4].Width = 112;
                dgEnrollment.Columns[5].HeaderText = "Enrollment Date";
                dgEnrollment.Columns[5].Width = 200;
                dgEnrollment.Columns[6].HeaderText = "Total Fee";
                dgEnrollment.Columns[6].Width = 124;



            }



        }

        private void tlsUpdate_Click(object sender, EventArgs e)
        {
            Form frm = new FrmErollmentAddUpdate((int)dgEnrollment.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _GetallEnrollment();
        }
    }
}
