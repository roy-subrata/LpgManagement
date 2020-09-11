using System;
using System.Collections.Generic;
using System.Text;

namespace LpgManagement.Core.Repository
{
   public interface IRepository<TEntity> where TEntity : class
    {
          //get 
        IEnumerable<TEntity> Get();
        TEntity GetById(int id);
        //add
        void Add(TEntity entity);
        void Add(IEnumerable<TEntity> entity);
        //remove
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entity);
      
    }
}
