using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Models;
using CovidHealthcareApi.Services;

namespace CovidHealthcare.Proxy
{
    public interface IDoctorProxy
    {
        void CreateDoctor(Doctor Doctor);
        List<Doctor> GetAllDoctors();
        void EditDoctor(Doctor Doctor);
        void DeleteDoctorById(int id);
        Doctor GetDoctorById(int id);
    }
}