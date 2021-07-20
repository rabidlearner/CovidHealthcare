using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;

namespace CovidHealthcareApi.Services
{
    public interface IUserRoleCommandService
    {
        void CreateUserRole(UserRole userRole);
        void DeleteUserRoleById(int id);
        void EditUserRole(UserRole userRole);
    }
}
