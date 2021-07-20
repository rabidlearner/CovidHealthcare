using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;
using CovidHealthcareApi.Repository;

namespace CovidHealthcareApi.Services
{
    public class DoctorQueryService : IDoctorQueryService
    {
        private readonly IDoctorRepository repository;
        public DoctorQueryService(IDoctorRepository repository)
        {
            this.repository = repository;
        }
        public List<Doctor> GetAllDoctors()
        {
            List<Repository.Entity.Doctor> Doctors = new List<Repository.Entity.Doctor>();

            Doctors = repository.GetAllDoctors();
            List<Doctor> DoctorDto = new List<Doctor>();
            foreach (var Doctor in Doctors)
            {
                DoctorDto.Add(AutoMapper.Mapper.Map<Repository.Entity.Doctor, Doctor>(Doctor));
            }

            return DoctorDto;
        }

        public Doctor GetDoctorById(int id)
        {
            Repository.Entity.Doctor Doctor = new Repository.Entity.Doctor();
            Doctor DoctorDto = new Doctor();
            Doctor = repository.GetDoctorById(id);
            DoctorDto = AutoMapper.Mapper.Map<Repository.Entity.Doctor, Doctor>(Doctor);
            return DoctorDto;
        }
    }
}
