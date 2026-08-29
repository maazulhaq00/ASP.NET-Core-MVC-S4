using Microsoft.AspNetCore.Mvc;
using ModelW.Models;
using System.Diagnostics;

namespace ModelW.Controllers
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
            var student = new StudentModel
            {
                rollNo = 1,
                Name = "Saad",
                Gender = "Male",
                Standard = 11
            };

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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
