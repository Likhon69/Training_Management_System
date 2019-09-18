
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
    public class TraineeManager:BaseManager<Trainee>,ITraineeManager
    {
        private ITraineeRepository _traineeRepository;
        public TraineeManager(ITraineeRepository repository):base(repository)
        {
            _traineeRepository = repository;
        }

        public ICollection<Trainee> GetByDepartment(int departmentId)
        {
            return _traineeRepository.GetByDepartment(departmentId);
        }
    }
}
