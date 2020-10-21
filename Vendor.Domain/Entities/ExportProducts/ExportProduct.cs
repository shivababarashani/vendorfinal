using System;
using System.Collections.Generic;
using System.Text;
using Vendor.Domain.Entites.Exports;
using Vendor.Domain.Entites.Products;

namespace Vendor.Domain.Entities.ExportProducts
{
   public class ExportProduct
    {
        public long Id { get; set; }
        public virtual Export Export { get; set; }
        public long ExportId { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
