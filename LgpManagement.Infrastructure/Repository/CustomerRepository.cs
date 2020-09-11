using LpgManagement.Core.Repository;
using LpgManagement.Data;
using LpgManagement.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LgpManagement.Infrastructure.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private LgpContext LgpContext
        {
            get { return Context as LgpContext; }

        }
        public CustomerRepository(LgpContext context) : base(context)
        {

        }

        
    }
}
