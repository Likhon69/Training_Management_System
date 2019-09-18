using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Model;

namespace TrainingManagement.Manager.Contracts
{
    public interface ITraineeManager:IManager<Trainee>
    {
        ICollection<Trainee> GetByDepartment(int departmentId);
    }
}
