using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidHealthcare.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string AadharNumber { get; set; }

        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}