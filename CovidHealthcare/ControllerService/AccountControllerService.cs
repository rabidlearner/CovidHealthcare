using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.ViewModel;
using CovidHealthcare.Proxy;
using System.Web.Mvc;

namespace CovidHealthcare.ControllerService
{
    public class AccountControllerService : IAccountControllerService
    {
        private readonly IUserProxy userProxy;
        private readonly IUserRoleProxy userRoleProxy;
        public AccountControllerService(IUserProxy userProxy, IUserRoleProxy userRoleProxy)
        {
            this.userProxy = userProxy;
            this.userRoleProxy = userRoleProxy;
        }
        public bool Login(LoginViewModel loginViewModel)
        {
            int flag = 0;
            var users = userProxy.GetAllUsers();
            foreach (var user in users)
            {
                if (user.Email == loginViewModel.Email && user.Password == loginViewModel.Password)
                {
                    flag = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }

            }
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreateUser(RegisterViewModel registerViewModel)
        {
            Models.User user = new Models.User()
            {
                Id = registerViewModel.Id,

                Email = registerViewModel.Email,

                Password = registerViewModel.Password,

                UserRoleId = registerViewModel.UserRoleId

            };

            userProxy.CreateUser(user);
        }

        public RegisterViewModel Register()
        {
            List<UserRole> userRoleView = new List<UserRole>();
            List<Models.UserRole> userRoles = new List<Models.UserRole>();
            ViewModel.User userView = new ViewModel.User();
            userRoles = userRoleProxy.GetAllUserRoles();
            //userView = AutoMapper.Mapper.Map<Models.User, ViewModel.User>(user);
            foreach (var userRole in userRoles)
            {
                userRoleView.Add(AutoMapper.Mapper.Map<Models.UserRole, ViewModel.UserRole>(userRole));
            }
            RegisterViewModel registerViewModel = new RegisterViewModel()
            {

                UserRole = userRoleView

            };
            return registerViewModel;

        }
    }
}