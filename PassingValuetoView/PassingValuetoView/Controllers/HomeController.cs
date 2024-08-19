using Microsoft.AspNetCore.Mvc;

namespace PassingValuetoView.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController

        //ViewData 
        public ActionResult Index()
        {
            //ViewData["data1"] = "SujanPS";
            //ViewData["data2"] = 25;
            //ViewData["data3"] = DateTime.Now.ToLongDateString;

            //string[] arr = { "kumar", "Prem", "Zain" };
            //ViewData["data"] = arr;
            //ViewData["data5"] = new List<string>()
            //{
            //    "Cricket","Football","Hockey"
            //};
            ViewData["data1"] = "SujanPS";
            ViewBag.data2 = "SujanPS2";
            TempData["data3"] = "Temp Data";

            return View();
        }

        //ViewBag Used Here
        public ActionResult About()
        {
            ViewBag.data1 = "SujanPS";
            ViewBag.data2 = 24;
            ViewBag.data3 = DateTime.Now.ToShortDateString();

            string[] arr = { "kumar", "Prem", "Zain" };
            ViewBag["data"] = arr;

            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

    }
}
