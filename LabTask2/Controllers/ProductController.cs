using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

namespace LabTask2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(string category,int id)
        {
            ViewBag.category = category;
            ViewBag.id = id;
            return View();
        }
    }
}

