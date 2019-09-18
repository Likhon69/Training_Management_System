using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainingManagement.Model;
using TrainingManagement.Repository.Contracts;

namespace TrainingManagement.Repository.Base
{
    public abstract class BaseRepository<T>:IRepository<T> where T:class
    {
        protected DbContext db;
        public BaseRepository(DbContext db)
        {
            this.db = db;
        }
        public DbSet<T> Table { get { return db.Set<T>(); } }

        public virtual bool Add(T entity)
        {
            Table.Add(entity);
            return db.SaveChanges() > 0;
        }

        public virtual ICollection<T> GetAll()
        {
            return Table.ToList();
        }

        public virtual T GetById(int id)
        {
            return Table.Find(id);
        }

        public virtual bool Remove(T entity)
        {
            Table.Remove(entity);
            return db.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
