using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineExamination.Application.ManageManagers
{
    public class ManageManager : IManageManager
    {
        private readonly RoleManager<IdentityRole> roleMAnager;
        private readonly UserManager<ApplicationUser> userManager;
        public ManageManager(RoleManager<IdentityRole> roleMAnager,
            UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            this.roleMAnager = roleMAnager;
        }

        void IManageManager.AddManager(ManagerDTO Manager)
        {
            throw new NotImplementedException();
        }

        //void IManageManager.DeleteManager(string ManagerID)
        //{
        //    var mngr = userManager.Users
        //    .SingleOrDefault(u => u.Id == ManagerID);
        //    userManager.RemoveFromRoleAsync(mngr, "Manager");
        //    userManager.DeleteAsync(mngr);

        //}

        void IManageManager.EditManager(ManagerDTO Manager)
        {
            throw new NotImplementedException();
        }

        ManagerDTO IManageManager.GetManager(string ManagerID)
        {
            var mngr = userManager.Users
                .SingleOrDefault(u => u.Id == ManagerID);
            return new ManagerDTO()
            {
                Id = mngr.Id,
                Email = mngr.Email,
                NAMe = mngr.UserName,
                PhoneNumber = mngr.PhoneNumber,
            };
            //return userManager.Users.SingleOrDefault(u => u.Id == ManagerID);
        }

        ManagerDTOList IManageManager.GetManagers()
        {
            var mngrs = userManager.Users.ToList();
            return new ManagerDTOList()
            {
                Managers = mngrs.Where(r=>r.UserRole=="Manager")
                .Select(u => new ManagerDTO
                {
                    Id = u.Id,
                    NAMe = u.UserName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    UserName = u.Name
                }).ToList(),
                ManagersCount = mngrs.Count
            };
        }
    }
}
