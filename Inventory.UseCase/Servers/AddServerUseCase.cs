using Inventory.UseCase.Interfaces;
using Inventory.UseCase.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.UseCase.Servers
{
    public class AddServerUseCase: IAddServerUseCase
    {
        private readonly IServerRepository serverRepository;
        public AddServerUseCase(IServerRepository serverRepository)
        {
            this.serverRepository = serverRepository;
        }
        public async Task ExecuteAsync(CoreBusiness.Server server) {

            if (server == null) return;
        
            await serverRepository.AddServerAsync(server);
        }
    }
}
