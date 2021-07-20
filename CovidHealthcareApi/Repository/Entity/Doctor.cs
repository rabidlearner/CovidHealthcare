using System;
using System.ComponentModel.DataAnnotations;

namespace CovidHealthcareApi.Repository.Entity
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
    }
}