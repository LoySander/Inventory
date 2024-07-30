using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.CoreBusiness;

namespace Inventory.Plugins.EFCore
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Inventory.CoreBusiness.Inventory> Inventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory.CoreBusiness.Inventory>().HasData(
                new Inventory.CoreBusiness.Inventory { InventoryId = 1, InventoryName = "HP Proliant" }
            );
        }
    }
}
