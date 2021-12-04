using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Template.BL.Interface
{
    public interface IGeneric<T> where T : class
    {
        IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes);

        T GetById(int Id, params Expression<Func<T, object>>[] includes);

        T Create(T entity);

        T Update(T entity);

        T Delete(T entity);

        void Save();
    }
}
