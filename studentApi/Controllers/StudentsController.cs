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
    }
}
