using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Application.ManageQuestions
{
    public interface IManageQuestions
    {
        List<Question> GetAllQuestions();
        Question GetQuestionById(int questionId);
        List<Question> GetQuestionByName(string searchName);
        void EditQuestion(Question question);
        void deleteQuestion(int questionId);
        void AddNewQuestion(Question question);
    }
}
