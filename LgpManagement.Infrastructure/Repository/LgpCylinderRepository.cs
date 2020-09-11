using LpgManagement.Core.Repository;
using LpgManagement.Data;
using LpgManagement.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LgpManagement.Infrastructure.Repository
{
    public class LgpCylinderRepository : Repository<LgpCylinder>, ILgpCylinderRepository
    {
        private LgpContext LgpContext
        {
            get { return Context as LgpContext; }

        }
        public LgpCylinderRepository(LgpContext context) : base(context)
        {

        }

        
    }
}
