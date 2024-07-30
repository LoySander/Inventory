using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.CoreBusiness;

namespace Inventory.UseCase.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<CoreBusiness.Inventory>> GetInventoriesByName(string name);

        Task AddInventoryAsync(CoreBusiness.Inventory inventory);
    }
}
 