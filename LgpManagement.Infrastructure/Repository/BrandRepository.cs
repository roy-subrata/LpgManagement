using LpgManagement.Core.Repository;
using LpgManagement.Data;
using LpgManagement.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LgpManagement.Infrastructure.Repository
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        private LgpContext LgpContext
        {
            get { return Context as LgpContext; }

        }
        public BrandRepository(LgpContext context) : base(context)
        {

        }

        
    }
}
