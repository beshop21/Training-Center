using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
