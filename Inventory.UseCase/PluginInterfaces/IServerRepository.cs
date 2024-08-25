using Inventory.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.UseCase.PluginInterfaces
{
    public interface IServerRepository
    {
        public Task<List<Server>> GetServersByName(string name);
        
        public Task EditServerAsync(Server server);

        public Task AddServerAsync(Server server);
    }
}
