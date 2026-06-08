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
                Title.Text = "Add New Courses";
            }
            else
                Title.Text = "Update Course ";

            Title.Text = "";
           
            dtpDateOfstart.Value = DateTime.Now;
            txtHourse.Text = "";
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
            txtTitle.Text = Courseinfo.Title;
            txtprice.Text = Courseinfo.Price.ToString();
            txtHourse.Text = Courseinfo.Hourse.ToString();
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
            _RestDefult();
            if (Mode == EnMOde.update)
            {
                _LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Courseinfo.Title = txtTitle.Text;
            Courseinfo.Hourse =Convert.ToInt16 (txtHourse.Text);
            Courseinfo.Price = Convert.ToInt16(txtprice.Text);
            Courseinfo.StartDate = dtpDateOfstart.Value;
            if (RdYes.Checked)
            {
                Courseinfo.IsActive = true;
            }
            else
                Courseinfo.IsActive = false;

            if (Courseinfo.Save())
            {
                MessageBox.Show("This Course is Save Successfully");
                lblPersonID.Text = Courseinfo.CourseID.ToString();
            }
            else
                MessageBox.Show("there is Erorr please cheack");
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
