using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineExamination.Pages.Exam
{
    [Authorize(Roles = "Manager")]
    public class AddExamModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
