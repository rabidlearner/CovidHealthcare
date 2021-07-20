using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;

namespace CovidHealthcareApi.Services
{
    public interface IHospitalCommandService
    {
        void CreateHospital(Hospital hospital);
        void DeleteHospitalById(int id);
        void EditHospital(Hospital hospital);
    }
}
