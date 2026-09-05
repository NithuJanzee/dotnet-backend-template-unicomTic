using dotnet_backend_template_unicomTic.Entity;
namespace dotnet_backend_template_unicomTic.Interface.IRepositpory
{
    public interface IStudentRepository
    {
        Task<Student> AddStudent(Student student);
    }
}
