using Microsoft.AspNetCore.Mvc;
using RoutingwithMVC.Models;
using System.Diagnostics;

namespace RoutingwithMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("Index/Privacy/{id?}")]

        [Route("Index/Privacy")]
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
