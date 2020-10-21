using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Vendor.Domain.Entites.Companies;

namespace Vendor.Domain.Entites.Licenses
{
    public class License
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("تاریخ شروع")]
        public DateTime StartDate { get; set; }
        [DisplayName("تاریخ پایان")]
        public DateTime EndDate { get; set; }
        [DisplayName("مدارک")]
        public string UploadLinces { get; set; }
        [DisplayName("شناسه")]
        public long LicenseTypeId { get; set; }
        [DisplayName("شناسه")]
        public string UserId { get; set; }
        [DisplayName("نوع گواهینامه")]
        public virtual LicenseType LicenseType { get; set; }
        
        public virtual List<Company> Companies { get; set; }
    }
}
