using dotnet_backend_template_unicomTic.ApplicationDbContext;
using dotnet_backend_template_unicomTic.Entity;
using dotnet_backend_template_unicomTic.Interface.IRepositpory;
using System.Drawing.Text;

namespace dotnet_backend_template_unicomTic.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _dbContext;
        public StudentRepository(AppDbContext addDbContext)
        {
            _dbContext = addDbContext;

        }

        public async Task<Student> AddStudent(Student student) 
        { 
            var data = await _dbContext.student.AddAsync(student);
            await _dbContext.SaveChangesAsync();
            return data.Entity;
        }

    }
}
