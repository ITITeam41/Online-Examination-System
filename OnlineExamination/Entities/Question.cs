﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Answer { get; set; }
        public bool Status { get; set; }
        public IList<ExamQuestion> ExamQuestions { get; set; }
        public IList<StudentQuestions> StudentQuestions { get; set; }

    }
}
