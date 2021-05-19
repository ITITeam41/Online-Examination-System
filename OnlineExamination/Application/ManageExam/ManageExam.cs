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
            List<ExamQuestion> examQuestions = null;

            try
            {
                examQuestions = context.Exams
                .Include(e => e.ExamQuestions)
                .Where(x => x.ExamStart.Year == c.Year &&
                x.ExamStart.Month == c.Month && x.ExamStart.Day == c.Day
                && x.ExamStart.Hour == c.Hour
                && c.Minute - x.ExamStart.Minute <= x.Duration
                && c.Minute - x.ExamStart.Minute >= 0)
                .Select(q => q.ExamQuestions).SingleOrDefault().ToList();
            }
            catch (Exception)
            {
                examQuestions = new List<ExamQuestion>();
            }
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

        public Exam GetCurrentExam()
        {
            var c = DateTime.Now;
            var exam = context.Exams.Where(x => x.ExamStart.Year == c.Year &&
                x.ExamStart.Month == c.Month && x.ExamStart.Day == c.Day
                && x.ExamStart.Hour == c.Hour
                && c.Minute - x.ExamStart.Minute <= x.Duration
                && c.Minute - x.ExamStart.Minute >= 0).SingleOrDefault();
            return exam;
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
