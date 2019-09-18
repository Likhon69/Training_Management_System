using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Manager.Base;
using TrainingManagement.Manager.Contracts;
using TrainingManagement.Model;
using TrainingManagement.Repository;
using TrainingManagement.Repository.Contracts;

namespace TrainingManagement.Manager
{
    public class CorporateTraineeManager :BaseManager<Trainee>,ITraineeManager
    {
        private ITraineeRepository _traineeRepository;
        public CorporateTraineeManager(ITraineeRepository repository):base(repository)
        {
            _traineeRepository = repository;
        }

        public ICollection<Trainee> GetByDepartment(int departmentId)
        {
            throw new NotImplementedException();
        }
    }
}
