using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Application.ManageStudents;
using OnlineExamination.Entities;

namespace OnlineExamination.Pages.Students
{
    [Authorize(Roles = "Manager")]
    public class DeleteModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IManageStudents ManageStudent;
        [BindProperty]
        public StudentDTO Student { get; set; }
        public DeleteModel(IManageStudents _ManageStudent, UserManager<ApplicationUser> _userManager)
        {
            ManageStudent = _ManageStudent;
            userManager = _userManager;
        }
        public IActionResult OnGet(int studentId)
        {
            Student = ManageStudent.GetStudentById(studentId);
            if (Student == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public async Task<IActionResult> OnPostAsync(int studentId)
        {
            //Delete From Application User
            var student = ManageStudent.GetStudentById(studentId);

            var stud = await userManager.FindByEmailAsync(student.Email);
            if (stud == null)
            {
                return BadRequest();
            }
            else
            {
                var Result = await userManager.DeleteAsync(stud);
                if (Result.Succeeded)
                {
                    //Delete From Student table
                    ManageStudent.DeleteStudent(studentId);
                    return RedirectToPage("List");
                }
            }
            return RedirectToPage("List");
        }
    }
}
