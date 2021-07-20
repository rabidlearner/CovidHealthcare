using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.ViewModel;
using CovidHealthcare.Proxy;

namespace CovidHealthcare.ControllerService
{
    public class DoctorControllerService : IDoctorControllerService
    {
        private readonly IDoctorProxy proxy;
        public DoctorControllerService(IDoctorProxy proxy)
        {
            this.proxy = proxy;
        }
        public List<Doctor> GetDoctors()
        {
            var Doctors = proxy.GetAllDoctors();
            List<ViewModel.Doctor> DoctorView = new List<Doctor>();
            foreach (var Doctor in Doctors)
            {
                DoctorView.Add(AutoMapper.Mapper.Map<Models.Doctor, ViewModel.Doctor>(Doctor));
            }
            return DoctorView;
        }

        public void CreateDoctor(Doctor Doctor)
        {
            Models.Doctor DoctorModel = AutoMapper.Mapper.Map<ViewModel.Doctor, Models.Doctor>(Doctor);
            proxy.CreateDoctor(DoctorModel);
        }
    }
}