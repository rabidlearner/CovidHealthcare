using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;

namespace CovidHealthcareApi.Services
{
    public interface IUserRoleQueryService
    {
        UserRole GetUserRoleById(int id);
        List<UserRole> GetAllUserRoles();
        string[] GetRolesForUser(string Email);
    }
}
