using Inventory.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.UseCase.PluginInterfaces
{
    public interface IVendorRepository
    {
        public Task<List<Vendor>> GetVendorsByName(string name);
    }
}
