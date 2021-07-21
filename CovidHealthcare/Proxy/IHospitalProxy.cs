using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Models;
using CovidHealthcareApi.Services;

namespace CovidHealthcare.Proxy
{
    public interface IHospitalProxy
    {
        void CreateHospital(Hospital hospital);
        List<Hospital> GetAllHospitals();
        void EditHospital(Hospital hospital);
        void DeleteHospitalById(int id);
        Hospital GetHospitalById(int id);
        bool IsInDatabase(string email);
    }
}