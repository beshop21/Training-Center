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
    }
}
