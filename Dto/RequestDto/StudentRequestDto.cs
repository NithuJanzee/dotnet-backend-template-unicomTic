using System.ComponentModel.DataAnnotations;

namespace dotnet_backend_template_unicomTic.Dto.RequestDto
{
    public class StudentRequestDto
    {
        public string name { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string address { get; set; }
    }
}
