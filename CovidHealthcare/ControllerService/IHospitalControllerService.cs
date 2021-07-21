using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.ControllerService
{
    public interface IHospitalControllerService
    {
        void CreateHospital(Hospital hospital);
        List<Hospital> GetHospitals();
        bool IsInDatabase(string email);
    }
}