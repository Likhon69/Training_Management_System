using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Model;

namespace TrainingManagement.Repository.Contracts
{
    public interface ITraineeRepository:IRepository<Trainee>
    {
        ICollection<Trainee> GetByDepartment(int departmentId);
    }
}
