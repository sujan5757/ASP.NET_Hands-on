

using FormUsingTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormUsingTagHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(Employee e)
        {
            return "Name : "+e.Name+"Gender :"+e.Gender+"Age :"+e.age+"Designation :" +e.designation+"Salary :"+e.salary+"Married :"+e.married+"Description: "+e.description;
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
