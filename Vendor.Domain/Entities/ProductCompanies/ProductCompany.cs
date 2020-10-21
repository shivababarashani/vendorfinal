using System;
using System.Collections.Generic;
using System.Text;
using Vendor.Domain.Entites.Companies;
using Vendor.Domain.Entites.Products;

namespace Vendor.Domain.Entities.ProductCompanies
{
   public class ProductCompany
    {
        public long Id { get; set; }
        public virtual Company Company { get; set; }
        public long CompanyId { get; set; }
        public long ProductId { get; set; }
        public string UserId { get; set; }
        public virtual Product Product { get; set; }
    }
}
