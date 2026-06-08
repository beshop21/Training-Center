
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusLayaer;

namespace Training_Center
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }


     private void _GetallStud()
        {
            dgStudents.DataSource = ClsStudents.GetAll();
        }



        private void FrmStudents_Load(object sender, EventArgs e)
        {

            dgStudents.DataSource = ClsStudents.GetAll();
            lbRecode.Text = dgStudents.Rows.Count.ToString();
            if (dgStudents.Rows.Count > 0)
            {

                dgStudents.Columns[0].HeaderText = "Student ID";
                dgStudents.Columns[0].Width = 110;

                dgStudents.Columns[1].HeaderText = "FirstName";
                dgStudents.Columns[1].Width = 145;
                dgStudents.Columns[2].HeaderText = "SecondName";
                dgStudents.Columns[2].Width = 135;

                dgStudents.Columns[3].HeaderText = "ThirdName";
                dgStudents.Columns[3].Width = 135;

                dgStudents.Columns[4].HeaderText = "Phone";
                dgStudents.Columns[4].Width = 125;

                dgStudents.Columns[5].HeaderText = "Email";
                dgStudents.Columns[5].Width = 134;

                dgStudents.Columns[6].HeaderText = "Date Of Brith";
                dgStudents.Columns[6].Width = 135;

                dgStudents.Columns[7].HeaderText = "Created At";
                dgStudents.Columns[7].Width = 110;






            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new AddAndUpdateStudents((int)dgStudents.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _GetallStud();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmStudentDetails((int)dgStudents.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgStudents.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                if (ClsStudents.DeleteStudent((int)dgStudents.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("this student is Delete");
                    _GetallStud();
                }

                else
                {
                    MessageBox.Show("There is problem ");
                }



            }

            
            }
    }
}
