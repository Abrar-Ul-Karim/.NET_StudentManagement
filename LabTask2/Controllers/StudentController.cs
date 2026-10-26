
using Microsoft.AspNetCore.Mvc;
using LabTask2.Models;
using System.Collections.Generic;

namespace LabTask2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Students List";
            ViewData["subtitle"] = "Enrolled students this semester";

            var students = new List<string>
            {
                "Abrar", "Ul", "Karim"
            };

            return View(students);
        }




        public IActionResult Registration()
        {
            return View(new StudentModel());
        }


        [HttpPost]
        public IActionResult Registration(StudentModel model)
        {

            return View(model);
        }
    }
}


