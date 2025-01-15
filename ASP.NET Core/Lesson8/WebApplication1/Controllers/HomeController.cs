using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page1()
        {
            return View();
        }

        public IActionResult Page2()
        {
            return View();
        }

        public IActionResult LoginAsStudent()
        {
            return View();
        }

        public IActionResult LoginAsTeacher()
        {
            return View();
        }
    }
}
