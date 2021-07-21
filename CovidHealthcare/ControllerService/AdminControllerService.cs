using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.ViewModel;
using CovidHealthcare.Proxy;

namespace CovidHealthcare.ControllerService
{
    public class AdminControllerService : IAdminControllerService
    {
        private readonly IHospitalProxy hospitalProxy;
        private readonly IUserRoleProxy userRoleProxy;
        public AdminControllerService(IUserRoleProxy userRoleProxy, IHospitalProxy hospitalProxy)
        {
            this.userRoleProxy = userRoleProxy;
            this.hospitalProxy = hospitalProxy;
        }


        public List<Hospital> GetHospitals()
        {
            List<Hospital> hospitalsView = new List<Hospital>();
            List<Models.Hospital> hospitals = new List<Models.Hospital>();
            hospitals = hospitalProxy.GetAllHospitals();
            foreach (var hospital in hospitals)
            {
                Hospital hospitalView = new Hospital();
                hospitalView = AutoMapper.Mapper.Map<Models.Hospital, ViewModel.Hospital>(hospital);
                hospitalsView.Add(hospitalView);
            }
            return hospitalsView;
        }


        public RegisterViewModel UserFromHospital(int id)
        {
            Models.Hospital hospital = new Models.Hospital();

            hospital = hospitalProxy.GetHospitalById(id);
            List<UserRole> userRoleView = new List<UserRole>();
            List<Models.UserRole> userRoles = new List<Models.UserRole>();
            ViewModel.User userView = new ViewModel.User();
            userRoles = userRoleProxy.GetAllUserRoles();

            foreach (var userRole in userRoles)
            {
                userRoleView.Add(AutoMapper.Mapper.Map<Models.UserRole, ViewModel.UserRole>(userRole));
            }

            RegisterViewModel user = new RegisterViewModel()
            {
                Email = hospital.Email,
                UserRoleId = 2,
                UserRole = userRoleView

            };
            return user;
        }



        public Hospital GetHospitalById(int id)
        {
            Hospital hospitalView = new Hospital();
            Models.Hospital hospital = new Models.Hospital();
            hospital = hospitalProxy.GetHospitalById(id);
            hospitalView = AutoMapper.Mapper.Map<Models.Hospital, ViewModel.Hospital>(hospital);
            return hospitalView;
        }


        public void DeleteHospitalById(int id)
        {

            hospitalProxy.DeleteHospitalById(id);

        }

    }
}