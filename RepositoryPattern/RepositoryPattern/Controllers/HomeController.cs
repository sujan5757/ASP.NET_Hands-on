using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using System.Diagnostics;

namespace RepositoryPattern.Controllers
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
            var students = new List<StudentModel>();
            {

                new StudentModel { rollno = 1, name = "sujanps", gender = "Male", standard = 11 };
                new StudentModel { rollno = 2, name = "sujan", gender = "Male", standard = 11 };
                new StudentModel { rollno = 3, name = "suja", gender = "Female", standard = 12 };
            };

            // Corrected ViewData usage
            ViewData["mystudent"] = students;
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
