using System;
using System.Collections.Generic;
using System.Text;

namespace LpgManagement.Data.Entity
{
   public class LpgCylinderStock:IBaseEntity
    {
        public int Id { get; set; }
        public DateTime ModifyEntity { get; set; }
        public string StockNo { get; set; }
        public Category Category { get; set; }
        public LpgCylinder LpgCylinder { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime StockDate { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
