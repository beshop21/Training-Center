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
    public partial class UscCourseDetailsWithFilter : UserControl
    {
        public UscCourseDetailsWithFilter()
        {
            InitializeComponent();
        }

       public int CourseID
        {
            get { return usCoursesInfo1.courseID; }
        }





        private void UscCourseDetailsWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {

                case "ID":
                    usCoursesInfo1.LoadInfo(int.Parse(txtFilterValue.Text));
                    break;


                case "Name":
                    usCoursesInfo1.LoadInfo(txtFilterValue.Text);
                    break;




            }
        }

        private void usCoursesInfo1_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindNow();
        }
    }
}
