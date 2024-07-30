namespace Inventory.UseCase.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<CoreBusiness.Inventory>> ExecuteAsync(string name = "");
    }
}