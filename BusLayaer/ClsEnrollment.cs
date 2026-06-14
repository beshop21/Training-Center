using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BusLayaer
{
    public class ClsEnrollment
    {
        enum Enmode { addnew=0,update=1 }
        Enmode Mode = Enmode.addnew;
        public int ErollmentiD { get; set; }
        public string Status { get; set; }
        public int StudentID { get; set; }

        public int CourseID{ get; set; }
        public float Grade { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public float TotalFee { get; set; }

        public ClsEnrollment()
        {
            this.ErollmentiD = -1;
            this.Status = "";
            this.StudentID = -1;
            this.CourseID = -1;
            this.Grade = -1;
            this.EnrollmentDate = DateTime.Now;
            this.TotalFee = -1;
            Mode = Enmode.addnew;
        }

        private ClsEnrollment(int enrollmenID,string status,int studentid,int coursid,float grade,DateTime enrollmentdate,float totalfee)
        {
            this.ErollmentiD = enrollmenID;
            this.Status = status;
            this.StudentID = studentid;
            this.CourseID = coursid;
            this.Grade = grade;
            this.EnrollmentDate = enrollmentdate;
            this.TotalFee = totalfee;
            Mode = Enmode.update;
        }



        public bool IsStudentHasEnrollmentOnthisCourse(int StID,int COuID)
        {
            return EnrollmentData.IsStudentHaveErollmentOnthisCourse(StID, COuID);
        }



        private bool _AddNewEnrollment()
        {
            this.ErollmentiD = EnrollmentData.InsertNewEnrollment(this.Status, this.StudentID, this.CourseID, this.Grade, this.EnrollmentDate, this.TotalFee);
            return (this.ErollmentiD != -1);
           

        }

        private bool _updateEnrollment()
        {
            return EnrollmentData.UpdateNewEnrollment(this.ErollmentiD, this.Status, this.StudentID, this.CourseID, this.Grade, this.EnrollmentDate, this.TotalFee);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Enmode.addnew:
                    if (_AddNewEnrollment())
                    {
                        Mode = Enmode.update;
                        return true;
                    }
                    else
                        return false;
            }
            return false;
        }


        public static bool Delete(int id)
        {
            return EnrollmentData.DeleteEnrollment(id);
        }

        public DataTable GetAll()
        {
            return EnrollmentData.GetAllRecode();
        }

    }
}
