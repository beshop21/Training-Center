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
    public partial class FrmErollmentAddUpdate : Form
    {

        enum Enmode { addnew=0,update=1}
        Enmode Mode = Enmode.addnew;
        private int _Enrollmentid = -1;
        ClsEnrollment Enroollment;
        public FrmErollmentAddUpdate()
        {
            InitializeComponent();
            Mode = Enmode.addnew;

        }
        public FrmErollmentAddUpdate(int ID)
        {
            InitializeComponent();
            _Enrollmentid = ID;
            Mode = Enmode.update;

        }



        private void _RestDefuilt()
        {
            if (Mode == Enmode.addnew)
            {
                lblTitle.Text = "Add New Eronllemnt ";
                tgEdit.Enabled = false ;
                Enroollment = new ClsEnrollment();
                btnSave.Enabled = false;

            }
            else
            {
                lblTitle.Text = "Edit Eronllemnt ";
                tgEdit.Enabled = true ;

            }

            



        }



        private void FrmErollmentAddUpdate_Load(object sender, EventArgs e)
        {
            _RestDefuilt();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if(uscStudentFilter1.StudentID==-1 && uscCourseDetailsWithFilter1.CourseID == -1)
            {
                MessageBox.Show("Please Select StudentID and CourseName To Enrollment ");
                return;
            }


            tgEdit.Enabled = true;
            tabControl1.SelectedTab = tabControl1.TabPages["tgEdit"];
            btnSave.Enabled = true;
            lbStudentID.Text = uscStudentFilter1.StudentID.ToString();
            lbCourseName.Text = uscCourseDetailsWithFilter1.CourseName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Enroollment.IsStudentHasEnrollmentOnthisCourse(uscStudentFilter1.StudentID, uscCourseDetailsWithFilter1.CourseID)){

                MessageBox.Show("This Student Is Enrollment This Course Before ,please choice other One");
                return;
            }

            Enroollment.Status = cbStatus.SelectedItem.ToString();
            Enroollment.StudentID = uscStudentFilter1.StudentID;
            Enroollment.CourseID = uscCourseDetailsWithFilter1.CourseID;
            Enroollment.Grade = float.Parse(txtGrade.Text);
            Enroollment.EnrollmentDate = dpEnrollmetDate.Value;
            Enroollment.TotalFee = float.Parse(txtFee.Text);

            if (Enroollment.Save())
            {
                MessageBox.Show("This Enrollment is Save Succesfully");
                lbEnrollmentID.Text = Enroollment.ErollmentiD.ToString();
                return;
            }

            else
                MessageBox.Show("There is Error ,Please check");

        }
    }
}
