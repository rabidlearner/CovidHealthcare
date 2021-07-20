using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Models;
using CovidHealthcareApi.Services;

namespace CovidHealthcare.Proxy
{
    public interface ICustomerProxy
    {
        void CreateCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        void EditCustomer(Customer customer);
        void DeleteCustomerById(int id);
        Customer GetCustomerById(int id);
    }
}