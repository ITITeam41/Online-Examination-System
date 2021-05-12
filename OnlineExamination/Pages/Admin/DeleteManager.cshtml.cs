using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Application.ManageManagers;

namespace OnlineExamination.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class DeleteManagerModel : PageModel
    {
        private readonly RoleManager<IdentityRole> roleMAnager;
        private readonly UserManager<ApplicationUser> userManager;

        public IManageManager manageManager;
        public DeleteManagerModel(IManageManager manageManager,
            RoleManager<IdentityRole> roleMAnager,
            UserManager<ApplicationUser> userManager)
        {
            this.manageManager = manageManager;
            this.roleMAnager = roleMAnager;
            this.userManager = userManager;
        }
        [BindProperty]
        public ManagerDTO mngr { get; set; }
        public void OnGet(string managerId)
        {
            mngr = manageManager.GetManager(managerId);
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
                var Result = await userManager.DeleteAsync(mg);
                if (Result.Succeeded)
                {
                    return RedirectToPage("./Managers");
                }
            }

            return RedirectToPage("./Managers");
        }
    }
}
