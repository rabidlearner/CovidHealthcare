using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CovidHealthcare.ControllerService;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DoctorsController : Controller
    {
        private readonly IDoctorControllerService controllerService;
        public DoctorsController(IDoctorControllerService controllerService)
        {
            this.controllerService = controllerService;
        }
        public ActionResult Index()
        {
            List<Doctor> Doctors = new List<Doctor>();
            Doctors = controllerService.GetDoctors();
            return View(Doctors);
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

        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor Doctor = controllerService.GetDoctorById(id);
            if (Doctor == null)
            {
                return HttpNotFound();
            }
            return View(Doctor);
        }

        // POST: Doctors/Delete/1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            controllerService.DeleteDoctorById(id);

            return RedirectToAction("Index");
        }


    }
}
