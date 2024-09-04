using Microsoft.AspNetCore.Mvc;

namespace C__MVC_S02_Demo02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
