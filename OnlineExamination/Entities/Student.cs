using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double examMark { get; set; } 
        public string examStatus { get; set; }
        public DateTime DOB { get; set; }
        public IList<StudentExam> StudentExams { get; set; }
        public IList<StudentQuestions> StudentQuestions { get; set; }
        public string ImagePath { get; set; }
    }
}
