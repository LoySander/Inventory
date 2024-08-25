using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.CoreBusiness
{
    public class Server
    {
        public int ServerId {  get; set; }
        public string VendorName {  get; set; }
        public string ServerName { get; set; }

        public Vendor Vendor { get; set; }

    }
}
