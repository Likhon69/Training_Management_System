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
    public class CourseManager :BaseManager<Course>, ICourseManager
    {
        private ICourseRepository _courseRepositry;
        public CourseManager(ICourseRepository repository):base(repository)
        {
            _courseRepositry = repository;
        }
        


    }
}
