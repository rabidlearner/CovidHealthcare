using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.Repository.Entity;

namespace CovidHealthcareApi.Repository
{
    public interface IUserRoleRepository
    {
        UserRole GetUserRoleById(int id);
        List<UserRole> GetAllUserRoles();
        void CreateUserRole(UserRole userRole);
        void DeleteUserRoleById(int id);
        void EditUserRole(UserRole userRole);
        string[] GetRolesForUser(string email);
    }
}
