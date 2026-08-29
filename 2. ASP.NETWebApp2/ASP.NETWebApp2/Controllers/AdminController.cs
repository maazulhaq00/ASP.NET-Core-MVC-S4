using Microsoft.AspNetCore.Mvc;

namespace ASP.NETWebApp2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProduct()
        {
            return View();
        }
    }
}
