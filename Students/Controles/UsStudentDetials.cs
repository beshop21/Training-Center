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
    public partial class UsStudentDetials : UserControl
    {

        private int _StudentID = -1;
        ClsStudents student = new ClsStudents();

        public int ID
        {
            get { return _StudentID; }
        }


        public UsStudentDetials()
        {
            InitializeComponent();
        }

        public void LoadStudentInfo(int id)
        {
            student = ClsStudents.Find(id);
            if (student == null)
            {
                MessageBox.Show("This Student Not Exist");
                return;
            }
            _FillData();
        }

        private void _FillData()
        {
            _StudentID = student.ID;
            lblPersonID.Text = student.ID.ToString();
            lblFullName.Text = student.FirtName + " " + student.SecondName + " "+student.ThirdName;
            lblEmail.Text = student.Email;
            lblPhone.Text = student.Phone;
            lblDateOfBirth.Text = student.DateOfBrith.ToShortDateString();
        }
        private void UsStudentDetials_Load(object sender, EventArgs e)
        {

        }
    }
}
