using dotnet_backend_template_unicomTic.Dto.RequestDto;     
using dotnet_backend_template_unicomTic.Entity; 

namespace dotnet_backend_template_unicomTic.Interface.IService
{
    public interface IStudentService
    {
        //Task<Student> AddStudent(Student student);
        Task<Student> Addstudent(StudentRequestDto requestDto);
    }
}
