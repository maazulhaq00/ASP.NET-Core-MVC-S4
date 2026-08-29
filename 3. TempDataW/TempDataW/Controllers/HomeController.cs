using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TempDataW.Models;

namespace TempDataW.Controllers
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
            ViewData["data1"] = "View Data";
            ViewBag.data2 = "View Bag";
            TempData["data3"] = "Temp Data";

            TempData.Keep();

            //return RedirectToAction("About");

            return View();
        }
        public IActionResult About()
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
