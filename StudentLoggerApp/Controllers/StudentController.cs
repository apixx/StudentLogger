using Microsoft.AspNetCore.Mvc;
using StudentLoggerApp.Models;
using StudentLoggerApp.Services.Interfaces;

namespace StudentLoggerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var students = studentService.GetAllStudents();

            return Ok(students);
        }

        [HttpGet("id")]
        [Route("")]
        public IActionResult GetStudent(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var student = studentService.GetStudent((int)id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }

            var newStudent = studentService.NewStudent(student);

            return Ok(newStudent);
        }

        [HttpPost]
        [Route("update")]
        public IActionResult UpdateStudent([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }

            var updatedStudent = studentService.UpdateStudent(student);

            return Ok(updatedStudent);
        }

        [HttpDelete("id")]
        [Route("")]
        public IActionResult DeleteStudent( int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var success = studentService.DeleteStudent((int) id);

            if (success)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500);
            }

        }
    }
}