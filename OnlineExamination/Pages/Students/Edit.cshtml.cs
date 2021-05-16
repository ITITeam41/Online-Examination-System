using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Application.ManageStudents;

namespace OnlineExamination.Pages.Students
{
    [Authorize(Roles = "Manager")]
    //[Authorize(Roles = "User")]
    public class EditModel : PageModel
    {
        private readonly IManageStudents manageStudents;
        [BindProperty]
        public StudentDTO Student { get; set; }
        public EditModel(IManageStudents _manageStudents)
        {
            manageStudents = _manageStudents;
        }
        public void OnGet(int studentId)
        {
            Student = manageStudents.GetStudentById(studentId);

            if (Student == null)
            {
                Student = new StudentDTO();
            }
        }
        public IActionResult OnPost()
        {
            if (Student.Id == 0)
            {
                manageStudents.AddNewStudent(Student);
                return RedirectToPage("List");
            }
            else
            {
                manageStudents.EditStudent(Student);
                return RedirectToPage("List");
            }
        }
    }
}
