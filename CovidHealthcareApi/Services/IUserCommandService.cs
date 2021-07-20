using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;

namespace CovidHealthcareApi.Services
{
    public interface IUserCommandService
    {
        void CreateUser(User user);
        void DeleteUserById(int id);
        void EditUser(User user);
    }
}
