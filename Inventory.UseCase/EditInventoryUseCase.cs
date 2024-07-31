using Inventory.UseCase.Interfaces;
using Inventory.UseCase.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.UseCase
{
    public class EditInventoryUseCase: IEditInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public EditInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task ExecuteAsync(CoreBusiness.Inventory inventory)
        {
            await inventoryRepository.EditInventoryAsync(inventory);
        }
    }
}
