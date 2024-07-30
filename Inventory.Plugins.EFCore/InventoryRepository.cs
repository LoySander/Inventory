using Inventory.UseCase.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventoryContext db;

        public InventoryRepository(InventoryContext db) {

            this.db = db;
        }

        public async Task<IEnumerable<CoreBusiness.Inventory>> GetInventoriesByName(string name)
        {
           return await this.db.Inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase) 
                                                    || string.IsNullOrWhiteSpace(name)).ToListAsync();
        }

        public async Task AddInventoryAsync(CoreBusiness.Inventory inventory)
        {
            this.db.Inventories.Add(inventory);
            await this.db.SaveChangesAsync();
        }
    }
}
