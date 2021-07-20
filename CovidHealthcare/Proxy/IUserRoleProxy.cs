using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Models;
using CovidHealthcareApi.Services;

namespace CovidHealthcare.Proxy
{
    public interface IUserRoleProxy
    {
        void CreateUserRole(UserRole userRole);
        List<UserRole> GetAllUserRoles();
        void EditUserRole(UserRole userRole);
        void DeleteUserRoleById(int id);
        UserRole GetUserRoleById(int id);
        string[] GetRolesForUser(string email);
    }
}