using dotnet_backend_template_unicomTic.DTO;
using dotnet_backend_template_unicomTic.Entity;

namespace dotnet_backend_template_unicomTic.Interface
{
    public interface ICourseServices
    {
        Task<Course> AddNewCourse(CourseRequestDTO request);
        Task<List<Course>> GetAllCourses();
    }
}
