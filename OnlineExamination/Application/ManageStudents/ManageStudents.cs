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
        private readonly ApplicationDbContext context;
        public ManageStudents(ApplicationDbContext _context)
        {
            context = _context;
        }
        public void AddNewStudent(StudentDTO student)
        {
            var stud = new Student()
            {
                StudentId = student.Id,
                Name = student.Name,
                Email = student.Email,
                Gender = student.Gender,
                Phone = student.PhoneNumber,
                examMark = student.examMark,
                examStatus = student.examStatus
            };
            context.Student.Add(stud);
            context.SaveChanges();
        }

        public void DeleteStudent(int studentId)
        {
            var stud = context.Student.SingleOrDefault(std => std.StudentId == studentId);
            context.Student.Remove(stud);
            context.SaveChanges();
        }

        public void EditStudent(StudentDTO student)
        {
            var stud = context.Student.SingleOrDefault(std => std.StudentId == student.Id);
            if (stud != null)
            {
                stud.Name = student.Name;
                stud.Phone = student.PhoneNumber;
                stud.Email = student.Email;
                stud.Gender = student.Gender;
                stud.examMark = student.examMark;
                stud.examStatus = student.examStatus;

                context.SaveChanges();
            }
        }

        public StudentDTOList GetAllStudents()
        {
            var studs = context.Student.ToList();

            return new StudentDTOList()
            {
                Students = studs.Select(std => new StudentDTO
                {
                    Id = std.StudentId,
                    Email = std.Email,
                    Name = std.Name,
                    Gender = std.Gender,
                    PhoneNumber = std.Phone,
                    examMark = std.examMark,
                    examStatus = std.examStatus
                }).ToList(),
                StudentsCount = studs.Count
            };
        }

        public StudentDTO GetStudentById(int studentId)
        {
            var stud = GetAllStudents().Students.SingleOrDefault(std => std.Id == studentId);
            return stud;
        }

        public List<StudentDTO> GetStudentByName(string searchName)
        {
            throw new NotImplementedException();
        }
    }
}