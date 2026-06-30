using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicMangementSystem.Models
{
    public class PatientModel
    {
        public int PatientID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
    }
}
