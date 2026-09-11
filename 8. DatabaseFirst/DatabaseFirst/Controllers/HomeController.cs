using System.Diagnostics;
using DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchoolDbContext _context;

        public HomeController(ILogger<HomeController> logger, SchoolDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var studentData = await _context.Students.ToListAsync();
            return View(studentData);
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                await _context.Students.AddAsync(student);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(student);

        }

        //public async Task<IActionResult> EditStudent(int id)
        //{
        //    var studentData = await _context.Students.ToListAsync();
        //    return View(studentData);
        //}
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if(student != null)
            {
                _context.Students.Remove(student);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
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
