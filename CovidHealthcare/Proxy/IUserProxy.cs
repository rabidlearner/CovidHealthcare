using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Models;
using CovidHealthcareApi.Services;

namespace CovidHealthcare.Proxy
{
    public interface IUserProxy
    {
        void CreateUser(User user);
        List<User> GetAllUsers();
        void EditUser(User user);
        void DeleteUserById(int id);
        User GetUserById(int id);
    }
}