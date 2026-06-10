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
    public partial class FrmCourseDetails : Form
    {
        public FrmCourseDetails(int id)
        {
            InitializeComponent();
            usCoursesInfo1.LoadInfo(id);
        }

        private void FrmCourseDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
