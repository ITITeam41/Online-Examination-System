using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        [BindProperty]
        public IFormFile RefFile { get; set; }
        public IWebHostEnvironment Hosting { get; }
        public EditModel(IManageStudents _manageStudents, IWebHostEnvironment hosting)
        {
            manageStudents = _manageStudents;
            Hosting = hosting;
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
                if (RefFile.FileName != null)
                {
                    var fileName = Path.GetFileName(RefFile.FileName);
                    // Get New Path related to project
                    var fullPath = Path.Combine(Hosting.WebRootPath, "Uploads", fileName);
                    // Copy File To the New Path in WWWroot
                    RefFile.CopyTo(new FileStream(fullPath, FileMode.Create));
                    // Assign Image to Student
                    Student.ImagePath = fileName;
                }

                manageStudents.AddNewStudent(Student);
                return RedirectToPage("List");
            }
            else
            {
                if (RefFile.FileName != null)
                {
                    var fileName = Path.GetFileName(RefFile.FileName);
                    // Get New Path related to project
                    var fullPath = Path.Combine(Hosting.WebRootPath, "Uploads", fileName);

                    //Delete the Old path
                    string oldFileName = Student.ImagePath;
                    if (oldFileName == null)
                    {
                        oldFileName = "default.png";// We use this as the first time to assign image ImagePath equal NULL
                    }
                    string fullOldPath = Path.Combine(Hosting.WebRootPath, "Uploads", oldFileName);

                    if (fullPath != fullOldPath)
                    {
                        // To Solve Error The process cannot access the file because it is being used by another process
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();

                        if(System.IO.File.Exists(fullOldPath))
                            System.IO.File.Delete(fullOldPath);

                        RefFile.CopyTo(new FileStream(fullPath, FileMode.Create));

                        Student.ImagePath = fileName;
                    }
                    // Assign Image to Student
                    Student.ImagePath = fileName;
                }
                manageStudents.EditStudent(Student);
                return RedirectToPage("List");
            }
        }
    }
}
