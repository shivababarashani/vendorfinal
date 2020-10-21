using System;
using System.Collections.Generic;
using System.ComponentModel;
using Vendor.Domain.Entites.Companies;
using Vendor.Domain.Entities.Contries;

namespace Vendor.Domain.Entites.Cars
{
  public  class Car
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("تعداد")]
        public int Count { get; set; }
        [DisplayName("تاریخ ساخت")]
        public DateTime ManufactureDate { get; set; }
        [DisplayName("ظرفیت")]
        public decimal Capacity { get; set; }
        [DisplayName("شرح")]
        public string Description { get; set; }
        [DisplayName("تجهیزات آزمایشگاهی")]
        public bool IsEquipment { get; set; }
        [DisplayName("مدارک کالیبره شدن دستگاه ها")]
        public string UploadCalibrationMachine { get; set; }

        public long CarTypeId { get; set; }
        public long ContryId { get; set; }
        public long CompanyId { get; set; }
        public string UserId { get; set; }
        [DisplayName("نوع دستگاه")]
        public virtual CarType CarType { get; set; }
        [DisplayName("کشور سازنده")]
        public virtual Contry Contry { get; set; }
        public virtual Company Company { get; set; }
        


    }
}
