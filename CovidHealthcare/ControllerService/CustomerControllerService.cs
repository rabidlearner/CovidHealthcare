using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Proxy;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.ControllerService
{
    public class CustomerControllerService : ICustomerControllerService
    {
        private readonly ICustomerProxy proxy;
        private readonly IHospitalControllerService hospitalControllerService;
        private readonly IDoctorControllerService DoctorControllerService;

        public CustomerControllerService(ICustomerProxy proxy, IDoctorControllerService DoctorControllerService, IHospitalControllerService hospitalControllerService)
        {
            this.proxy = proxy;
            this.DoctorControllerService = DoctorControllerService;
            this.hospitalControllerService = hospitalControllerService;
        }

        public Customer Create()
        {
            Customer customer = new Customer()
            {
                Hospital = hospitalControllerService.GetHospitals(),
                Doctor = DoctorControllerService.GetDoctors()
            };
            return customer;
        }

        public void CreateCustomer(Customer customer)
        {
            Models.Customer customerModel = new Models.Customer();
            customerModel = AutoMapper.Mapper.Map<ViewModel.Customer, Models.Customer>(customer);
            proxy.CreateCustomer(customerModel);
        }
    }
}