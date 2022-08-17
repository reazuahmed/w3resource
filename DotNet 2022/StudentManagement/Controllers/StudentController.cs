using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IStudentServices _studentServices;

        public StudentController(IConfiguration configuration, IStudentServices studentServices)
        {
            _configuration = configuration;
            _studentServices = studentServices;
        }

        public IActionResult Index()
        {
            StudentVM model = new StudentVM();
            model.StudentsList = _studentServices.GetStudentList().ToList();
            return View();
        }
    }
}
