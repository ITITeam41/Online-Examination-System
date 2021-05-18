using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Application.ManageStudents;

namespace OnlineExamination.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly IManageStudents manageStudents;
        public StudentDTO Student { get; set; }
        public DetailsModel(IManageStudents _manageStudents)
        {
            manageStudents = _manageStudents;
        }
        public IActionResult OnGet(int studentId) 
        {
            Student = manageStudents.GetStudentById(studentId);
            if (Student == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
