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
    public partial class FrmPaymentLIst : Form
    {
        ClsPayments payment;

        


        public FrmPaymentLIst()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPaymentLIst_Load(object sender, EventArgs e)
        {
            dgPayments.DataSource = ClsPayments.GetAll();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new FrmPaymentAddUpdate((int)dgPayments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete This Payment [" +dgPayments.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ClsPayments.Delete((int)dgPayments.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("This Enrollment is Delete Successfully ");
                    return;
                }
                else
                    MessageBox.Show("There is Problem");
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new FrmPaymentAddUpdate();
            frm.Show();
        }
    }
}
