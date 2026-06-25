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
        ClsStudents student;
        ClsPayments Payment = new ClsPayments();
        private int _courseID = -1;

        DataTable tb = ClsEnrollment.GetAll();
        


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

        private void _LoadData()
        {

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
            student = ClsStudents.Find(uscStudentFilter1.StudentID);
            lbStudentName.Text = student.Fullname;
            foreach(DataRow row in tb.Rows)
            {
                 _courseID = Convert.ToInt32(row["CoursesID"]);
            }
            lbCourseName.Text = ClsCourses.Find(_courseID).Title;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Payment.StudentName = lbStudentName.Text;
            Payment.CourseName = lbCourseName.Text;
            Payment.PaymentDate = dpEnrollmetDate.Value;
            Payment.AmountPaid = float.Parse(txtPaid.Text);
            Payment.PaymentMethod = cbPaymentMethod.SelectedItem.ToString();
            if (Payment.Save())
            {
                MessageBox.Show("This Payment is Save ");
                lbPaymentID.Text = Payment.PaymentID.ToString();
                return;
            }

            else
                MessageBox.Show("There is Error Please check");
        }
    }
}
