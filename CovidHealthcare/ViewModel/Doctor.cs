using System;
using System.ComponentModel.DataAnnotations;

namespace CovidHealthcare.ViewModel
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
    }
}