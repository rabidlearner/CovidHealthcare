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
    public class CustomerProxy : ICustomerProxy
    {
        private readonly ICustomerCommandService customerCommandService;
        private readonly ICustomerQueryService customerQueryService;
        public CustomerProxy(ICustomerCommandService customerCommandService, ICustomerQueryService customerQueryService)
        {
            this.customerCommandService = customerCommandService;
            this.customerQueryService = customerQueryService;
        }
        public void CreateCustomer(Customer customer)
        {

            CovidHealthcareApi.DTO.Customer customerDto = new CovidHealthcareApi.DTO.Customer();
            customerDto = AutoMapper.Mapper.Map<Customer, CovidHealthcareApi.DTO.Customer>(customer);

            customerCommandService.CreateCustomer(customerDto);
        }

        public List<Customer> GetAllCustomers()
        {
            List<CovidHealthcareApi.DTO.Customer> customerDtoList = new List<CovidHealthcareApi.DTO.Customer>();
            customerDtoList = customerQueryService.GetAllCustomers();
            List<Customer> customer = new List<Customer>();
            foreach (var customerDto in customerDtoList)
            {
                customer.Add(Mapper.Map<CovidHealthcareApi.DTO.Customer, Customer>(customerDto));
            }
            return customer;

        }

        public void EditCustomer(Customer customer)
        {

            CovidHealthcareApi.DTO.Customer customerDto = new CovidHealthcareApi.DTO.Customer();
            customerDto = AutoMapper.Mapper.Map<Customer, CovidHealthcareApi.DTO.Customer>(customer);

            customerCommandService.EditCustomer(customerDto);
        }

        public void DeleteCustomerById(int id)
        {
            customerCommandService.DeleteCustomerById(id);
        }

        public Customer GetCustomerById(int id)
        {

            var customerDto = customerQueryService.GetCustomerById(id);
            Customer customer = new Customer();

            customer = Mapper.Map<CovidHealthcareApi.DTO.Customer, Customer>(customerDto);

            return customer;
        }
    }
}