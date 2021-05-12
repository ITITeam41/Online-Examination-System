using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Application.ManageStudents;

namespace OnlineExamination.Pages.Students
{
    public class ListModel : PageModel
    {
        private readonly IManageStudents manageStudents;
        public StudentDTOList Students { get; set; }
        public ListModel(IManageStudents _manageStudents)
        {
            manageStudents = _manageStudents;
        }
        public void OnGet()
        {
            Students = manageStudents.GetAllStudents();
        }
    }
}
