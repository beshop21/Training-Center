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
    public partial class frmLIstOfcourses : Form
    {


        private void _GetAllCourses()
        {
            dgCourses.DataSource = ClsCourses.Getall();
        }

        public frmLIstOfcourses()
        {
            InitializeComponent();
        }

        private void frmLIstOfcourses_Load(object sender, EventArgs e)
        {
            dgCourses.DataSource = ClsCourses.Getall();
           
            if (dgCourses.Rows.Count > 0)
            {

                dgCourses.Columns[0].HeaderText = "Course ID";
                dgCourses.Columns[0].Width = 110;

                dgCourses.Columns[1].HeaderText = "Title";
                dgCourses.Columns[1].Width = 145;
                dgCourses.Columns[2].HeaderText = "Hourse";
                dgCourses.Columns[2].Width = 135;

                dgCourses.Columns[3].HeaderText = "Price";
                dgCourses.Columns[3].Width = 135;

                dgCourses.Columns[4].HeaderText = "Start Date";
                dgCourses.Columns[4].Width = 125;

                dgCourses.Columns[5].HeaderText = "IsActive";
                dgCourses.Columns[5].Width = 134;

             






            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new FrmAddUpdateCoures((int)dgCourses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _GetAllCourses();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new FrmAddUpdateCoures();
            frm.ShowDialog();
            _GetAllCourses();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgCourses.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ClsCourses.Delete((int)dgCourses.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("the Course is Delete ");
                    _GetAllCourses();
                }
                else
                    MessageBox.Show("There is Error");
            }
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmCourseDetails((int)dgCourses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
