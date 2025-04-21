using Microsoft.AspNetCore.Mvc;
using studentApi.Models;
namespace studentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new List<Student>();

        [HttpGet]
        public ActionResult<List<Student>> GetStudents() => Ok(students);

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return student is null ? NotFound() : Ok(student);
        }
    }
}
