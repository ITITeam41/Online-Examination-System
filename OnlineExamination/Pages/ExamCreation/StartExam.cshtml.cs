using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Application.ManageExam;
using OnlineExamination.Application.ManageQuestions;
using OnlineExamination.Application.ManageStudents;
using OnlineExamination.Data;
using OnlineExamination.Entities;

namespace OnlineExamination.Pages.ExamCreation
{
    public class StartExamModel : PageModel
    {
        private readonly IManageExam manageExam;
        private readonly IManageQuestions manageQuestions;
        private readonly IManageStudents manageStudents;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext context;

        [BindProperty]
        public string userEmail { get; set; }
        [BindProperty]
        public List<string> QuestionsAnswer { get; set; }
        public List<ExamQuestion> examQuestions { get; set; }
        [BindProperty]
        public List<Question> Questions { get; set; }

        public StartExamModel(IManageExam _manageExam,ApplicationDbContext context, 
            IManageQuestions manageQuestions, IManageStudents _manageStudents,
            UserManager<ApplicationUser> _userManager)
        {
            manageExam = _manageExam;
            this.context = context;
            this.manageQuestions = manageQuestions;
            manageStudents = _manageStudents;
            userManager = _userManager;
        }
        public async Task OnGetAsync()
        {

            examQuestions = manageExam.GetAllExamQuestions().ToList();
            Questions = examQuestions.Select(q => manageQuestions.GetQuestionById(q.QuestionId))
                .ToList();

            // userEmail = User.Identity.Name;
            ApplicationUser applicationUser = await userManager.GetUserAsync(User);
            userEmail = applicationUser?.Email; // will give the user's Email

        }
        public IActionResult OnPost(int examId)
        {
            //var mark = 5;
            var c = DateTime.Now;
            var exam = context.Exams.Where(x => x.ExamStart.Year == c.Year &&
                x.ExamStart.Month == c.Month && x.ExamStart.Day == c.Day
                && x.ExamStart.Hour == c.Hour
                && c.Minute - x.ExamStart.Minute <= x.Duration
                && c.Minute - x.ExamStart.Minute >= 0).SingleOrDefault();
            var mark = manageExam.GetMarkForEachQuestion(exam.ExamId);

            var Score = 0.0;
            for (int i = 0; i < Questions.Count; i++)
            {
                if (Questions[i].Answer == QuestionsAnswer[i])
                {
                    Score += mark;
                }
            }

            manageStudents.AssignStudentScore(userEmail, Score);

            return RedirectToPage("./ExamDegrees",new {result = Score });
        }
    }
}
