using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;
using CovidHealthcareApi.Repository;

namespace CovidHealthcareApi.Services
{
    public class UserCommandService : IUserCommandService
    {
        private readonly IUserRepository repository;
        public UserCommandService(IUserRepository repository)
        {
            this.repository = repository;
        }
        public void DeleteUserById(int id)
        {
            repository.DeleteUserById(id);
        }

        public void EditUser(User userDto)
        {
            Repository.Entity.User user = new Repository.Entity.User();
            user = AutoMapper.Mapper.Map<User, Repository.Entity.User>(userDto);
            repository.EditUser(user);
        }

        public void CreateUser(User userDto)
        {
            Repository.Entity.User user = new Repository.Entity.User();
            user = AutoMapper.Mapper.Map<User, Repository.Entity.User>(userDto);
            repository.CreateUser(user);
        }
    }
}
