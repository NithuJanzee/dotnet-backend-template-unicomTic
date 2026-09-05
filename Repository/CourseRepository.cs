using dotnet_backend_template_unicomTic.ApplicationDbContext;
using dotnet_backend_template_unicomTic.Entity;
using dotnet_backend_template_unicomTic.Interface;
using Microsoft.EntityFrameworkCore;

namespace dotnet_backend_template_unicomTic.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private readonly AppDbContext _dbcontext;
        public CourseRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Course> AddNewCourse(Course course)
        {
            _dbcontext.course.Add(course);
            await _dbcontext.SaveChangesAsync();
            return course;
        }

        public async Task<List<Course>> GetAllCourses()
        {
            return await _dbcontext.course.ToListAsync();
        }
    }
}
 