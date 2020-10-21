using System;
using System.Collections.Generic;
using System.Text;
using Vendor.Domain.Entites.Products;
using Vendor.Domain.Entities;

namespace Vendor.Domain.Entites.Licenses
{
   public class LicenseType:ConstantType
    {
        public virtual List<Product> Products { get; set; }
    }
}
