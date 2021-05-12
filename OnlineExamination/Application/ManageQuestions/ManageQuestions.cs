using OnlineExamination.Data;
using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Application.ManageQuestions
{
    public class ManageQuestions : IManageQuestions
    {
        private readonly ApplicationDbContext context;
        public ManageQuestions(ApplicationDbContext _context)
        {
            context = _context;
        }
        public void AddNewQuestion(Question question)
        {
            context.Questions.Add(question);
            context.SaveChanges();
        }

        public void deleteQuestion(int questionId)
        {
            var ques = GetQuestionById(questionId);
            if (ques != null)
            {
                context.Questions.Remove(ques);
                context.SaveChanges();
            }
        }

        public void EditQuestion(Question question)
        {
            var ques = GetQuestionById(question.QuestionId);
            if(ques != null)
            {
                ques.question = question.question;
                ques.Option1 = question.Option1;
                ques.Option2 = question.Option2;
                ques.Option3 = question.Option3;
                ques.Option4 = question.Option4;

                context.SaveChanges();
            }
        }

        public List<Question> GetAllQuestions()
        {
            return context.Questions.ToList();
        }

        public Question GetQuestionById(int questionId)
        {
            var question = context.Questions.SingleOrDefault(qus => qus.QuestionId == questionId);
            return question;
        }

        public List<Question> GetQuestionByName(string searchName)
        {
            var questions = context.Questions.Where(q => q.question.Contains(searchName)).ToList();
            return questions;
        }
    }
}
