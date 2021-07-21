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
                    FormsAuthentication.SetAuthCookie(loginViewModel.Email, true);
                    Session["UserEmail"] = loginViewModel.Email;
                    return RedirectToAction("Redirect");
                }
                return View(loginViewModel);
            }

            return View(loginViewModel);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Redirect()
        {
            string userEmail = Session["UserEmail"].ToString();
            WebRoleProvider roleProvider = new WebRoleProvider();
            if (roleProvider.IsUserInRole(userEmail, "Admin"))
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (roleProvider.IsUserInRole(userEmail, "Hospital_Employee"))
            {
                return RedirectToAction("Create", "Hospitals");
            }

            return Content("You do not have the correct permission to see this page.");

        }

    }
}