using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Vendor.Domain.Entites.Branch;
using Vendor.Domain.Entites.Cars;
using Vendor.Domain.Entites.Licenses;
using Vendor.Domain.Entites.Products;
using Vendor.Domain.Entities.ProductCompanies;

namespace Vendor.Domain.Entites.Companies
{
    public class Company
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("نام")]
        public string Name { get; set; }
        [DisplayName("شماره ثبت")]
        public string RecordNumber { get; set; }
        [DisplayName("تاریخ ثبت")]
        public DateTime RecordDate{ get; set; }
        [DisplayName("محل ثبت")]
        public string RecordPlace { get; set; }
        [DisplayName("تاریخ تأسيس شرکت")]
        public DateTime CompanyStartDate { get; set; }
        [DisplayName("تاریخ تأسيس كارخانه")]
        public DateTime FactoryStartDate { get; set; }
        [DisplayName("تاریخ بهره برداری")]
        public DateTime FactoryUseDate { get; set; }
        [DisplayName("شناسه ملی")]
        public long NationalId { get; set; }
        [DisplayName("كد اقتصادی")]
        public string EconomicCode { get; set; }
        [DisplayName("كد اقتصادی")]
        public string IranCode { get; set; }
        [DisplayName("شماره پروانه بهره‌برداری")]
        public string UseLicenseNumber { get; set; }
        [DisplayName("تاريخ پروانه بهره‌برداری")]
        public DateTime UseLicenseDate { get; set; }
        [DisplayName("شرح کامل فعاليت ها و توليدات")]
        public string ActivityDescription { get; set; }
        [DisplayName("ليست مواد اوليه و قطعات")]
        public string MaterialList { get; set; }
        [DisplayName("واحد تحقيق و توسعه")]
        public bool Randd { get; set; }
        [DisplayName("برنامه کنترل کیفیت محصولات")]
        public string ConstructionMetod { get; set; }
        [DisplayName("روش ساخت/بسته بندی و نگهداری")]
        public string QcProgram { get; set; }
        [DisplayName("عضو پژوهش")]
        public bool ResearchMember { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// ////////////////////////
        /// </summary>
        [DisplayName("بارگذاری تصویر پروانه")]
        public string UploadUseLicensePic { get; set; }
        [DisplayName("بارگذاری اساسنامه")]
        public string UploadStatutePic { get; set; }
        [DisplayName("بارگذاری روزنامه های رسمی")]
        public string UploadOfficialnewspapers { get; set; }
        [DisplayName("بارگذاری کاتالوگ محصولات")]
        public string UploadProductCatalog { get; set; }
        [DisplayName("بارگذاری مدارک: (نمایندگی از شرکت های دیگر،مجوز،فعالیت،پروانه)")]
        public string UploadDocuments { get; set; }
        [DisplayName("بارگذاری مدارک عضویت در موسسه")]
        public string UploadMemberOfTheInstitute { get; set; }

        public long CompanyTypeId { get; set; }

        public long OwnershipTypeId { get; set; }
        public long ManufacturingGroupId { get; set; }

        public long CarId { get; set; }

        public long LicenseId { get; set; }
                    
        [DisplayName("نوع مالکیت")]
        public virtual OwnershipType OwnershipType { get; set; }
        [DisplayName("نوع تولیدات شرکت")]
        public virtual ManufacturingGroup ManufacturingGroup { get; set; }

        [DisplayName("نوع شرکت")]
        public virtual CompanyType CompanyType { get; set; }


        public virtual List<Car> Cars { get; set; }

        public virtual Vendor.Domain.Entites.Licenses.License License { get; set; }

        public virtual List<BranchAddress> BranchAddresses { get; set; }
        public virtual List<Product> Products { get; set; }

    }
}
