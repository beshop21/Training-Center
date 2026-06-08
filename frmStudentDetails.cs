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
    public partial class frmStudentDetails : Form
    {
        private int _studentID = -1;
        public frmStudentDetails(int id)
        {
            InitializeComponent();
            usStudentDetials1.LoadStudentInfo(id);
        }



        private void frmStudentDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
