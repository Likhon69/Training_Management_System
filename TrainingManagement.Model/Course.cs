using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public virtual List<CourseTrainee> CourseTrainees { get; set; }
    }
}
