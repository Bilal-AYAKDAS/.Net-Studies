using Microsoft.AspNetCore.Mvc;
using Week4.Models;

namespace Week4.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            string name = "Bilal Ayakdaş";
            ViewBag.Name = name;

            User user2 = new User(3,"TestName", "TestSurname", "testusernameandtestsurname@gmail.com");
            ViewBag.Person = user2;

            List<User> users = new List<User>()
            {
                new User(1, "Bilal", "AYAKDAŞ", "bilalayakdas@gmail.com"),
                new User(2, "Furkan", "AYAKDAŞ", "furkanayakdas@gmail.com"),
                new User(3, "Enes","Akyol","enesakyol@gmail.com")
            };

            ViewBag.Persons = users;

            return View();
        }
    }
}
