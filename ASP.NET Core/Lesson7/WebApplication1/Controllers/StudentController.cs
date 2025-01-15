using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student(){FirstName="Bilal",LastName="Ayakdaş"},
            new Student(){FirstName="Furkan", LastName="Ayakdaş" },
            new Student(){FirstName="Ayşe",LastName="Nuran" }
        };
        public IActionResult Index()
        {
            return View(students);
        }
    }
}
