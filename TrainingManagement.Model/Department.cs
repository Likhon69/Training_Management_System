using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.Model
{
    public class Department
    {
        public Department()
        {
            Trainees = new List<Trainee>();
        }
        public int Id { get; set; }
        public string DeptName { get; set; }
        public virtual List<Trainee> Trainees { get; set; }
    }
}
