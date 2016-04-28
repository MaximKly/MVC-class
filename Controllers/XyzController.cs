using LearningASPMVC.Models;
using LearningASPMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningASPMVC.Controllers
{
    public class XyzController : Controller
    {
        // GET: Xyz
        private SchoolContext db = new SchoolContext();
        public ActionResult Abc()
        {
            var students = db.Students.ToList();
            return View(students);
            //Course math = new Course();
            //math.CourseName = "Math 101";
            //math.TotalCredits = 4;

            //Student alex = new Student();
            //alex.FirstName = "Alex";
            //alex.LastName = "Rod";

            //Student lynda = new Student();
            //lynda.FirstName = "Lynda";
            //lynda.LastName = "Berry";

            //Student john = new Student();
            //john.FirstName = "John";
            //john.LastName = "Doe";

            //List<Student> students = new List<Student>();
            //students.Add(alex);
            //students.Add(lynda);
            //students.Add(john);


            //CourseStudents obj = new CourseStudents();
            //obj.course = math;
            //obj.students = students;
           
            //return View(alex);
            //return "From XyzController, Abc action method";
            //return View(obj);
            
        }

        public ActionResult Index()
        {
             return View();
            //return "From XyzController, Index action method";
        }
    }
}