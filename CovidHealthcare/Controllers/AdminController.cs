using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CovidHealthcare.ControllerService;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IAdminControllerService adminControllerService;
        private readonly IAccountControllerService accountControllerService;
        public AdminController(IAdminControllerService adminControllerService, IAccountControllerService accountControllerService)
        {
            this.adminControllerService = adminControllerService;
            this.accountControllerService = accountControllerService;
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hospitals()
        {
            List<Hospital> hospitals = new List<Hospital>();
            hospitals = adminControllerService.GetHospitals();
            return View(hospitals);
        }


        public ActionResult ApproveHospital(int id)
        {
            RegisterViewModel user = new RegisterViewModel();
            user = adminControllerService.UserFromHospital(id);
            return View("Register", user);
        }
        [HttpPost]

        public ActionResult ApproveHospital(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                accountControllerService.CreateUser(registerViewModel);

                return RedirectToAction("Index", "Admin");
            }
            return View(registerViewModel);
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

                return RedirectToAction("Index", "Admin");
            }
            return View(registerViewModel);
        }
        public ActionResult DeleteHospital(int id)
        {
            Hospital hospital = new Hospital();
            hospital = adminControllerService.GetHospitalById(id);
            return View(hospital);
        }
        [HttpPost]

        public ActionResult DeleteHospital(Hospital hospital)
        {

            adminControllerService.DeleteHospitalById(hospital.Id);

            return RedirectToAction("Index", "Admin");

        }
    }
}