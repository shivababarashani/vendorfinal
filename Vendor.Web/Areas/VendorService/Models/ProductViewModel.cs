using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendor.Domain.Entites.Exports;
using Vendor.Domain.Entites.ProductionRates;
using Vendor.Domain.Entites.Products;

namespace Vendor.Web.Areas.VendorService.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public ProductionRate ProductionRate { get; set; }
        public Export Export { get; set; }
    }
}
