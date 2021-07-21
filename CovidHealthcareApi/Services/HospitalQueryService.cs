using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;
using CovidHealthcareApi.Repository;

namespace CovidHealthcareApi.Services
{
    public class HospitalQueryService : IHospitalQueryService
    {
        private readonly IHospitalRepository repository;
        public HospitalQueryService(IHospitalRepository repository)
        {
            this.repository = repository;
        }
        public List<Hospital> GetAllHospitals()
        {
            List<Repository.Entity.Hospital> hospitals = new List<Repository.Entity.Hospital>();

            hospitals = repository.GetAllHospitals();
            List<Hospital> hospitalDto = new List<Hospital>();
            foreach (var hospital in hospitals)
            {
                hospitalDto.Add(AutoMapper.Mapper.Map<Repository.Entity.Hospital, Hospital>(hospital));
            }

            return hospitalDto;
        }

        public Hospital GetHospitalById(int id)
        {
            Repository.Entity.Hospital hospital = new Repository.Entity.Hospital();
            Hospital hospitalDto = new Hospital();
            hospital = repository.GetHospitalById(id);
            hospitalDto = AutoMapper.Mapper.Map<Repository.Entity.Hospital, Hospital>(hospital);
            return hospitalDto;
        }

        public bool IsInDatabase(string email)
        {
            return repository.IsInDatabase(email);
        }
    }
}
