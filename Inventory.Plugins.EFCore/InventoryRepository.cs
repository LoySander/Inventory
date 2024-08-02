using Inventory.UseCase.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IMSContext db;

        public InventoryRepository(IMSContext db) {

            this.db = db;
        }

        public async Task<IEnumerable<CoreBusiness.Inventory>> GetInventoriesByName(string name)
        {
           return await this.db.Inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase) 
                                                    || string.IsNullOrWhiteSpace(name)).ToListAsync();
        }

        public async Task AddInventoryAsync(CoreBusiness.Inventory inventory)
        {
            if (this.db.Inventories.Any(x => x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase))) return;
            this.db.Inventories.Add(inventory);
            await this.db.SaveChangesAsync();
        }

        public async Task EditInventoryAsync(CoreBusiness.Inventory inventory)
        {
            if(this.db.Inventories.Any(x=> x.InventoryId != inventory.InventoryId && x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase))) return;
            var inv =  await this.db.Inventories.FindAsync(inventory.InventoryId);
            if (inv != null) {
                inv.InventoryName = inventory.InventoryName;
                await this.db.SaveChangesAsync();
            }        
        }

        public async Task<CoreBusiness.Inventory> GetInventoryAsync(int invetoryId)
        {
            return await this.db.Inventories.FindAsync(invetoryId);
        }
    }
}
