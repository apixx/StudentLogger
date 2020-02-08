using Microsoft.AspNetCore.Mvc;
using StudentLoggerApp.Models;
using StudentLoggerApp.Services.Interfaces;

namespace StudentLoggerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService activityService;

        public ActivityController(IActivityService activityService)
        {
            this.activityService = activityService;
        }

        [HttpGet]
        [Route("type")]
        public IActionResult GetByFilter(int? type)
        {
            if(type == null)
            {
                return BadRequest();
            }

            var activities = activityService.GetAllByType((int)type);

            return Ok(activities);
        }

        [HttpGet()]
        [Route("course")]
        public IActionResult GetByCourse(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var activities = activityService.GetByCourse((int)id);

            return Ok(activities);
        }

        [HttpGet()]
        [Route("student")]
        public IActionResult GetByStudent(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var activities = activityService.GetByStudent((int)id);

            return Ok(activities);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateActivity([FromBody] Activity activity)
        {
            if (activity == null)
            {
                return BadRequest();
            }

            var success = activityService.NewActivity(activity);

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
        [Route("update")]
        public IActionResult UpdateActivity([FromBody] Activity activity)
        {
            if (activity == null)
            {
                return BadRequest();
            }

            var success = activityService.UpdateActivity(activity);

            if (success)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("id")]
        [Route("")]
        public IActionResult DeleteActivity(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var success = activityService.DeleteActivity((int)id);

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