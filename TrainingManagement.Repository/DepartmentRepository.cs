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
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        
        public DepartmentRepository(DbContext db) : base(db)
        {
            
        }
        public TraineeDatabaseContext context
        {
            get
            {
                return (TraineeDatabaseContext)db;
            }
        }
        public override ICollection<Department> GetAll()
        {
            var departments = context.Department.ToList();
            return departments;
        }
    }
}
