using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.ControllerService
{
    public interface IAdminControllerService
    {
        List<Hospital> GetHospitals();
        RegisterViewModel UserFromHospital(int id);
        Hospital GetHospitalById(int id);
        void DeleteHospitalById(int id);

    }
}
