using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManagement.Manager.Contracts
{
    public interface IManager<T> where T:class
    {
        bool Add(T entity);
        bool Update(T entity);
        T GetById(int id);
        bool Remove(T entity);
        ICollection<T> GetAll();
    }
}
