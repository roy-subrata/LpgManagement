using LpgManagement.Core.Repository;
using LpgManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LgpManagement.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LgpContext _context;
        public UnitOfWork(LgpContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
        }
        public ICategoryRepository Category { get; private set; }

        public int Commit()
        {
           return _context.SaveChanges();
        }
       
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
