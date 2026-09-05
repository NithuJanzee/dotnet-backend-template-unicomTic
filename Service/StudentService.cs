using dotnet_backend_template_unicomTic.Dto.RequestDto;
using dotnet_backend_template_unicomTic.Entity;
using dotnet_backend_template_unicomTic.Interface.IRepositpory;
using dotnet_backend_template_unicomTic.Interface.IService;

namespace dotnet_backend_template_unicomTic.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> Addstudent(StudentRequestDto requestDto)
        { 
            var requestDto1 = new Student
            {
                name = requestDto.name,
                email = requestDto.email,
                phone = requestDto.phone,
                address = requestDto.address
            };

            var data = await _studentRepository.AddStudent(requestDto1);
            return data;    


        }

        //Task<Student> IStudentService.AddStudent(Student student)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
