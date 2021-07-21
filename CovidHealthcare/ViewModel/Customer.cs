using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CovidHealthcare.ViewModel
{
    public class Customer
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is Mandatory")]
        [Display(Name = "Name")]
        [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Enter your first name and last name Ex:(Virat Kohli)")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Date of birth is Mandatory")]

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date, ErrorMessage = "Please Enter a Vaild Date")]
        public DateTime DateOfBirth { get; set; }


        [Required(ErrorMessage = "Gender is Mandatory")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Email is Mandatory")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Phone Number is Mandatory")]
        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Please enter valid 10 digit phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Please choose a Hospital")]
        [Display(Name = "Hospitals")]
        public int HospitalId { get; set; }
        public IList<Hospital> Hospital { get; set; }

        [Required(ErrorMessage = "Please Choose a Doctor")]
        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }
        public IList<Doctor> Doctor { get; set; }


    }
}