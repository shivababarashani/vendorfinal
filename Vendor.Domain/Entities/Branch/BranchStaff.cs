using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Vendor.Domain.Entities;

namespace Vendor.Domain.Entites.Branch
{
   public class BranchStaff
    {
        public long Id { get; set; }
        [DisplayName("تعداد فنی")]
        public int TechnicalCount { get; set; }
        [DisplayName("تعداد غیرفنی")]
        public int NonTechnicalCount { get; set; }
        [DisplayName("شناسه")]
        public long BranchStaffTypeId { get; set; }
        public string UploadInsurance { get; set; }
        [DisplayName("نوع کارکنان")]
        public virtual BranchStaffType BranchStaffType { get; set; }
        public virtual List<BranchAddress> BranchAddresses { get; set; }
    }
    public class BranchStaffType:ConstantType
    {
        public virtual List<BranchStaff> BranchStaffs { get; set; }
    }
}
