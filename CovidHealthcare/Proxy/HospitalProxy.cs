using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Models;
using CovidHealthcareApi.Services;
using CovidHealthcareApi;
using AutoMapper;

namespace CovidHealthcare.Proxy
{
    public class HospitalProxy : IHospitalProxy
    {
        private readonly IHospitalCommandService hospitalCommandService;
        private readonly IHospitalQueryService hospitalQueryService;
        public HospitalProxy(IHospitalCommandService hospitalCommandService, IHospitalQueryService hospitalQueryService)
        {
            this.hospitalCommandService = hospitalCommandService;
            this.hospitalQueryService = hospitalQueryService;
        }
        public void CreateHospital(Hospital hospital)
        {

            CovidHealthcareApi.DTO.Hospital hospitalDto = new CovidHealthcareApi.DTO.Hospital();
            hospitalDto = AutoMapper.Mapper.Map<Hospital, CovidHealthcareApi.DTO.Hospital>(hospital);

            hospitalCommandService.CreateHospital(hospitalDto);
        }

        public List<Hospital> GetAllHospitals()
        {
            List<CovidHealthcareApi.DTO.Hospital> hospitalDtoList = new List<CovidHealthcareApi.DTO.Hospital>();
            hospitalDtoList = hospitalQueryService.GetAllHospitals();
            List<Hospital> hospital = new List<Hospital>();
            foreach (var hospitalDto in hospitalDtoList)
            {
                hospital.Add(Mapper.Map<CovidHealthcareApi.DTO.Hospital, Hospital>(hospitalDto));
            }
            return hospital;

        }

        public void EditHospital(Hospital hospital)
        {

            CovidHealthcareApi.DTO.Hospital hospitalDto = new CovidHealthcareApi.DTO.Hospital();
            hospitalDto = AutoMapper.Mapper.Map<Hospital, CovidHealthcareApi.DTO.Hospital>(hospital);

            hospitalCommandService.EditHospital(hospitalDto);
        }

        public void DeleteHospitalById(int id)
        {


            hospitalCommandService.DeleteHospitalById(id);
        }

        public Hospital GetHospitalById(int id)
        {

            var hospitalDto = hospitalQueryService.GetHospitalById(id);
            Hospital hospital = new Hospital();

            hospital = Mapper.Map<CovidHealthcareApi.DTO.Hospital, Hospital>(hospitalDto);

            return hospital;
        }

        public bool IsInDatabase(string email)
        {
            return hospitalQueryService.IsInDatabase(email);
        }
    }
}