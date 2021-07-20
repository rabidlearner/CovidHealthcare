using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CovidHealthcare.ControllerService;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IDoctorControllerService controllerService;
        public DoctorsController(IDoctorControllerService controllerService)
        {
            this.controllerService = controllerService;
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Doctor Doctor)
        {
            if (ModelState.IsValid)
            {
                controllerService.CreateDoctor(Doctor);
                RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}
