using dotnet_backend_template_unicomTic.Dto.RequestDto;
using dotnet_backend_template_unicomTic.Interface.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_backend_template_unicomTic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;// SIHAN 
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentRequestDto studentRequestDto)
        { 
            var data = await _studentService.Addstudent(studentRequestDto);
            return Ok(data);
        }
            

    }
}
