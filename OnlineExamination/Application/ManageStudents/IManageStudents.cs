using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Application.ManageStudents
{
    public interface IManageStudents
    {
        StudentDTOList GetAllStudents();
        StudentDTO GetStudentById(int studentId);
        List<StudentDTO> GetStudentByName(string searchName);
        void EditStudent(StudentDTO student);
        void AddNewStudent(StudentDTO student);
        void DeleteStudent(int studentId);
    }
}
