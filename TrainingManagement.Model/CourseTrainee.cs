using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrainingManagement.Model
{
    public class CourseTrainee
    {
        [Key]
        public int TraineeId { get; set; }
        public virtual Trainee Trainee { get; set; }
        [Key]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
