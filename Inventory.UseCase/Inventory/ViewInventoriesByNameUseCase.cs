
using Inventory.UseCase.PluginInterfaces;
using Inventory.CoreBusiness;
using Inventory.UseCase.Interfaces;


namespace Inventory.UseCase.Inventory;
public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
{
    private readonly IInventoryRepository inventoryRepository;
    public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }
    public async Task<IEnumerable<CoreBusiness.Inventory>> ExecuteAsync(string name = "")
    {
        return await inventoryRepository.GetInventoriesByName(name);
    }

   
}
