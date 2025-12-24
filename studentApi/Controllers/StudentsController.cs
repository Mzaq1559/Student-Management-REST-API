using Microsoft.AspNetCore.Mvc;
using studentApi.Models;

namespace studentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ali", Age = 20, Department = "CS" },
            new Student { Id = 2, Name = "Sara", Age = 21, Department = "IT" }
        };

        [HttpGet]
        public ActionResult<List<Student>> GetStudents() => Ok(students);

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return student is null ? NotFound() : Ok(student);
        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            students.Add(student);
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }
    }
}
