using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrainingManagement.Model
{
    public class Trainee
    {
        public Trainee()
        {
            TraineeTypeId = 1;
            
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RegNo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int TraineeTypeId { get; set; }
       
        public virtual List<CourseTrainee> CourseTrainee { get; set; }
    }
}
