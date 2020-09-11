using LpgManagement.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace LpgManagement.Data
{
    public class LgpContext:DbContext
    {
        public LgpContext(DbContextOptions<LgpContext> options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<LpgCylinder> LpgCylinders { get; set; }
        public DbSet<LpgCylinderStock> LpgCylinderStocks { get; set; }
    }
}
