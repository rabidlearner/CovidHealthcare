using System.Web.Mvc;
using CovidHealthcare.ControllerService;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.Controllers
{
    public class HospitalsController : Controller
    {
        private readonly IHospitalControllerService hospitalControllerService;
        public HospitalsController(IHospitalControllerService hospitalControllerService)
        {
            this.hospitalControllerService = hospitalControllerService;
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hospital hospital)
        {
            if (ModelState.IsValid)
            {
                if (hospitalControllerService.IsInDatabase(hospital.Email))
                {
                    return Content("Email has been pre-registered");
                }
                hospitalControllerService.CreateHospital(hospital);
                return Content("Registration success!");
            }
            return View(hospital);
        }
    }
}
