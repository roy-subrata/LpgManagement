using System;
using System.Collections.Generic;
using System.Text;

namespace LpgManagement.Data.Entity
{
    public class LpgCylinder:IBaseEntity
    {
        public int Id { get; set; }
        public DateTime ModifyEntity { get; set; }
        public string Name { get; set; }
        public Size Size { get; set; }
        public float Weight { get; set; }
        public Brand Brand { get; set; }
        public string Desc { get; set; }

    }

   public enum Size
    {
        Size_22M=1,
        Size_20M=2,
    }
}
