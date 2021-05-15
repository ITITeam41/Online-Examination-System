using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamination.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Question> Questions { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region
            //builder.Entity<CourseExam>().HasKey(sc => new { sc.CourseId, sc.ExamId });

            //builder.Entity<CourseExam>()
            //    .HasOne<Course>(sc => sc.Course)
            //    .WithMany(s => s.CourseExams)
            //    .HasForeignKey(sc => sc.CourseId);

            //builder.Entity<CourseExam>()
            //    .HasOne<Exam>(sc => sc.Exam)
            //    .WithMany(s => s.CourseExams)
            //    .HasForeignKey(sc => sc.ExamId);
            #endregion
            builder.Entity<ExamQuestion>().HasKey(sc => new { sc.ExamId, sc.QuestionId });

            builder.Entity<ExamQuestion>()
             .HasOne<Exam>(sc => sc.Exam)
             .WithMany(s => s.ExamQuestions)
             .HasForeignKey(sc => sc.ExamId);

            builder.Entity<ExamQuestion>()
                .HasOne<Question>(sc => sc.Question)
                .WithMany(s => s.ExamQuestions)
                .HasForeignKey(sc => sc.QuestionId);


            builder.Entity<StudentExam>().HasKey(sc => new { sc.StudentId, sc.ExamId });

            builder.Entity<StudentExam>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.StudentExams)
                .HasForeignKey(sc => sc.StudentId);

            builder.Entity<StudentExam>()
                .HasOne<Exam>(sc => sc.Exam)
                .WithMany(s => s.StudentExams)
                 .HasForeignKey(sc => sc.ExamId);

            #region
            //builder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            //builder.Entity<StudentCourse>()
            //    .HasOne<Student>(sc => sc.Student)
            //    .WithMany(s => s.StudentCourses)
            //    .HasForeignKey(sc => sc.StudentId);

            //builder.Entity<StudentCourse>()
            //    .HasOne<Course>(sc => sc.Course)
            //    .WithMany(s => s.StudentCourses)
            //     .HasForeignKey(sc => sc.CourseId);
            #endregion
            base.OnModelCreating(builder);

            builder.Entity<StudentQuestions>().HasKey(sc => new { sc.StudentId, sc.QuestionId });

            builder.Entity<StudentQuestions>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.StudentQuestions)
                .HasForeignKey(sc => sc.StudentId);

            builder.Entity<StudentQuestions>()
                .HasOne<Question>(sc => sc.Question)
                .WithMany(s => s.StudentQuestions)
                 .HasForeignKey(sc => sc.QuestionId);

            base.OnModelCreating(builder);

        }
    }
}
