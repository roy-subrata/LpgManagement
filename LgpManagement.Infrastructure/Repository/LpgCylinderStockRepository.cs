using LpgManagement.Core.Repository;
using LpgManagement.Data;
using LpgManagement.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LgpManagement.Infrastructure.Repository
{
    public class LpgCylinderStockRepository : Repository<LpgCylinderStock>, ILpgCylinderStockRepository
    {
        private LgpContext LgpContext
        {
            get { return Context as LgpContext; }

        }
        public LpgCylinderStockRepository(LgpContext context) : base(context)
        {

        }

        
    }
}
