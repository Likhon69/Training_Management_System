using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Manager.Contracts;
using TrainingManagement.Model;
using TrainingManagement.Repository.Contracts;

namespace TrainingManagement.Manager.Base
{
    public class BaseManager<T>:IManager<T> where T:class
    {
        private IRepository<T> _repository;
        public BaseManager(IRepository<T> repository)
        {
            _repository = repository;
        }
        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

       

        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();

        }

        public virtual T GetById(int id)
        {

            return _repository.GetById(id);
        }

        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
