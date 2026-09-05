using dotnet_backend_template_unicomTic.Entity;

namespace dotnet_backend_template_unicomTic.Interface
{
    public interface ICourseRepository
    {
        Task<Course> AddNewCourse(Course course);
        Task<List<Course>> GetAllCourses();
    }
}
