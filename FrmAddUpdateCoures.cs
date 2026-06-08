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
    public partial class FrmAddUpdateCoures : Form
    {

        enum EnMOde { addnew=0,update=1};
        EnMOde Mode = EnMOde.addnew;

        private int _CourseID = -1;
        ClsCourses Courseinfo = new ClsCourses();
        public FrmAddUpdateCoures()
        {
            InitializeComponent();
            Mode = EnMOde.addnew;
        }

        public FrmAddUpdateCoures(int id)
        {
            InitializeComponent();
            _CourseID = id;
            Mode = EnMOde.update;
        }


        private void _RestDefult()
        {
            if (Mode == EnMOde.addnew)
            {
                lblTitle.Text = "Add New Course";
            }
            else
                lblTitle.Text = "Update Course ";

            lblTitle.Text = "";
            lbPrice.Text = "";
            dtpDateOfstart.Value = DateTime.Now;
            lbHourse.Text = "";
            RdYes.Checked = true;
            
            
        }

        private void _LoadData()
        {

            Courseinfo = ClsCourses.Find(_CourseID);
            if (Courseinfo == null)
            {
                MessageBox.Show("This course Not Exist");
                return;
            }
            lblPersonID.Text = Courseinfo.CourseID.ToString();
            lblTitle.Text = Courseinfo.Title;
            lbPrice.Text = Courseinfo.Price.ToString();
            lbHourse.Text = Courseinfo.Hourse.ToString();
            if (Courseinfo.IsActive = true)
            {
                RdYes.Checked = true;
            }
            else
                RbNo.Checked = true;
            

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddUpdateCoures_Load(object sender, EventArgs e)
        {

        }
    }
}
