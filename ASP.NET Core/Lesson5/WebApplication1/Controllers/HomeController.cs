using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        List<User> users = new List<User>
        {
            new User(){ID=1,Name ="TestName1",Surname="TestSurName1"},
            new User(){ID=2,Name ="TestName2",Surname="TestSurName2"},
            new User(){ID=3,Name ="TestName3",Surname="TestSurName2"}
        };

        public IActionResult Index()
        {
            string name = "Bilal";
            ViewData["name"] = name;

            User user = new User();
            user.ID = 1;
            user.Name = "Bilal";
            user.Surname = "AYAKDAŞ";
            ViewData["User"] = user;

            ViewData["users"] = users;
            return View();
        }



        public IActionResult useTempData()
        {
            TempData["name"] = "Bilal";
            return RedirectToAction("useTempData2");
        }

        public IActionResult useTempData2()
        {
            TempData.Keep("name");
            string firstName = TempData["name"].ToString();
            TempData["name"] = "Bilal";
            return View(firstName as object);

        }

        public IActionResult ViewModel()
        {
            // user
            // user list 
            // date
            UserListDate data = new UserListDate
            {
                user = new User
                {
                    ID = 1,
                    Name = "TestName1",
                    Surname = "TestSurname1"
                },
                users = users,
                Date = DateTime.Now.ToString()
            };
            return View(data);
        }
        
    }
}
