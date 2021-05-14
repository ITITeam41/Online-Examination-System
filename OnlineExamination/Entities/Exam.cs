using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Entities
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string Name { get; set; }
        public int passMark { get; set; }
        public double Result { get; set; }
        public int totalMark { get; set; }
        public double Duration { get; set; }
        public bool Status { get; set; }
        public DateTime ExamStart { get; set; }
        public IList<ExamQuestion> ExamQuestions { get; set; }
        public IList<StudentExam> StudentExams { get; set; }


    }
}
