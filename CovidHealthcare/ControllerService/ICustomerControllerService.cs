using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.ControllerService
{
    public interface ICustomerControllerService
    {
        Customer Create();
        void CreateCustomer(Customer customer);

    }
}
