using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.Repository.Entity;

namespace CovidHealthcareApi.Repository
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        List<User> GetAllUsers();
        void CreateUser(User user);
        void DeleteUserById(int id);
        void EditUser(User user);
    }
}
