using Microsoft.AspNetCore.Mvc;

namespace LabTask2.Controllers
{

    [Route("courses")]

    public class CourseController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Title = "Courses List";
            return View();
        }


        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            ViewBag.id = id;
            return View();
        }


        //courses/search?keyword=mvc 
        [Route("search")]
        public IActionResult Search(string keyword)
        {
            ViewBag.keyword = keyword;
            return View();
        }
    }
}
