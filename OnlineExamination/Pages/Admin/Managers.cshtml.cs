using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineExamination.OnlineExam.Application.ManageManagers;

namespace OnlineExamination.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class ManagersModel : PageModel
    {
        public IManageManager manageManager;

        public ManagerDTOList managerDTOList { get; set; }

        private readonly RoleManager<IdentityRole> roleMAnager;
        private readonly UserManager<ApplicationUser> userManager;
        public ManagersModel(RoleManager<IdentityRole> roleMAnager,
            UserManager<ApplicationUser> userManager,
            IManageManager manageManager)
        {
            this.userManager = userManager;
            this.roleMAnager = roleMAnager;
            this.manageManager = manageManager;
        }
        //public IQueryable<ApplicationUser> users { get; set; }
        public void OnGet()
        {
            //users = userManager.Users;
            managerDTOList = manageManager.GetManagers();
        }
    }
}
