using Inventory.CoreBusiness;
using Inventory.UseCase.Interfaces;
using Inventory.UseCase.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.UseCase.Servers
{
    public class ViewServersByNameUseCase : IViewServerByNameUseCase
    {
        private readonly IServerRepository _serverRepository;
        public ViewServersByNameUseCase(IServerRepository serverRepository)
        {
            _serverRepository = serverRepository;
        }

        public async Task<IEnumerable<CoreBusiness.Server>> ExecuteAsync(string name = "")
        {
            return await _serverRepository.GetServersByName(name);
        }

    }
}
