using System;
using System.Collections.Generic;
using System.Text;

namespace LpgManagement.Data.Entity
{
    interface IBaseEntity
    {
         int Id { get; set; }
         DateTime ModifyEntity { get; set; }
     
    }
}
