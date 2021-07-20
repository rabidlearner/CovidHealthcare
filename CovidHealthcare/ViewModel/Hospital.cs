using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidHealthcare.ViewModel
{
    public class Hospital
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Hospital Name is Mandatory")]
        [Display(Name = "Hospital Name")]
        [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Enter your first name and last name together Ex:(Ramesh Sharma)")]
        public string HospitalName { get; set; }

        [Required(ErrorMessage = "Hospital Employee Name is Mandatory")]
        [Display(Name = "Hospital Employee Name")]
        [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Enter first name and last name together Ex:(Ramesh Sharma)")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Address is Mandatory")]
        [DataType(DataType.MultilineText)]
        [RegularExpression(@"[0-9-,/]+[A-za-z ,]+[0-9]{6}", ErrorMessage = "Door Number,street,City,Pincode Ex:(1-11,street,City,100000)")]
        public string Address { get; set; }



        [Required(ErrorMessage = "City is Mandatory")]
        [Display(Name = "City")]
        [RegularExpression(@"[A-Z]{1}[a-z]*", ErrorMessage = "Please Enter First letter Capital and all other letters small ")]
        public string Location { get; set; }


        [Required(ErrorMessage = "Phone Number is Mandatory")]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Please enter valid 10 digit phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is Mandatory")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}
