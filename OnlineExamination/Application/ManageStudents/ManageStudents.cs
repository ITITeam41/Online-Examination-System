using Microsoft.AspNetCore.Identity;
using OnlineExamination.Data;
using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Application.ManageStudents
{
    public class ManageStudents : IManageStudents
    {
        private readonly RoleManager<IdentityRole> roleMAnager;
        private readonly UserManager<ApplicationUser> userManager;
        public ManageStudents(RoleManager<IdentityRole> _roleMAnager, UserManager<ApplicationUser> _userManager)
        {
            userManager = _userManager;
            roleMAnager = _roleMAnager;
        }
        public void AddNewStudent(StudentDTO student)
        {
            throw new NotImplementedException();
        }

        public void EditStudent(StudentDTO student)
        {
            throw new NotImplementedException();
        }

        public StudentDTOList GetAllStudents()
        {
            var studs = userManager.Users.ToList();
            return new StudentDTOList()
            {
                Students = studs.Where(r => r.UserRole == "User")
                .Select(std => new StudentDTO
                {
                    Id = std.Id,
                    Email = std.Email,
                    Name = std.UserName,
                    PhoneNumber = std.PhoneNumber,
                }).ToList(),
                StudentsCount = studs.Count
            };
        }

        public StudentDTO GetStudentById(string studentId)
        {
            var stud = userManager.Users.SingleOrDefault(std => std.Id == studentId);
            return new StudentDTO()
            {
                Id = stud.Id,
                Email = stud.Email,
                Name = stud.UserName,
                PhoneNumber = stud.PhoneNumber,
            };
        }

        public List<StudentDTO> GetStudentByName(string searchName)
        {
            throw new NotImplementedException();
        }
    }
}
