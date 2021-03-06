using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamination.Application.ManageExam
{
    public interface IManageExam
    {
        List<Exam> GetAllExams();
        List<ExamQuestion> GetAllExamQuestions();
        List<Question> GetAllQuestions();
        Exam GetExamById(int examId);
        List<Exam> GetExamByName(string searchName);
        void EditExam(Exam exam);
        void deleteExam(int examId);
        void AddNewExam(Exam exam);
        double GetMarkForEachQuestion(int examId);
        Exam GetCurrentExam();
    }
}
