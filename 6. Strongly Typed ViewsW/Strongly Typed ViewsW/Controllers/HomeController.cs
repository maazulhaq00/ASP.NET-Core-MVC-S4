using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Strongly_Typed_ViewsW.Models;

namespace Strongly_Typed_ViewsW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayEmployee()
        {
            var emp = new Employee { EmpId = 1, EmpName = "Khalid", Designation = "Graphics Designer", Salary = 75000 };

            return View(emp);
        }
        public IActionResult DisplayEmployeeList()
        {

            var empList = new List<Employee>
            {
                new Employee { EmpId = 1, EmpName = "Khalid", Designation = "Graphics Designer", Salary = 75000 },
                new Employee { EmpId = 1, EmpName = "Ali", Designation = "PHP Developer", Salary = 85000 },
                new Employee { EmpId = 1, EmpName = "Sarah", Designation = "Website Developer", Salary = 65000 },
                new Employee { EmpId = 1, EmpName = "Zain", Designation = "Software Engineer", Salary = 95000 },
                new Employee { EmpId = 1, EmpName = "Fawad", Designation = "HR Officer", Salary = 55000 }

            };

            return View("DisplayEmployees", empList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
