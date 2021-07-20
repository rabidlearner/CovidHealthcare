using System.Web.Mvc;
using CovidHealthcare.ControllerService;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.Controllers
{
    public class HospitalsController : Controller
    {
        private readonly IHospitalControllerService controlService;
        public HospitalsController(IHospitalControllerService controlService)
        {
            this.controlService = controlService;
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
                controlService.CreateHospital(hospital);
                return Content("Succesfully registered");
            }
            return View(hospital);
        }
    }
}
