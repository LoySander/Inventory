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

        public async Task EditServerAsync(CoreBusiness.Server server)
        {
            if (this.db.Servers.Any(x => x.ServerId != server.ServerId && x.ServerName.Equals(server.ServerName, StringComparison.OrdinalIgnoreCase))) return;
            var inv = await this.db.Servers.FindAsync(server.ServerId);
            if (inv != null)
            {
                inv.ServerName = server.ServerName;
                await this.db.SaveChangesAsync();
            }
        }
        public async Task AddServerAsync(CoreBusiness.Server server)
        {
            if (this.db.Servers.Any(x => x.ServerName.Equals(server.ServerName, StringComparison.OrdinalIgnoreCase))) return;
            this.db.Servers.Add(server);
            await this.db.SaveChangesAsync();
        }

    }
}
