using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrainingManagement.Manager.Contracts;

namespace FinalPrject.Utilities
{
    public class UtilityManager : IUtitlityManager
    {
        private IDepartmentManager _departmentManager;
        public UtilityManager(IDepartmentManager departmentManager)
        {
            _departmentManager = departmentManager;
        }
        public ICollection<SelectListItem> GetDepartmentLookUpData()
        {
            return _departmentManager.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.DeptName
            }).ToList();
        }
    }
}
