using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.Repository.Entity;

namespace CovidHealthcareApi.Repository
{
    public interface IDoctorRepository
    {
        Doctor GetDoctorById(int id);
        List<Doctor> GetAllDoctors();
        void CreateDoctor(Doctor Doctor);
        void DeleteDoctorById(int id);
        void EditDoctor(Doctor Doctor);
    }
}
