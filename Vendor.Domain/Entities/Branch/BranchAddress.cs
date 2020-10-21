using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Vendor.Domain.Entites.Companies;

namespace Vendor.Domain.Entites.Branch
{
   public class BranchAddress
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("آدرس")]
        public string Address { get; set; }
        [DisplayName("کدپستی")]
        public string PostalCode { get; set; }
        [DisplayName("شماره تلفن")]
        public string Tel { get; set; }
        [DisplayName("فکس")]
        public string Fax { get; set; }
        [DisplayName("ایمیل")]
        public string Email { get; set; }
        [DisplayName("وب سایت")]
        public string Website { get; set; }
        [DisplayName("شناسه")]
        public long BranchTypeId { get; set; }
        [DisplayName("شناسه")]
        public long BranchStaffId { get; set; }
        [DisplayName("شناسه")]
        public long BranchInfrastructureId { get; set; }
        [DisplayName("کاربر ثبت کننده")]
        public string UserId { get; set; }
        [DisplayName("نوع شعبه")]
        public virtual BranchType BranchType { get; set; }
        [DisplayName("کارمندان شعبه")]
        public virtual BranchStaff BranchStaff { get; set; }
        [DisplayName("زیربنا شعبه")]
        public virtual BranchInfrastructure BranchInfrastructure { get; set; }
        [DisplayName("شرکت")]
        public virtual Company Company { get; set; }

    }
}
