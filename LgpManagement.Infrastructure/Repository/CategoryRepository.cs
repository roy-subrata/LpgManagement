using LpgManagement.Core.Repository;
using LpgManagement.Data;
using LpgManagement.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LgpManagement.Infrastructure.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private LgpContext LgpContext
        {
            get { return Context as LgpContext; }

        }
        public CategoryRepository(LgpContext context) : base(context)
        {

        }

        
    }
}
