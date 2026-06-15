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
    public partial class UsEnrollmentDetails : UserControl
    {
        ClsEnrollment Enrollmen;

        public UsEnrollmentDetails()
        {
            InitializeComponent();
        }





       public void LoadEnrollmentData(int id)
        {
            Enrollmen = ClsEnrollment.Find(id);
            if (Enrollmen == null)
            {
                MessageBox.Show("This Enrollment Is not Exist ");
                return;

            }

            lbEnrollmentID.Text = Enrollmen.ErollmentiD.ToString();
            lbStatus.Text = Enrollmen.Status;
            lbGrade.Text = Enrollmen.Grade.ToString();
            lbFee.Text = Enrollmen.TotalFee.ToString();
            lbstudentID.Text = ClsStudents.Find(Enrollmen.StudentID).Fullname;
            lbCourseName.Text = ClsCourses.Find(Enrollmen.CourseID).Title;
        }

        private void UsEnrollmentDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
