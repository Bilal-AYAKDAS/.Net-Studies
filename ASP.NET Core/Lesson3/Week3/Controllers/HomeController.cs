using Microsoft.AspNetCore.Mvc;
using Week3.Models;

namespace Week3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";
            customer.Surname = "Doe";

            return View();
        }

        [NonAction]
        public string customerFullName(Customer customer) {

            return customer.Name + " " + customer.Surname;
        }

        public IActionResult Index1()
        {
            return View();
        }

        public string Index2()
        {
            return "Hello from Home Controller";
        }

        public string Index3()
        {
            return "Hello from Index3";
        }
    }
}
