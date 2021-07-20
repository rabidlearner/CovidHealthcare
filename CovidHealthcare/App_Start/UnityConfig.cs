using System;

using Unity;
using CovidHealthcareApi.Services;
using CovidHealthcare.Proxy;
using CovidHealthcareApi.Repository;
using CovidHealthcare.ControllerService;

namespace CovidHealthcare
{

    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion


        public static void RegisterTypes(IUnityContainer container)
        {

            container.RegisterType<IUserQueryService, UserQueryService>();
            container.RegisterType<IUserCommandService, UserCommandService>();
            container.RegisterType<IUserProxy, UserProxy>();
            container.RegisterType<IUserRepository, UserRepository>();

            container.RegisterType<IUserRoleQueryService, UserRoleQueryService>();
            container.RegisterType<IUserRoleCommandService, UserRoleCommandService>();
            container.RegisterType<IUserRoleProxy, UserRoleProxy>();
            container.RegisterType<IUserRoleRepository, UserRoleRepository>();

            container.RegisterType<IAccountControllerService, AccountControllerService>();
            container.RegisterType<IDoctorControllerService, DoctorControllerService>();
            container.RegisterType<IHospitalControllerService, HospitalControllerService>();
            container.RegisterType<ICustomerControllerService, CustomerControllerService>();


            container.RegisterType<ICustomerQueryService, CustomerQueryService>();
            container.RegisterType<ICustomerCommandService, CustomerCommandService>();
            container.RegisterType<ICustomerProxy, CustomerProxy>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();

            container.RegisterType<IHospitalQueryService, HospitalQueryService>();
            container.RegisterType<IHospitalCommandService, HospitalCommandService>();
            container.RegisterType<IHospitalProxy, HospitalProxy>();
            container.RegisterType<IHospitalRepository, HospitalRepository>();

            container.RegisterType<IDoctorQueryService, DoctorQueryService>();
            container.RegisterType<IDoctorCommandService, DoctorCommandService>();
            container.RegisterType<IDoctorProxy, DoctorProxy>();
            container.RegisterType<IDoctorRepository, DoctorRepository>();
        }
    }
}