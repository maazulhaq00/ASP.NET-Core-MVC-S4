using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelForm.Models;

namespace ModelForm.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        //public IActionResult ShowCategory(string CategoryName, string CategoryDesc, int ProductCount)
        //{
        //    //return $"Category Name: {CategoryName}\n" +
        //    //    $"Catgeory Des: {CategoryDesc}\n " +
        //    //    $"Product Count {ProductCount}";

        //    ViewBag.CategoryName = CategoryName;
        //    ViewBag.CategoryDesc = CategoryDesc;
        //    ViewBag.ProductCount = ProductCount;

        //    return View();
        //}

        public IActionResult ShowCategory(CategoryModel category)
        {
            return View(category);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
