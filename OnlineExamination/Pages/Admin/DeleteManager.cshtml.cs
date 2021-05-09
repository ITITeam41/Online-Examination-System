using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.Application.ManageManagers;

namespace OnlineExamination.Pages.Admin
{
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
        public ManagerDTO mngr { get; set; }
        public void OnGet(string managerId)
        {
            mngr = manageManager.GetManager(managerId);
        }
        public IActionResult OnPost(string managerId)
        {
            var mg = userManager.Users.SingleOrDefault(m => m.Id == managerId);
            userManager.RemoveFromRoleAsync(mg, "Manager");
            userManager.DeleteAsync(mg);
            //manageManager.DeleteManager(managerId);
            return RedirectToPage("./Managers");
        }
    }
}
