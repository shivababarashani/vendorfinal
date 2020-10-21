using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Vendor.Domain.Entites.Products;

namespace Vendor.Domain.Entites.ProductionRates
{
   public class ProductionRate
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("سال")]
        public int Year { get; set; }
        [DisplayName("مقدار")]
        public decimal Amount { get; set; }
        [DisplayName("شناسه")]
        public long ProductId { get; set; }
        [DisplayName("شناسه")]
        public string UserId { get; set; }
        [DisplayName("محصول")]
        public virtual Product Product { get; set; }
    }
}
