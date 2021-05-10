using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Entities
{
    public class CourseExam
    {
        public int CourseId { get; set; }
        public int ExamId { get; set; }
        public Course Course  { get; set; }
        public Exam Exam { get; set; }

    }
}
