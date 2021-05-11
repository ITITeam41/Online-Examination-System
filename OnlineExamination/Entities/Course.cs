using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Entities
{
    public class Course
    {
        public Course()
        {
            Exams = new List<Exam>();
        }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
