using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingManagement.Database.Database;
using TrainingManagement.Model;
using TrainingManagement.Repository.Base;
using TrainingManagement.Repository.Contracts;

namespace TrainingManagement.Repository
{
    public class TraineeRepository : BaseRepository<Trainee>, ITraineeRepository
    {
        public TraineeRepository(DbContext db) : base(db)
        {
        }
        public TraineeDatabaseContext context
        {
            get
            {
                return (TraineeDatabaseContext)db;
            }
        }

        public ICollection<Trainee> GetByDepartment(int departmentId)
        {
            return context.Trainees.Where(c => c.DepartmentId == departmentId).ToList();
        }
    }
}
