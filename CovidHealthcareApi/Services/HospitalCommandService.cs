using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;
using CovidHealthcareApi.Repository;

namespace CovidHealthcareApi.Services
{
    public class HospitalCommandService : IHospitalCommandService
    {
        private readonly IHospitalRepository repository;
        public HospitalCommandService(IHospitalRepository repository)
        {
            this.repository = repository;
        }
        public void DeleteHospitalById(int id)
        {
            repository.DeleteHospitalById(id);
        }

        public void EditHospital(Hospital hospitalDto)
        {
            Repository.Entity.Hospital hospital = new Repository.Entity.Hospital();
            hospital = AutoMapper.Mapper.Map<Hospital, Repository.Entity.Hospital>(hospitalDto);
            repository.EditHospital(hospital);
        }

        public void CreateHospital(Hospital hospitalDto)
        {
            Repository.Entity.Hospital hospital = new Repository.Entity.Hospital();
            hospital = AutoMapper.Mapper.Map<Hospital, Repository.Entity.Hospital>(hospitalDto);
            repository.CreateHospital(hospital);
        }
    }
}
