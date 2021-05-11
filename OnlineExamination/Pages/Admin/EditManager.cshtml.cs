using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.OnlineExam.Application.ManageManagers;

namespace OnlineExamination.Pages.Admin
{
    public class EditManagerModel : PageModel
    {
        private readonly RoleManager<IdentityRole> roleMAnager;
        private readonly UserManager<ApplicationUser> userManager;

        public IManageManager manageManager;
        public EditManagerModel(IManageManager manageManager,
            RoleManager<IdentityRole> roleMAnager,
            UserManager<ApplicationUser> userManager)
        {
            this.manageManager = manageManager;
            this.roleMAnager = roleMAnager;
            this.userManager = userManager;
        }

        [BindProperty]
        public ApplicationUser manager { get; set; }
        public async Task OnGetAsync(string managerId)
        {
            manager = await userManager.FindByIdAsync(managerId);
        }
        public async Task<IActionResult> OnPostAsync(string managerId)
        {
            var mg = await userManager.FindByIdAsync(managerId);
            if (mg == null)
            {
                return BadRequest();
            }
            else
            {
                mg.Email = manager.Email;
                mg.Name = manager.Name;
                mg.UserName = manager.UserName;
                mg.PhoneNumber = manager.PhoneNumber;
                var Edited = await userManager.UpdateAsync(mg);
                if (Edited.Succeeded)
                {
                    return RedirectToPage("./Managers");
                }
            }

            return RedirectToPage("./Managers");
        }
    }
}
