using Microsoft.AspNetCore.Mvc;

namespace Week3.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
