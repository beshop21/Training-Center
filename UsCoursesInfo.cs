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
    public partial class UsCoursesInfo : UserControl
    {
        private int _CourseID = -1;
        ClsCourses course;

        public int courseID
        {
            get { return _CourseID; }
        }
        public UsCoursesInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(int Id)
        {
            course = ClsCourses.Find(Id);
            if (course == null)
            {
                MessageBox.Show("This Course is Not Exist");
            }
            lblPersonID.Text = course.CourseID.ToString();
            lbTitle.Text = course.Title;
            lbHourse.Text = course.Hourse.ToString();
            lbPrice.Text = course.Price.ToString();
            lbStartDate.Text = course.StartDate.ToString();
            if (course.IsActive == true)
            {
                lbIsActive.Text = "True";
            }
            else
                lbIsActive.Text = "false";
        }




        private void UsCoursesInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
