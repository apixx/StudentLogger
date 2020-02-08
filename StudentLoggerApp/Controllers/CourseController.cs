using Microsoft.AspNetCore.Mvc;
using StudentLoggerApp.Models;
using StudentLoggerApp.RequestModels;
using StudentLoggerApp.Services.Interfaces;

namespace StudentLoggerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var courses = courseService.GetAll();

            return Ok(courses);
        }

        [HttpGet("id")]
        [Route("")]
        public IActionResult GetCourse(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var course = courseService.Get((int)id);

            if (course == null)
                return NotFound();

            return Ok(course);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateCourse([FromBody] Course course)
        {
            if (course == null)
            {
                return BadRequest();
            }

            var newCourse = courseService.NewCourse(course);

            return Ok(newCourse);
        }

        [HttpPost]
        [Route("update")]
        public IActionResult UpdateCourse([FromBody] Course course)
        {
            if (course == null)
            {
                return BadRequest();
            }

            var updatedCourse = courseService.UpdateCourse(course);

            return Ok(updatedCourse);
        }

        [HttpDelete("id")]
        [Route("")]
        public IActionResult DeleteCourse(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var success = courseService.DeleteCourse((int)id);

            if (success)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("enrollone")]
        public IActionResult EnrollOneStudent([FromBody] EnrollSingleStudentModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            var success = courseService.EnrollStudent(model.StudentId, model.CourseId);

            if (success)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("enrollmultiple")]
        public IActionResult EnrollMultipleStudents([FromBody] EnrollMultipleStudentsModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            var success = courseService.EnrollStudents(model.StudentIds, model.CourseId);

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