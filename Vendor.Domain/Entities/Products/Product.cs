using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Vendor.Domain.Entites.Companies;
using Vendor.Domain.Entites.Corroborants;
using Vendor.Domain.Entites.Exports;
using Vendor.Domain.Entites.ProductionRates;
using Vendor.Domain.Entities.ProductCompanies;

namespace Vendor.Domain.Entites.Products
{
    public class Product
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("کد")]
        public string Code { get; set; }
        [DisplayName("نام")]
        public string Description { get; set; }
        [DisplayName("گارانتی")]
        public bool Guarantee { get; set; }
        [DisplayName("مسائل زیست محیطی")]
        public bool Environment { get; set; }
        [DisplayName("وضعیت")]
        public AcceptedTypes IsAccepted { get; set; } = 0;
        [DisplayName("دلیل رد")]
        public string Reason { get; set; }
        [DisplayName("لیست مراکز")]
        public string ManufacturerCenters { get; set; }
        [DisplayName("مراحل کنترل کیفیت")]
        public string UploadControlForm { get; set; }
        [DisplayName("نوع محصول")]
        public long ProductTypeId { get; set; }
        [DisplayName("تایید کننده")]
        public long CorroborantId { get; set; }
        [DisplayName("شرکت")]
        public long CompanyId { get; set; }
        [DisplayName("کاربر ثبت کننده")]
        public string UserId { get; set; }
        [DisplayName("تاریخ ایجاد")]
        public DateTime CreateDate { get; set; }
        [DisplayName("تاریخ تغییر")]
        public DateTime ModifiedDate { get; set; }

        [DisplayName("نوع محصول")]
        public virtual ProductType ProductType { get; set; }
        [DisplayName("تایید کننده")]
        public virtual Corroborant Corroborant { get; set; }
        public virtual Company Company { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        //public virtual List<ProductCompany> ProductCompanies { get; set; }
        public virtual List<ProductionRate> ProductionRates { get; set; }
        public virtual List<Export> Exports { get; set; }

        
    }
    public enum AcceptedTypes
    {
        Reject = 1,
        Accepte=2,
        Edited=3,
    }
}
