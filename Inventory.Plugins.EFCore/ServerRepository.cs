using Inventory.CoreBusiness;
using Inventory.UseCase.PluginInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Plugins.EFCore
{
    public class ServerRepository: IServerRepository
    {
        private readonly IMSContext db;

        public ServerRepository(IMSContext db)
        {
            this.db = db;
        }
        public async Task<List<Server>> GetServersByName(string name)
        {
            return await this.db.Servers.Where(x => x.ServerName.Contains(name, StringComparison.OrdinalIgnoreCase)
                                                   || string.IsNullOrWhiteSpace(name)).ToListAsync();
        }
    }
}
