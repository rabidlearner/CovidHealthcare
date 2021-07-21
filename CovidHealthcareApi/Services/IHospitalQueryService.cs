using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;

namespace CovidHealthcareApi.Services
{
    public interface IHospitalQueryService
    {
        Hospital GetHospitalById(int id);
        List<Hospital> GetAllHospitals();
        bool IsInDatabase (string email);
    }
}
