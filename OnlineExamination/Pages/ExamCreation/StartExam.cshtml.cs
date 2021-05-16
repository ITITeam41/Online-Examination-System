using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Application.ManageExam;
using OnlineExamination.Entities;

namespace OnlineExamination.Pages.ExamCreation
{
    public class StartExamModel : PageModel
    {
        private readonly IManageExam manageExam;
        public List<Question> ExamQuestions { get; set; }
        public StartExamModel(IManageExam _manageExam)
        {
            manageExam = _manageExam;
        }
        public void OnGet()
        {
            ExamQuestions = manageExam.GetAllQuestions();
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("./ExamDegrees");
        }
    }
}
