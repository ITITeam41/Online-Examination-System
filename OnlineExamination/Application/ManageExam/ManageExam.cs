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

        public List<Exam> GetAllExams()
        {
            throw new NotImplementedException();
        }

        public List<Exam> GetAllQuestions()
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
    }
}
