using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicMangementSystem.Models
{
    internal class BillModel
    {
        public int BillID { get; set; }
        public int AppointmentID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }



        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
