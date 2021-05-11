using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Entities
{
    public class StudentQuestions
    {
        public int StudentId { get; set; }
        public int QuestionId { get; set; }
        public Student Student { get; set; }
        public Question Question { get; set; }
    }
}
