using Microsoft.AspNetCore.Identity;
using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination
{
    public class ApplicationUser : IdentityUser
    {
        public string UserRole { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

    }
}
