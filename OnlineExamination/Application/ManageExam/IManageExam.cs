using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Application.ManageExam
{
    public interface IManageExam
    {
        List<Exam> GetAllQuestions();
        Exam GetQuestionById(int questionId);
        List<Exam> GetQuestionByName(string searchName);
        void EditQuestion(Exam exam);
        void deleteQuestion(int questionId);
        void AddNewQuestion(Exam exam);
    }
}
