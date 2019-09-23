using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Manager.Base;
using TrainingManagement.Manager.Contracts;
using TrainingManagement.Model;
using TrainingManagement.Repository.Contracts;

namespace TrainingManagement.Manager
{
    public class DepartmentManager : BaseManager<Department>,IDepartmentManager
    {
        private IDepartmentRepository _departmentRepository;
        public DepartmentManager(IDepartmentRepository repository) : base(repository)
        {
            _departmentRepository = repository;
        }
        public override ICollection<Department> GetAll()
        {
            var departments = _departmentRepository.GetAll();
            return departments;
        }
    }
}
