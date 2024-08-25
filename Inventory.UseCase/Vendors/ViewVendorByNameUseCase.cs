using Inventory.UseCase.Interfaces;
using Inventory.UseCase.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.UseCase.Vendors
{
    public class ViewVendorByNameUseCase: IViewVendorByNameUseCase
    {
        private readonly IVendorRepository _vendorRepository;
        public ViewVendorByNameUseCase(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public async Task<IEnumerable<CoreBusiness.Vendor>> ExecuteAsync(string name = "")
        {
            return await _vendorRepository.GetVendorsByName(name);
        }
    }
}
