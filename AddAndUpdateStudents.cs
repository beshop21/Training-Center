using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusLayaer;

using System.Windows.Forms;

namespace Training_Center
{
    public partial class AddAndUpdateStudents : Form
    {
        private void AddAndUpdateStudents_Load(object sender, EventArgs e)
        {
            _RestDefualt();
            if (mode == Enmode.update)
            {
                _LoadData();
            }
        }
        public enum Enmode { addnew = 0, update = 1 }
        public Enmode mode;
        private int _StudnetID = -1;
        ClsStudents student = new ClsStudents();

        public AddAndUpdateStudents()
        {
            InitializeComponent();
            mode = Enmode.addnew;
        }
        public AddAndUpdateStudents(int ID)
        {
            InitializeComponent();
            _StudnetID = ID;
            mode = Enmode.update;
        }


        private void _RestDefualt()
        {
            if (mode == Enmode.addnew)
            {
                lblTitle.Text = "Add New Student";
            }
            else
                lblTitle.Text = "Update Studnet";

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";


        }


        private void _LoadData()
        {
            student = ClsStudents.Find(_StudnetID);
            if (student == null)
            {
                MessageBox.Show("This student Not Exist ,By be deleteing contact your Admin");
                return;
            }


            txtStudentID.Text = student.ID.ToString();
            txtFirstName.Text = student.FirtName;
            txtSecondName.Text = student.SecondName;
            txtThirdName.Text = student.ThirdName;
            txtPhone.Text = student.Phone;
            txtEmail.Text = student.Email;
            dtpDateOfBirth.Value = student.DateOfBrith;

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void AddAndUpdateStudents_Load(object sender, EventArgs e)
        //{
        //    _RestDefualt();
        //    if (mode == Enmode.update)
        //    {
        //        _LoadData();
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {




            student.FirtName = txtFirstName.Text;
            student.SecondName = txtSecondName.Text;
            student.ThirdName = txtThirdName.Text;
            student.Phone = txtPhone.Text;
            student.Email = txtEmail.Text;
            student.DateOfBrith = dtpDateOfBirth.Value;
            student.CreatedIt = DateTime.Now;

            if (student.Save())
            {
                MessageBox.Show("this Student Is Save Seccussfully ");
                txtStudentID.Text = student.ID.ToString();

            }

            else
                MessageBox.Show("There is Eror please Check");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            student.FirtName = txtFirstName.Text;
            student.SecondName = txtSecondName.Text;
            student.ThirdName = txtThirdName.Text;
            student.Phone = txtPhone.Text;
            student.Email = txtEmail.Text;
            student.DateOfBrith = dtpDateOfBirth.Value;
            student.CreatedIt = DateTime.Now;

            if (student.Save())
            {
                MessageBox.Show("this Student Is Save Seccussfully ");
                txtStudentID.Text = student.ID.ToString();

            }

            else
                MessageBox.Show("There is Eror please Check");
        }
    }
}
