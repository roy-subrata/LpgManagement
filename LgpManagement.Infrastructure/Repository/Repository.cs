using LpgManagement.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LgpManagement.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected  readonly DbContext Context;
        public Repository(DbContext context)
        {
            Context = context;
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Add(IEnumerable<TEntity> entity)
        {
            Context.Set<TEntity>().AddRange(entity);
        }

        public IEnumerable<TEntity> Get()
        {
           return Context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entity)
        {
            Context.Set<TEntity>().RemoveRange(entity);
        }
    }
}
