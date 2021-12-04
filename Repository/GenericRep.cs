using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tamplate.DAL.Database;
using Template.BL.Interface;

namespace Template.BL.Repository
{
    public class GenericRep<T> : IGeneric<T> where T : class
    {
        private readonly TemplateContext db;
        private DbSet<T> dbSet;

        public GenericRep(TemplateContext db)
        {
            this.db = db;
            dbSet = db.Set<T>();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query;
            //return dbSet.Select(a => a);
        }

        public T GetById(int id, params Expression<Func<T, object>>[] includes)
        {
            return dbSet.Find(id);
        }

        public T Create(T entity)
        {
            dbSet.Add(entity);
            Save();
            return entity;
        }

        public T Update(T entity)
        {
            dbSet.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            Save();

            return entity;
        }

        public T Delete(T entity)
        {
            dbSet.Remove(entity);
            Save();

            return entity;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
