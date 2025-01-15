using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext db;

        public StudentController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            List<Student> students = db.Students.ToList();

            return View(students);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(addStudentView std)
        {
            var student = new Student()
            {
                Name= std.Name,
                Phone= std.Phone,
                Email= std.Email,
                Address= std.Address,
            };
            await db.Students.AddAsync(student);
            await db.SaveChangesAsync();
            return View();
        }
    }
}
