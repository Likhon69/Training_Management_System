using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPrject.Utilities
{
    public interface IUtitlityManager
    {
        ICollection<SelectListItem> GetDepartmentLookUpData();
    }
}
