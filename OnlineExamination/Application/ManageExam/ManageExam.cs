using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Application.ManageExam
{
    public class ManageExam : IManageExam
    {
        public void AddNewQuestion(Exam exam)
        {
            throw new NotImplementedException();
        }

        public void deleteQuestion(int questionId)
        {
            throw new NotImplementedException();
        }

        public void EditQuestion(Exam exam)
        {
            throw new NotImplementedException();
        }

        public List<Exam> GetAllQuestions()
        {
            throw new NotImplementedException();
        }

        public Exam GetQuestionById(int questionId)
        {
            throw new NotImplementedException();
        }

        public List<Exam> GetQuestionByName(string searchName)
        {
            throw new NotImplementedException();
        }
    }
}
