using Microsoft.AspNetCore.Mvc; //parent class

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller //child class
    {
        public IActionResult Index()
        {
            return View();
            //view result //partialview result //jsonresult 
        }
    }
}
