using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidHealthcareApi.DTO;
using CovidHealthcareApi.Repository;

namespace CovidHealthcareApi.Services
{
    public class UserRoleCommandService : IUserRoleCommandService
    {
        private readonly IUserRoleRepository repository;
        public UserRoleCommandService(IUserRoleRepository repository)
        {
            this.repository = repository;
        }
        public void DeleteUserRoleById(int id)
        {
            repository.DeleteUserRoleById(id);
        }

        public void EditUserRole(UserRole userRoleDto)
        {
            Repository.Entity.UserRole userRole = new Repository.Entity.UserRole();
            userRole = AutoMapper.Mapper.Map<UserRole, Repository.Entity.UserRole>(userRoleDto);
            repository.EditUserRole(userRole);
        }

        public void CreateUserRole(UserRole userRoleDto)
        {
            Repository.Entity.UserRole userRole = new Repository.Entity.UserRole();
            userRole = AutoMapper.Mapper.Map<UserRole, Repository.Entity.UserRole>(userRoleDto);
            repository.CreateUserRole(userRole);
        }
    }
}
