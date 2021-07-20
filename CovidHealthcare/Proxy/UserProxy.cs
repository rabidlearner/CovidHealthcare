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
    public class UserProxy : IUserProxy
    {
        private readonly IUserCommandService userCommandService;
        private readonly IUserQueryService userQueryService;
        public UserProxy(IUserCommandService userCommandService, IUserQueryService userQueryService)
        {
            this.userCommandService = userCommandService;
            this.userQueryService = userQueryService;
        }
        public void CreateUser(User user)
        {

            CovidHealthcareApi.DTO.User userDto = new CovidHealthcareApi.DTO.User();
            userDto = AutoMapper.Mapper.Map<User, CovidHealthcareApi.DTO.User>(user);

            userCommandService.CreateUser(userDto);
        }

        public List<User> GetAllUsers()
        {
            List<CovidHealthcareApi.DTO.User> userDtoList = new List<CovidHealthcareApi.DTO.User>();
            userDtoList = userQueryService.GetAllUsers();
            List<User> user = new List<User>();
            foreach (var userDto in userDtoList)
            {
                user.Add(Mapper.Map<CovidHealthcareApi.DTO.User, User>(userDto));
            }
            return user;

        }

        public void EditUser(User user)
        {

            CovidHealthcareApi.DTO.User userDto = new CovidHealthcareApi.DTO.User();
            userDto = AutoMapper.Mapper.Map<User, CovidHealthcareApi.DTO.User>(user);

            userCommandService.EditUser(userDto);
        }

        public void DeleteUserById(int id)
        {


            userCommandService.DeleteUserById(id);
        }

        public User GetUserById(int id)
        {

            var userDto = userQueryService.GetUserById(id);
            User user = new User();

            user = Mapper.Map<CovidHealthcareApi.DTO.User, User>(userDto);

            return user;
        }
    }
}