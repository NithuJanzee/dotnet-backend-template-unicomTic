using dotnet_backend_template_unicomTic.DTO;
using dotnet_backend_template_unicomTic.Entity;
using dotnet_backend_template_unicomTic.Interface;

namespace dotnet_backend_template_unicomTic.Services
{
    public class CourseServices: ICourseServices
    {
        private readonly ICourseRepository _courseRepository;
        public CourseServices(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<Course> AddNewCourse(CourseRequestDTO request)
        {
            var course = new Course
            {
                name = request.name,
                duration = request.duration
            };

            var newCourse = await _courseRepository.AddNewCourse(course);

            return newCourse;
        }


        public async Task<List<Course>> GetAllCourses()
        {
            var courses = await _courseRepository.GetAllCourses();
            return courses;
        }
    }
}
 