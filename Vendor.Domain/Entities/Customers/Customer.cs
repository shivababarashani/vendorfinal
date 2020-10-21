using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Vendor.Domain.Entities.Customers;

namespace Vendor.Domain.Entites.Customers
{
    public class Customer
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("نام")]
        public string Name { get; set; }
        [DisplayName("نام خانوادگی")]
        public string Family { get; set; }
        [DisplayName("نام پدر")]
        public string FatherName { get; set; }
        [DisplayName("کدملی")]
        public string NationalCode { get; set; }
        [DisplayName("شماره شناسنامه")]
        public string IDNumber { get; set; }
        [DisplayName("تاریخ تولد")]
        public DateTime BirthDate { get; set; }
        [DisplayName("شناسه")]
        public long DegreeEducationId { get; set; }
        [DisplayName("تلفن")]
        public string Tel { get; set; }
        [DisplayName("فکس")]
        public string Fax { get; set; }
        [DisplayName("ایمیل")]
        public string Email { get; set; }
        [DisplayName("سمت")]
        public string Post { get; set; }
        [DisplayName("سابقه کار")]
        public int WorkExperience { get; set; }
        [DisplayName("صاحب امضا")]
        public bool TheSignatory { get; set; }
        [DisplayName("بارگذاری مدارک")]
        public string UploadDocuments { get; set; }
        [DisplayName("شناسه")]
        public long CustomerTypeId { get; set; }
        [DisplayName("شناسه")]
        public string UserId { get; set; }
        [DisplayName("نوع شخص")]
        public virtual CustomerType CustomerType { get; set; }
        [DisplayName("مدرک تحصیلی")]
        public virtual DegreeEducation DegreeEducation { get; set; }
    }
}
