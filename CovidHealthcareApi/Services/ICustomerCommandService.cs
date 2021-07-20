using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;

namespace CovidHealthcareApi.Services
{
    public interface ICustomerCommandService
    {
        void CreateCustomer(Customer customer);
        void DeleteCustomerById(int id);
        void EditCustomer(Customer customer);
    }
}