using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TrainingManagement.Model;

namespace FinalPrject.Models.TraineeVm
{
    public class TraineeCreateVm
    {
        public string Name { get; set; }
        [Required]
        public string RegNo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SelectListItem> DepartmentLookUpData { get; set; }
        public ICollection<Trainee> TraineeList { get; set; }
    }
}
