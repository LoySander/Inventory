using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.UseCase.PluginInterfaces;
using Inventory.UseCase.Interfaces;

namespace Inventory.UseCase.Inventory
{
    public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<CoreBusiness.Inventory> ExecuteAsync(int invetoryId)
        {
            return await inventoryRepository.GetInventoryAsync(invetoryId);
        }
    }
}
