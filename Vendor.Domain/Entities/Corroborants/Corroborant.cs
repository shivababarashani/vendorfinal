using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Vendor.Domain.Entites.Products;

namespace Vendor.Domain.Entites.Corroborants
{
  public  class Corroborant
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }

        [DisplayName("عنوان تایید کننده")]
        public string Name { get; set; }

        [DisplayName("تاریخ شروع")]
        public DateTime StartDate { get; set; }
        [DisplayName("تاریخ پایان")]
        public DateTime EndDate { get; set; }
        [DisplayName("مدارک لایسنس")]
        public string UploadLinces { get; set; }
        public string UserId { get; set; }
        [DisplayName("نوع تایید کننده")]
        public long CorroborantTypeId { get; set; }
        public virtual CorroborantType CorroborantType { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
