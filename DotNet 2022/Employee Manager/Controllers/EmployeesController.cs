using Employee_Manager.Data;
using Employee_Manager.Models;
using Employee_Manager.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Employee_Manager.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDbContext mvcDbContext; //Create field

        public EmployeesController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;   //Assign field
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //This will be the list that we will show to the user.
            //To show this list, we need to talk to the database to get all the employees that are stored in the databaes.

            var employees = await mvcDbContext.Employees.ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)   //Request-Parameter
        {
            var employee = new Employee()   //The entity or domain-model "employee" is ready.
            {
                Id = Convert.ToInt32(Guid.NewGuid()),
                //Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                Department = addEmployeeRequest.Department,
                DateOfBirth = addEmployeeRequest.DateOfBirth,
            };

            await mvcDbContext.Employees.AddAsync(employee);
            await mvcDbContext.SaveChangesAsync(); //This line will save the changes to the database. This line is a must to see the changes in the db.
            //return RedirectToAction("Add");
            //When it is successful, I want it redirect back to the Index page.
            return RedirectToAction("Index");


            //A DbContext instance represents a session with the database and
            //can be used to query and save instances of your entities. 
            //DbContext is a combination of the Unit Of Work and Repository patterns.
        }

        [HttpGet]
        public async Task<IActionResult> View(int id)
        //public async Task<IActionResult> View(Guid id)
        {
            var employee = await mvcDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employee != null)
            {
                var viewModel = new UpdateEmployeeViewModel()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email,
                    Salary = employee.Salary,
                    Department = employee.Department,
                    DateOfBirth = employee.DateOfBirth
                };
                return await Task.Run(() => View("View", viewModel));
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateEmployeeViewModel model)
        {
            var employee = await mvcDbContext.Employees.FindAsync(model.Id);

            if (employee != null)
            {
                employee.Name = model.Name;
                employee.Email = model.Email;
                employee.Salary = model.Salary;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Department = model.Department;

                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateEmployeeViewModel model)
        {
            var employe = await mvcDbContext.Employees.FindAsync(model.Id);

            if (employe != null)
            {
                mvcDbContext.Employees.Remove(employe);
                await mvcDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
