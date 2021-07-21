using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.ControllerService
{
    public interface IDoctorControllerService
    {
        List<ViewModel.Doctor> GetDoctors();
        void CreateDoctor(Doctor Doctor);
        void DeleteDoctorById(int id);
        Doctor GetDoctorById(int id);

    }
}