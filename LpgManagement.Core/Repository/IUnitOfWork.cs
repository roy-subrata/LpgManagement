using System;
using System.Collections.Generic;
using System.Text;

namespace LpgManagement.Core.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        int Commit();
    }
}
