using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicMangementSystem.Models
{
    public class DoctorModel
    {
        public int DoctorID { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public string phone { get; set; }
        public  decimal ConsultationFee { get; set; }
    }
}
