using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email  { get; set; }

    }
}
