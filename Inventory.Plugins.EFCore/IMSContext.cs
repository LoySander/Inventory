using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.CoreBusiness;

namespace Inventory.Plugins.EFCore
{
    public class IMSContext : DbContext
    {
        public IMSContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Inventory.CoreBusiness.Inventory> Inventories { get; set; }

        public DbSet<Inventory.CoreBusiness.Server> Servers { get; set; }

        public DbSet<Inventory.CoreBusiness.Vendor> Vendors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory.CoreBusiness.Inventory>().HasData(
                new Inventory.CoreBusiness.Inventory { InventoryId = 1, InventoryName = "PC 1" }
            );


            modelBuilder.Entity<Inventory.CoreBusiness.Vendor>().HasData(
              new Inventory.CoreBusiness.Vendor { VendorId = 1, VendorName = "HP"},
               new Inventory.CoreBusiness.Vendor { VendorId = 2, VendorName = "Dell" }
          );

            modelBuilder.Entity<Inventory.CoreBusiness.Server>().HasData(
              new Inventory.CoreBusiness.Server { ServerId = 1, VendorName = "HP", ServerName = "Proliant", Vendor =  }
          );
        }
    }
}
