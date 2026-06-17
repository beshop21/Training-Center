using BusLayaer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_Center
{
    public partial class FrmPaymentAddUpdate : Form
    {

        enum EnMode { addnew=0,update=1}
        EnMode Mode = EnMode.addnew;

        private int _PaymentID = -1;
        ClsEnrollment Enrollmentinfo;


        


        public FrmPaymentAddUpdate()
        {
            InitializeComponent();
            Mode = EnMode.addnew;

        }
        public FrmPaymentAddUpdate(int id)
        {
            InitializeComponent();
            _PaymentID = id;
            Mode = EnMode.addnew;

        }


        private void _RestDefualt()
        {
            if (Mode == EnMode.addnew)
            {
                label1.Text = "Add New Payment";
            }
            else
                label1.Text = "Update Payment";

            cbPaymentMethod.SelectedIndex = 0;


        }


        


        private void FrmPaymentAddUpdate_Load(object sender, EventArgs e)
        {
            _RestDefualt();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (uscStudentFilter1.StudentID == -1)
            {
                MessageBox.Show("Please Select Student ");
                return;
            }
           dgEnrollment.DataSource = ClsEnrollment.FindStudentInfo(uscStudentFilter1.StudentID);
            tbPayments.SelectedTab= tbPayments.TabPages["tgAdd"];
             
        }
    }
}
