using System;
using System.Collections.Generic;
using System.Text;

namespace LpgManagement.Data.Entity
{
    public class Supplier : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime ModifyEntity { get; set; }
        public string Name { get; set; }
        public SupllierType SupllierType { get; set; }
        public string City { get; set; }
        public string Provice { get; set; }
        public string Address { get; set; }
        public string Phone {get;set;}
        public string ContactNo { get; set; }
    }
    public enum SupllierType
    {
        Local=1,
        Company=2,
        Distributor=3
    }
}
