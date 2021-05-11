using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Entities;
using OnlineExamination.OnlineExam.Application.ManageQuestions;

namespace OnlineExamination.Pages.QuestionsBank
{
    [Authorize(Roles = "Manager")]
    public class ListModel : PageModel
    {
        private readonly IManageQuestions manageQuestion;
        public List<Question> Questions { get; set; }
        public ListModel(IManageQuestions _manageQuestions)
        {
            manageQuestion = _manageQuestions;
        }
        public void OnGet()
        {
            Questions = manageQuestion.GetAllQuestions();
        }
    }
}
