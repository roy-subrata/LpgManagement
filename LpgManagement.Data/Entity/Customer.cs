using System;
using System.Collections.Generic;
using System.Text;

namespace LpgManagement.Data.Entity
{
   public class Customer:IBaseEntity
    {
        public int Id { get; set; }
        public DateTime ModifyEntity { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Provice { get; set; }
        public string Address { get; set; }
    }
    public enum CustomerType
    {
        Local = 1,
        SubDealer = 2,
    }
}
