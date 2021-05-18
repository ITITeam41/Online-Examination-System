using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineExamination.Pages.ExamCreation
{
    public class ExamDegreesModel : PageModel
    {
        public List<Result> StudentResults { get; set; }

        public double studentDegree { get; set; }
        public double examMark { get; set; }
        public double passMark { get; set; }

        public IActionResult OnGetAsync(double result , double ExamMark,double PassMark)
        {
            passMark = PassMark;
            examMark = ExamMark;
            studentDegree = result;
            StudentResults = new List<Result>();
            return Page();
        }
    }
    public class Result
    {
        public int StudentScore { get; set; } = 5;
        public DateTime ExamDate { get; set; } = DateTime.Now;
        public string ExamName { get; set; } = "C#";
    }
}
