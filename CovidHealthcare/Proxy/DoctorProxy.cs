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
    public class DoctorProxy : IDoctorProxy
    {
        private readonly IDoctorCommandService DoctorCommandService;
        private readonly IDoctorQueryService DoctorQueryService;
        public DoctorProxy(IDoctorCommandService DoctorCommandService, IDoctorQueryService DoctorQueryService)
        {
            this.DoctorCommandService = DoctorCommandService;
            this.DoctorQueryService = DoctorQueryService;
        }
        public void CreateDoctor(Doctor Doctor)
        {

            CovidHealthcareApi.DTO.Doctor DoctorDto = new CovidHealthcareApi.DTO.Doctor();
            DoctorDto = AutoMapper.Mapper.Map<Doctor, CovidHealthcareApi.DTO.Doctor>(Doctor);

            DoctorCommandService.CreateDoctor(DoctorDto);
        }

        public List<Doctor> GetAllDoctors()
        {
            List<CovidHealthcareApi.DTO.Doctor> DoctorDtoList = new List<CovidHealthcareApi.DTO.Doctor>();
            DoctorDtoList = DoctorQueryService.GetAllDoctors();
            List<Doctor> Doctor = new List<Doctor>();
            foreach (var DoctorDto in DoctorDtoList)
            {
                Doctor.Add(Mapper.Map<CovidHealthcareApi.DTO.Doctor, Doctor>(DoctorDto));
            }
            return Doctor;

        }

        public void EditDoctor(Doctor Doctor)
        {

            CovidHealthcareApi.DTO.Doctor DoctorDto = new CovidHealthcareApi.DTO.Doctor();
            DoctorDto = AutoMapper.Mapper.Map<Doctor, CovidHealthcareApi.DTO.Doctor>(Doctor);

            DoctorCommandService.EditDoctor(DoctorDto);
        }

        public void DeleteDoctorById(int id)
        {


            DoctorCommandService.DeleteDoctorById(id);
        }

        public Doctor GetDoctorById(int id)
        {

            var DoctorDto = DoctorQueryService.GetDoctorById(id);
            Doctor Doctor = new Doctor();

            Doctor = Mapper.Map<CovidHealthcareApi.DTO.Doctor, Doctor>(DoctorDto);

            return Doctor;
        }
    }
}