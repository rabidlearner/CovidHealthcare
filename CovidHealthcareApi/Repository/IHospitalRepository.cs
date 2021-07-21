using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.Repository.Entity;

namespace CovidHealthcareApi.Repository
{
    public interface IHospitalRepository
    {
        Hospital GetHospitalById(int id);
        List<Hospital> GetAllHospitals();
        void CreateHospital(Hospital hospital);
        void DeleteHospitalById(int id);
        void EditHospital(Hospital hospital);
        bool IsInDatabase(string email);
    }
}
