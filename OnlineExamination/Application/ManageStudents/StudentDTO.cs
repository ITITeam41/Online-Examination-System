using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Application.ManageStudents
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public double examMark { get; set; } = 15.5; // Set default value for test
        public string examStatus { get; set; } = "Passed"; // Set default value for test
        public string ImagePath { get; set; }
    }
    public class StudentDTOList
    {
        public List<StudentDTO> Students { get; set; }
        public int StudentsCount { get; set; }
    }
}
