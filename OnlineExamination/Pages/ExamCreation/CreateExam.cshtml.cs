using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Application.ManageExam;
using OnlineExamination.Data;
using OnlineExamination.Entities;

namespace OnlineExamination.Pages.ExamCreation
{
    [Authorize(Roles ="Manager")]
    public class CreateExamModel : PageModel
    {
        private readonly IManageExam manageExam;
        private readonly ApplicationDbContext context;
        
        [BindProperty]
        public Exam exam { get; set; }
        [BindProperty]
        public Student student { get; set; }

        [BindProperty]
        public int NomOfQuestions { get; set; }
        public CreateExamModel(IManageExam manageExam, ApplicationDbContext context)
        {
            this.manageExam = manageExam;
            this.context = context;
        }
        public void OnGet(int ExamId)
        {
            exam = manageExam.GetExamById(ExamId);
        }
        public IActionResult OnPost()
        {
            Random rnd = new Random();
            var questions = context.Questions.ToList().OrderBy(x => rnd.Next()).Take(NomOfQuestions).ToList();

            exam.ExamQuestions = questions.Select((q => new ExamQuestion
            {
                QuestionId = q.QuestionId,

            })).ToList();
            var students = context.Student.ToList();
            exam.StudentExams = students.Select(e => new StudentExam
            {
                StudentId = e.StudentId
            }).ToList();
            manageExam.AddNewExam(exam);

            return RedirectToPage();
        }
    }
}
