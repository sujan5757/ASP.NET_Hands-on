using Microsoft.AspNetCore.Mvc;
using PassingModelData.Models;
using System.Diagnostics;

namespace PassingModelData.Controllers
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
            //Employee employee = new Employee()
            //{
            //    empid = 1,
            //    empname = "Test",
            //    designation="Maneger",
            //    salary=25000
            //};


            //ViewData["myemployee"] = employee;//view data

            //ViewBag.myemployee = employee;//view bag

            //TempData["myemployee"] = employee;//tempdata


            var myemp = new List<Employee>()
            {
                new Employee { empid = 1, empname = "Test1", designation = "HR", salary = 34000 },
                new Employee { empid = 2, empname = "Test2", designation = "HR", salary = 34000 },
                new Employee { empid = 3, empname = "Test3", designation = "HR", salary = 34000 },
                new Employee { empid = 4, empname = "Test4", designation = "HR", salary = 34000 }

            };

            ViewData["myemployee"] = myemp;
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
