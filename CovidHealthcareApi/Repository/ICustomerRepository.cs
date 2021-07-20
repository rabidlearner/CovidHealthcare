using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.Repository.Entity;

namespace CovidHealthcareApi.Repository
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        List<Customer> GetAllCustomers();
        void CreateCustomer(Customer customer);
        void DeleteCustomerById(int id);
        void EditCustomer(Customer customer);
    }
}
