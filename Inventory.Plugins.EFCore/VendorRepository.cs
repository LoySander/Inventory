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
    public class VendorRepository: IVendorRepository
    {
        private readonly IMSContext db;

        public VendorRepository(IMSContext db)
        {

            this.db = db;
        }

        public async Task<List<Vendor>> GetVendorsByName(string name)
        {
            return await this.db.Vendors.Where(x => x.VendorName.Contains(name, StringComparison.OrdinalIgnoreCase)
                                                   || string.IsNullOrWhiteSpace(name)).ToListAsync();
        }
    }
}
