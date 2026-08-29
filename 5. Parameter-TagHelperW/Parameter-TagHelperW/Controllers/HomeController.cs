using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Parameter_TagHelperW.Models;

namespace Parameter_TagHelperW.Controllers
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
        public IActionResult Product(int id, string name, int price)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            ViewBag.price = price;
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
