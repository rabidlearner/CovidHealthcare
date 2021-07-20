using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Models;
using CovidHealthcareApi.Services;
using CovidHealthcareApi;
using AutoMapper;

namespace CovidHealthcare.Proxy
{
    public class UserRoleProxy : IUserRoleProxy
    {
        private readonly IUserRoleCommandService userRoleCommandService;
        private readonly IUserRoleQueryService userRoleQueryService;
        public UserRoleProxy(IUserRoleCommandService userRoleCommandService, IUserRoleQueryService userRoleQueryService)
        {
            this.userRoleCommandService = userRoleCommandService;
            this.userRoleQueryService = userRoleQueryService;
        }
        public void CreateUserRole(UserRole userRole)
        {

            CovidHealthcareApi.DTO.UserRole userRoleDto = new CovidHealthcareApi.DTO.UserRole();
            userRoleDto = AutoMapper.Mapper.Map<UserRole, CovidHealthcareApi.DTO.UserRole>(userRole);

            userRoleCommandService.CreateUserRole(userRoleDto);
        }

        public List<UserRole> GetAllUserRoles()
        {
            List<CovidHealthcareApi.DTO.UserRole> userRoleDtoList = new List<CovidHealthcareApi.DTO.UserRole>();
            userRoleDtoList = userRoleQueryService.GetAllUserRoles();
            List<UserRole> userRole = new List<UserRole>();
            foreach (var userRoleDto in userRoleDtoList)
            {
                userRole.Add(Mapper.Map<CovidHealthcareApi.DTO.UserRole, UserRole>(userRoleDto));
            }
            return userRole;

        }

        public void EditUserRole(UserRole userRole)
        {

            CovidHealthcareApi.DTO.UserRole userRoleDto = new CovidHealthcareApi.DTO.UserRole();
            userRoleDto = AutoMapper.Mapper.Map<UserRole, CovidHealthcareApi.DTO.UserRole>(userRole);

            userRoleCommandService.EditUserRole(userRoleDto);
        }

        public void DeleteUserRoleById(int id)
        {


            userRoleCommandService.DeleteUserRoleById(id);
        }

        public UserRole GetUserRoleById(int id)
        {

            var userRoleDto = userRoleQueryService.GetUserRoleById(id);
            UserRole userRole = new UserRole();

            userRole = Mapper.Map<CovidHealthcareApi.DTO.UserRole, UserRole>(userRoleDto);

            return userRole;
        }

        public string[] GetRolesForUser(string email)
        {
            string[] result = userRoleQueryService.GetRolesForUser(email);
            return result;
        }
    }
}