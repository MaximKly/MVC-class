using LearningASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningASPMVC.ViewModels
{
//View Model
    public class CourseStudents
    {
        public Course course { get; set; }
        public List<Student> students { get; set; }
    }
}