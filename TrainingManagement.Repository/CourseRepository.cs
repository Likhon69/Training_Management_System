using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Database.Database;
using TrainingManagement.Model;
using TrainingManagement.Repository.Base;
using TrainingManagement.Repository.Contracts;

namespace TrainingManagement.Repository
{
    public class CourseRepository:BaseRepository<Course>,ICourseRepository
    {
        
    
        public CourseRepository(DbContext db) : base(db)
        {
            
        }

        public TraineeDatabaseContext context
        {
            get
            {
                return (TraineeDatabaseContext)db;
            }
        }


    }
}
