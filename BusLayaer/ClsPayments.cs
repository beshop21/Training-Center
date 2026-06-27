using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusLayaer
{
    public class ClsPayments
    {
        enum Enmode { addnew=0,update=1}
        Enmode mode = Enmode.addnew;

        public int PaymentID { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public DateTime PaymentDate { get; set; }

        public float AmountPaid { get; set; }

        public string PaymentMethod { get; set; }



        public ClsPayments()
        {
            this.PaymentID = -1;
            this.StudentName = "";
            this.CourseName = "";
            this.PaymentDate = DateTime.Now;
            this.AmountPaid = -1;
            this.PaymentMethod = "";
            mode = Enmode.addnew;
        }

        private ClsPayments(int id,string studentname,string coursename,DateTime paymentdate,float amountpaid,string paymentmethod)
        {
            this.PaymentID = id;
            this.StudentName = studentname;
            this.CourseName = coursename;
            this.PaymentDate = paymentdate;
            this.AmountPaid = amountpaid;
            this.PaymentMethod = paymentmethod;
            mode = Enmode.update;
        }


        private bool _Add()
        {
            this.PaymentID = PaymentsData.InsertNewPayment(this.StudentName, this.CourseName, this.PaymentDate, this.AmountPaid, this.PaymentMethod);
            return (this.PaymentID != -1);

        }

        public static ClsPayments Find(int id)
        {
            string studentname = ""; string coursename = ""; DateTime paydate = DateTime.Now; float amountpaid = -1;
            string paymentMethod = "";

            if (PaymentsData.GetPaymentByID(id, ref studentname, ref coursename, ref paydate, ref amountpaid, ref paymentMethod)) { 
                return new ClsPayments(id, studentname, coursename, paydate, amountpaid, paymentMethod);

            }
            else
                return null;
        }
        private bool _Update()
        {
            return PaymentsData.UpdatePayments(this.PaymentID, this.StudentName, this.CourseName, this.PaymentDate, this.AmountPaid, this.PaymentMethod);

        }









        public bool Save()
        {
            switch (mode)
            {
                case Enmode.addnew:
                    if (_Add())
                    {
                        mode = Enmode.update;
                        return true;
                        break;
                    }
                    else
                        return false;

                case Enmode.update:
                    return _Update();
            }
            return false;
        }

        public static DataTable GetAll()
        {
            return PaymentsData.GetAllRecode();
        }

        public static bool Delete(int id)
        {
            return PaymentsData.DeletePayment(id);
        }
    }
}
