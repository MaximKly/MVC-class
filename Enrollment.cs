using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningASPMVC.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public decimal? Grade { get; set; } //decimal? so if no value it doesnt deafult to 0.0
        public virtual Student student { get; set; }
        public virtual Course course { get; set; }

    }
}