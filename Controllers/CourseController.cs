using dotnet_backend_template_unicomTic.DTO;
using dotnet_backend_template_unicomTic.Entity;
using dotnet_backend_template_unicomTic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_backend_template_unicomTic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseServices _courseServices;
        public CourseController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCourse(CourseRequestDTO request)
        {
            var course = await _courseServices.AddNewCourse(request);

            return Ok(course);
        }

        [HttpGet("GetAllCourses")]
        public async Task<IActionResult> GetAllCourses()
        {
            var courses = await _courseServices.GetAllCourses();
            return Ok(courses);
        }
    }
}
