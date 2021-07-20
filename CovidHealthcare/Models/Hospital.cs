using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidHealthcare.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string HospitalName { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
