using Microsoft.AspNetCore.Mvc;
using StronglyTypedView.Models;
using System.Diagnostics;

namespace StronglyTypedView.Controllers
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
            //    empid= 1,
            //    empname="tes",
            //    designation="hr",
            //    salary=10000
            //};
            var employee = new List<Employee>()
            {
            new Employee { empid = 1, empname = "Test", designation = "HR", salary = 34000 },
            new Employee { empid = 2, empname = "Test", designation = "HR", salary = 34000 },
            new Employee { empid = 3, empname = "Test", designation = "HR", salary = 34000 },


            };

            return View(employee);
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
