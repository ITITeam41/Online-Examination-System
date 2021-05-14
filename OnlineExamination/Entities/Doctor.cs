using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Entities
{
    public class Doctor
    {
        public Doctor()
        {
            Questions = new List<Question>();
            Exams = new List<Exam>();

        }
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public List<Question> Questions { get; set; }
        public List<Exam> Exams { get; set; }

    }
}
