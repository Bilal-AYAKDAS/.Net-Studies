using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models.Dto;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public StudentController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var query = dbContext.Students.ToList();
            return Ok(query);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetStudentById(int id)
        {
            var query = dbContext.Students.Find(id);
            return Ok(query);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] AddStudentDto studentDto)
        {
            Student student = new Student
            {
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                Email = studentDto.Email
            };

            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            return Ok(student);
        }
    }
}
