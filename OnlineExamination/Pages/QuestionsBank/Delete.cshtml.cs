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
    public class DeleteModel : PageModel
    {

        private readonly IManageQuestions manageQuestion;
        [BindProperty]
        public Question Question { get; set; }
        public DeleteModel(IManageQuestions _manageQuestion)
        {
            manageQuestion = _manageQuestion;
        }
        public IActionResult OnGet(int questionId)
        {
            Question = manageQuestion.GetQuestionById(questionId);
            if (Question == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(int questionId)
        {
            manageQuestion.deleteQuestion(questionId);
            return RedirectToPage("List");
        }
    }
}
