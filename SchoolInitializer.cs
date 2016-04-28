using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LearningASPMVC.Models
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
           var students = new List<Student>{
               new Student{FirstName = "Max", LastName = "Shmux", EnrollmentDate = DateTime.Parse("2016-01-07") },
               new Student{FirstName = "Alex", LastName = "Shmalex", EnrollmentDate = DateTime.Parse("2016-01-09") }
           };
            
            foreach (var temp in students){
                context.Students.Add(temp);
            }
            context.SaveChanges();

            var courses = new List<Course>{
                new Course{CourseName = "Java", TotalCredits = 4},
                new Course{CourseName = "C#", TotalCredits = 5}
            };
            foreach (var temp in courses)
            {
                context.Courses.Add(temp);
            }
            context.SaveChanges();

            var enrollments = new List<Enrollment>{
                new Enrollment{ StudentID = 1, CourseID = 1, Grade = 3},
                new Enrollment{StudentID = 2, CourseID = 2, Grade = 4}
            };
            foreach (var temp in enrollments)
            {
                context.Enrollments.Add(temp);
            }
            context.SaveChanges();


        }
    }
}