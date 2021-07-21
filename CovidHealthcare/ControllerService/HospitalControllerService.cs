using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Proxy;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.ControllerService
{
    public class HospitalControllerService : IHospitalControllerService
    {
        private readonly IHospitalProxy proxy;
        public HospitalControllerService(IHospitalProxy proxy)
        {
            this.proxy = proxy;
        }
        public void CreateHospital(Hospital hospital)
        {
            Models.Hospital hospitalModel = AutoMapper.Mapper.Map<ViewModel.Hospital, Models.Hospital>(hospital);
            proxy.CreateHospital(hospitalModel);
        }
        public List<Hospital> GetHospitals()
        {
            var Doctors = proxy.GetAllHospitals();
            List<ViewModel.Hospital> DoctorView = new List<Hospital>();
            foreach (var Doctor in Doctors)
            {
                DoctorView.Add(AutoMapper.Mapper.Map<Models.Hospital, ViewModel.Hospital>(Doctor));
            }
            return DoctorView;
        }
        public bool IsInDatabase(string email)
        {
            return proxy.IsInDatabase(email);
        }
    }
}