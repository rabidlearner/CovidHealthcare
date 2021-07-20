using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;

namespace CovidHealthcareApi.Services
{
    public interface ICustomerQueryService
    {
        Customer GetCustomerById(int id);
        List<Customer> GetAllCustomers();
    }
}
