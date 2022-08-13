using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Jitin";
            int age = 21;
            ViewBag.name = name;
            TempData["name"] = name;
            ViewData["Age"] = age;
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Name = TempData["name"];
            return View();
        }
        public IActionResult Contact()
        {
            return View();  
        }
    }
}
