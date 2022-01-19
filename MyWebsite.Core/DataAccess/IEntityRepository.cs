using MyWebsite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyWebsite.Core.DataAccess
{
    //Generic Constraint
    //Class olabiir demek referans tip olabilir demek, class olabilir demek değil.
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Count(Expression<Func<T, bool>> filter = null);


    }
}
