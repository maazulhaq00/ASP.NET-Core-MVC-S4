using System.Diagnostics;
using DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchoolDbContext _context;
        IWebHostEnvironment env;
        public HomeController(ILogger<HomeController> logger, SchoolDbContext context, IWebHostEnvironment env)
        {
            _logger = logger;
            _context = context;
            this.env = env;
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
        public async Task<IActionResult> AddStudent(StudentViewModel student)
        {

            if(ModelState.IsValid)
            {
                string fileName = "";

                if(student.StudentImage != null)
                {
                    string folderName = Path.Combine(env.WebRootPath, "images");
                    fileName = Guid.NewGuid().ToString() + "_" + student.StudentImage.FileName;
                    string filePath = Path.Combine(folderName, fileName);

                    student.StudentImage.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Student s1 = new Student
                {
                    StudentName = student.StudentName,
                    StudentAge = student.StudentAge,
                    StudentEmail = student.StudentEmail,
                    StudentImage = fileName
                };

                await _context.Students.AddAsync(s1);
                await _context.SaveChangesAsync();

                TempData["success_message"] = "Record inserted successfully";

                return RedirectToAction("Index");
            }
            return View(student);
        }

        public async Task<IActionResult> EditStudent(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }
            var student = await _context.Students.FindAsync(id);
            
            if (student == null)
            {
                return NotFound();
            }

            return View(student);


        }

        [HttpPost]
        public async Task<IActionResult> EditStudent(int? id, Student student)
        {
            if(id != student.StudentId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                await _context.SaveChangesAsync();

                TempData["success_message"] = "Record updated successfully";

                return RedirectToAction("Index");
            }

            return View(student);
        }
        public async Task<IActionResult> DeleteStudent(int? id)
        {
            var student = await _context.Students.FindAsync(id);

            if(student != null)
            {
                _context.Students.Remove(student);

                TempData["success_message"] = "Record deleted successfully";

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
