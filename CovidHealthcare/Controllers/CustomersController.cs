using System.Linq;
using System.Web.Mvc;
using CovidHealthcare.ControllerService;
using CovidHealthcare.ViewModel;

namespace CovidHealthcare.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerControllerService controllerService;
        public CustomersController(ICustomerControllerService controllerService)
        {
            this.controllerService = controllerService;
        }
        public ActionResult Create()
        {
            Customer customer = controllerService.Create();
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                controllerService.CreateCustomer(customer);
                ViewBag.result = "Registration is a success";
            }
            return View(customer);
        }
    }
}
