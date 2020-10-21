using System;
using System.Collections.Generic;
using System.Text;
using Vendor.Domain.Entities;


namespace Vendor.Domain.Entites.Products
{
    public class ProductType:ConstantType
    {
        public virtual List<Product> Products { get; set; }
    }
}
