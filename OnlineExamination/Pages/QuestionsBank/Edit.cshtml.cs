using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Entities;
using OnlineExamination.OnlineExam.Application.ManageQuestions;

namespace OnlineExamination.Pages.QuestionsBank
{
    public class EditModel : PageModel
    {
        private readonly IManageQuestions manageQuestion;
        [BindProperty]
        public Question Question { get; set; }
        public EditModel(IManageQuestions _manageQuestion)
        {
            manageQuestion = _manageQuestion;
        }
        public void OnGet(int questionId)
        {
            Question = manageQuestion.GetQuestionById(questionId);

            if (Question == null)
            {
                Question = new Question();
            }
        }
        public IActionResult OnPost()
        {
            if (Question.QuestionId == 0)
            {
                manageQuestion.AddNewQuestion(Question);
                return RedirectToPage("List");
            }
            else
            {
                manageQuestion.EditQuestion(Question);
                return RedirectToPage("List");
            }
        }
    }
}
