using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;
using System.Diagnostics;

namespace ModelValidation.Controllers
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
        [HttpPost]
        //public string Index(student std)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //        //return "Name is: " + std.name;
        //    //}
        //    //else
        //    //{
        //    //    return "Validation failed";
        //    //}
        //}

        public IActionResult Index(student std)
        {
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
