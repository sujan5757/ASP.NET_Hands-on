using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Models.Repository;
using System.Diagnostics;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentRepository _studentRepository = null;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository =new StudentRepository();
        }

        public  List<StudentModel> getAllStudents()
        {
            return _studentRepository.getAllStudents();
        }

        public StudentModel getStudent(int id)
        {
            return _studentRepository.getstudentById(id);
        }
        public IActionResult Index()
        {
            //var students = new List<StudentModel>
            //{
            //    new StudentModel { RollNo = 1, Name = "sujanps", Gender = "Male", Standard = 11 },
            //    new StudentModel { RollNo = 2, Name = "sujan", Gender = "Male", Standard = 11 },
            //    new StudentModel { RollNo = 3, Name = "suja", Gender = "Female", Standard = 12 },
            //    new StudentModel { RollNo = 4, Name = "suja", Gender = "Female", Standard = 12 },
            //    new StudentModel { RollNo = 5, Name = "suja", Gender = "Female", Standard = 12 }

            //};

            //// Corrected ViewData usage
            //ViewData["mystudent"] = students;

            //return View();
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
