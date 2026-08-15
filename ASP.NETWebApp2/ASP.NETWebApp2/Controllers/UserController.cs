using Microsoft.AspNetCore.Mvc;

namespace ASP.NETWebApp2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }
        public IActionResult About()
        {
            return View();
        }
    }
}

