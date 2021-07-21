using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using CovidHealthcare.Proxy;
using CovidHealthcareApi.Repository.Context;
using CovidHealthcareApi.Repository.Entity;

namespace CovidHealthcare
{
    public class WebRoleProvider : RoleProvider
    {
        private readonly IUserRoleProxy proxy;
        public WebRoleProvider()
        {

        }
        public WebRoleProvider(IUserRoleProxy proxy)
        {
            this.proxy = proxy;
        }
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                var result = (from user in dbContext.Users
                              join roles in dbContext.UserRoles
                              on user.UserRoleId equals roles.Id
                              where user.Email == username
                              select roles.Role).ToArray();
                return result;
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {

            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                var result = (from user in dbContext.Users
                              join roles in dbContext.UserRoles
                              on user.UserRoleId equals roles.Id
                              where user.Email == username
                              select roles.Role).ToArray();
                if (result[0] == roleName)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}