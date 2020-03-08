using System;
using System.Linq;
using System.Linq.Expressions;
using Threezool.dev.Models;

namespace Threezool.dev.Data.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        int Create(T entity);  
        int Update(T entity);  
        void Delete(T entity);
    }
}