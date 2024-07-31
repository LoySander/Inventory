using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.UseCase.Interfaces
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(CoreBusiness.Inventory inventory);
    }
}
