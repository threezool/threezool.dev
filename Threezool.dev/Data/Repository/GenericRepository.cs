using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Threezool.dev.Data.DbContext;
using Threezool.dev.Models;

namespace Threezool.dev.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly InMemoryContext Db;  
        
        public GenericRepository(InMemoryContext db)  
        {  
            Db = db;
            db.Database.EnsureCreated();
        }
        
        public IQueryable<T> GetAll()
        {
            return this.Db.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.Db.Set<T>().Where(expression).AsNoTracking();
        }

        public int Create(T entity)
        {
            this.Db.Set<T>().Add(entity);
            return Save();
        }

        public int Update(T entity)
        {
            bool tracking = this.Db.ChangeTracker.Entries<T>().Any(x => x.Entity.Id == entity.Id);

            if (!tracking)
                this.Db.Set<T>().Update(entity);
            
            return Save();
        }

        public void Delete(T entity)
        {
            this.Db.Set<T>().Remove(entity);
            Save();
        }
        
        private int Save()
        {
            return this.Db.SaveChanges();
        }
    }
}