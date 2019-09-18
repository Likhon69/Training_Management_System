using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrainingManagement.Model;
using TrainingManagement.Repository.Base;
using TrainingManagement.Repository.Contracts;

namespace TrainingManagement.Repository
{
    public class AzureTraineeRepository :BaseRepository<Trainee>,IRepository<Trainee>
    {
        public AzureTraineeRepository(DbContext db) : base(db)
        {
        }

        
    }
}
