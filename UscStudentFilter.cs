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
    public partial class UscStudentFilter : UserControl
    {
        public UscStudentFilter()
        {
            InitializeComponent();
        }

        
        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "ID":
                    usStudentDetials1.LoadStudentInfo(int.Parse(txtFilterValue.Text));
                    break;
            }
        }
        private void UscStudentFilter_Load(object sender, EventArgs e)
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
