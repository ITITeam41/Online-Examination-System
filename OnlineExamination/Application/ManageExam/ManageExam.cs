using Microsoft.EntityFrameworkCore;
using OnlineExamination.Data;
using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Application.ManageExam
{
    public class ManageExam : IManageExam
    {
        private readonly ApplicationDbContext context;
        public ManageExam(ApplicationDbContext _context)
        {
            context = _context;
        }
        // Just for Test
        //List<Question> questions = new List<Question>()
        //{
        //    new Question(){QuestionId = 1,question = "1- Bootsrap is : ", Option1 = "library", Option2 = "framework", Option3 ="Programming Lanaguge", Option4 = "All", Answer = "framework"},
        //    new Question(){QuestionId = 2,question = "2- Bootsrap is : ", Option1 = "library", Option2 = "framework", Option3 ="Programming Lanaguge", Option4 = "All", Answer = "framework"},
        //    new Question(){QuestionId = 3,question = "3- Bootsrap is : ", Option1 = "library", Option2 = "framework", Option3 ="Programming Lanaguge", Option4 = "All", Answer = "framework"},
        //    new Question(){QuestionId = 4,question = "4- Bootsrap is : ", Option1 = "library", Option2 = "framework", Option3 ="Programming Lanaguge", Option4 = "All", Answer = "framework"},
        //    new Question(){QuestionId = 5,question = "5- Bootsrap is : ", Option1 = "library", Option2 = "framework", Option3 ="Programming Lanaguge", Option4 = "All", Answer = "framework"},
        //};
        public void AddNewExam(Exam exam)
        {
            context.Exams.Add(exam);
            context.SaveChanges();
        }

        public void deleteExam(int questionId)
        {
            throw new NotImplementedException();
        }

        public void EditExam(Exam exam)
        {
            throw new NotImplementedException();
        }
        public List<ExamQuestion> GetAllExamQuestions()
        {
            var c = DateTime.Now;
            var examQuestions = context.Exams
                .Include(e => e.ExamQuestions)
                .Where(x => x.ExamStart.Year == c.Year &&
                x.ExamStart.Month == c.Month && x.ExamStart.Day == c.Day
                && x.ExamStart.Hour == c.Hour
                && c.Minute - x.ExamStart.Minute <= x.Duration
                && c.Minute - x.ExamStart.Minute >= 0)
                .Select(q => q.ExamQuestions).SingleOrDefault().ToList();
            return examQuestions;
        }

        public List<Exam> GetAllExams()
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAllQuestions()
        {
            throw new NotImplementedException();
        }
        public Exam GetExamById(int examId)
        {
            var exam = context.Exams.Include(e=>e.ExamQuestions).SingleOrDefault(e => e.ExamId == examId);
            return exam;
        }

        public List<Exam> GetExamByName(string searchName)
        {
            throw new NotImplementedException();
        }
        public double GetMarkForEachQuestion(int examId)
        {
            var exam = context.Exams.Include(e=>e.ExamQuestions).SingleOrDefault(e => e.ExamId == examId);
            double ExamTotolMark = exam.totalMark;
            var NumberOfQuestions = exam.ExamQuestions.Count;
            double QuestionMark = ExamTotolMark / NumberOfQuestions;
            return QuestionMark;
        }
    }
}
