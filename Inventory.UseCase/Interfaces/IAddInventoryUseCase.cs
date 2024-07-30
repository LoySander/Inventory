namespace Inventory.UseCase.Interfaces
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(CoreBusiness.Inventory inventory);
    }
}