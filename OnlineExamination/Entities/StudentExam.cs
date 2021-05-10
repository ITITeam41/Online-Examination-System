using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Entities
{
    public class StudentExam
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public Student Student { get; set; }
        public Exam Exam { get; set; }
    }
}
