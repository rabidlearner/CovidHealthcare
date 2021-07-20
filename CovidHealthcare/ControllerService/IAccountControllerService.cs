using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CovidHealthcare.Models;




namespace CovidHealthcare.ControllerService
{
    public interface IAccountControllerService
    {
        ViewModel.RegisterViewModel Register();
        bool Login(ViewModel.LoginViewModel loginViewModel);
        void CreateUser(ViewModel.RegisterViewModel registerViewModel);
    }
}