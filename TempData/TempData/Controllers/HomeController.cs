using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TempData.Models;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index1()
        {
            //ViewData["data1"] = "View Data";
            //ViewBag.data2 = "View Bag";
            //TempData["data3"] = "Temp Data";

            //TempData.Keep();

            //return RedirectToAction("About");

            var student = new StudentModel { rollNo = 1, Name = "Saad", 
                Gender = "Male", Standard = 11 };

            ViewData["student"] = student;

            var studentList = new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Saad", Gender = "Male", Standard = 11 },
                new StudentModel { rollNo = 2, Name = "Fawad", Gender = "Male", Standard = 10 },
                new StudentModel { rollNo = 3, Name = "Ambreen", Gender = "Female", Standard = 12 }
            };

            ViewData["studentList"] = studentList;

            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DisplayEmployees()
        {

            //var emp = new Employee { EmpId = 1, EmpName = "Khalid", Designation = "Graphics Designer", Salary = 75000 };

            var empList = new List<Employee> 
            {
                new Employee { EmpId = 1, EmpName = "Khalid", Designation = "Graphics Designer", Salary = 75000 },
                new Employee { EmpId = 1, EmpName = "Ali", Designation = "PHP Developer", Salary = 85000 },
                new Employee { EmpId = 1, EmpName = "Sarah", Designation = "Website Developer", Salary = 65000 },
                new Employee { EmpId = 1, EmpName = "Zain", Designation = "Software Engineer", Salary = 95000 },
                new Employee { EmpId = 1, EmpName = "Fawad", Designation = "HR Officer", Salary = 55000 }

            };

            return View(empList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
