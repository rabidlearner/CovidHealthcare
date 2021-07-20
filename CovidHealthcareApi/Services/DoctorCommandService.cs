using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;
using CovidHealthcareApi.Repository;

namespace CovidHealthcareApi.Services
{
    public class DoctorCommandService : IDoctorCommandService
    {
        private readonly IDoctorRepository repository;
        public DoctorCommandService(IDoctorRepository repository)
        {
            this.repository = repository;
        }
        public void DeleteDoctorById(int id)
        {
            repository.DeleteDoctorById(id);
        }

        public void EditDoctor(Doctor DoctorDto)
        {
            Repository.Entity.Doctor Doctor = new Repository.Entity.Doctor();
            Doctor = AutoMapper.Mapper.Map<Doctor, Repository.Entity.Doctor>(DoctorDto);
            repository.EditDoctor(Doctor);
        }

        public void CreateDoctor(Doctor DoctorDto)
        {
            Repository.Entity.Doctor Doctor = new Repository.Entity.Doctor();
            Doctor = AutoMapper.Mapper.Map<Doctor, Repository.Entity.Doctor>(DoctorDto);
            repository.CreateDoctor(Doctor);
        }
    }
}
