using System;
using System.Collections.Generic;
using System.Text;

namespace LpgManagement.Data.Entity
{
    public class Category:IBaseEntity
    {
        public int Id { get; set; }
        public DateTime ModifyEntity { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        
    }
}
