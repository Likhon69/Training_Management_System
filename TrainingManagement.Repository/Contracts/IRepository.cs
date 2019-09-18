using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagement.Model;

namespace TrainingManagement.Repository.Contracts
{
    public interface IRepository<T> where T:class
    {
        bool Add(T entity);
        bool Update(T entity);
        T GetById(int id);
        bool Remove(T entity);
        ICollection<T> GetAll();
    }
}
