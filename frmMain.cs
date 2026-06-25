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
    public partial class frmMain : System.Windows.Forms.Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void StudentToolstrip_Click(object sender, EventArgs e)
        {
            Form frm = new FrmStudents();
            frm.ShowDialog();
        }

        private void CoursestoolStrip_Click(object sender, EventArgs e)
        {
            Form frm = new frmLIstOfcourses();
            frm.ShowDialog();
        }

        private void EnrollmentstoolStrip_Click(object sender, EventArgs e)
        {
            Form frm = new FrmEnrollmentMange();
            frm.ShowDialog();
        }

        private void toolStripPayments_Click(object sender, EventArgs e)
        {
            Form frm = new FrmPaymentLIst();
            frm.ShowDialog();
        }
    }
}
