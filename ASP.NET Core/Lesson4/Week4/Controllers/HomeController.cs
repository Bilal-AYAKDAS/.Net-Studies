using Microsoft.AspNetCore.Mvc;
using Week4.Models;

namespace Week4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Bilal";
            return View(name as Object);
        }

        public IActionResult Index1()
        {
            User user = new User(1, "Bilal", "AYAKDAŞ", "bilalayakdas@gmail.com");
            return View(user);
        }

        public IActionResult Index2() 
        {
            List <User> users = new List<User>() 
            {
                new User(1, "Bilal", "AYAKDAŞ", "bilalayakdas@gmail.com"),
                new User(2, "Furkan", "AYAKDAŞ", "furkanayakdas@gmail.com"),
                new User(3, "Enes","Akyol","enesakyol@gmail.com")
            };
            return View(users);
        
        }
    }
}
