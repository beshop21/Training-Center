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

        }
    }
}
