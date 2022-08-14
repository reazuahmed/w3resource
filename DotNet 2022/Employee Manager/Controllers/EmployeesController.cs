using Microsoft.AspNetCore.Mvc;

namespace Employee_Manager.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
