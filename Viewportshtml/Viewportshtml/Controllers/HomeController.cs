using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Viewportshtml.Models;

namespace Viewportshtml.Controllers
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
            List<student> students = new List<student>()
            {
                new student { Id = 1, name = "Test", age=12 },
                 new student { Id = 2, name = "Test", age=12 },
                  new student { Id = 3, name = "Test", age=12 },
                   new student { Id = 4, name = "Test", age=12 },
            };
            return View(students);
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
