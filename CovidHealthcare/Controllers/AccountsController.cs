using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.Mvc;
using CovidHealthcare.ControllerService;
using CovidHealthcare.ViewModel;
using CovidHealthcare.Proxy;
using System.Web.Security;

namespace CovidHealthcare.Controllers
{

    public class AccountsController : Controller
    {
        private readonly IAccountControllerService accountControllerService;

        public AccountsController(IAccountControllerService accountControllerService)
        {
            this.accountControllerService = accountControllerService;

        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                if (accountControllerService.Login(loginViewModel))
                {
                    FormsAuthentication.SetAuthCookie(loginViewModel.Email, false);
                    return RedirectToAction("Redirect", "Accounts");
                }
                return View(loginViewModel);
            }

            return View(loginViewModel);
        }
        public ActionResult Register()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            registerViewModel = accountControllerService.Register();
            return View(registerViewModel);
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                accountControllerService.CreateUser(registerViewModel);

                return RedirectToAction("Login");
            }
            return View(registerViewModel);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        public ActionResult Redirect()
        {
            if (User.IsInRole("Admin"))
            {
                RedirectToAction("Index", "Home");
            }
            else if (User.IsInRole("Hospital_Employee"))
            {
                RedirectToAction("Create", "Hospitals");
            }


            return Content("Sorry");

        }

    }
}