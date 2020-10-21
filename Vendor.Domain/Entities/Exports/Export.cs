using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Vendor.Domain.Entites.Products;


namespace Vendor.Domain.Entites.Exports
{
   public class Export
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("سال")]
        public int Year { get; set; }
        //public string ProductName { get; set; }
        [DisplayName("کارفرما")]
        public string Employer { get; set; }
        [DisplayName("شماره قرارداد")]
        public string ContractNumber { get; set; }
        [DisplayName("وزن/مقدار")]
        public int WeightNumber { get; set; }
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        [DisplayName("کاربرثبت کننده")]
        public string UserId { get; set; }
        [DisplayName("شناسه")]
        public long ProductId { get; set; }
        [DisplayName("محصول")]
        public virtual Product Product { get; set; }

    }
}
