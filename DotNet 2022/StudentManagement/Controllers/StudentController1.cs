using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    private readonly IConfiguration _configuration;
    public class StudentController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
