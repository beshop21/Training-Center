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
    public partial class FrmEnrollmentDetails : Form
    {
        public FrmEnrollmentDetails(int id)
        {
            InitializeComponent();
            usEnrollmentDetails1.LoadEnrollmentData(id);
        }

        private void FrmEnrollmentDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
