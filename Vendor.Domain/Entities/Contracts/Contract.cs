using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Vendor.Domain.Entites.Contracts
{
    public class Contract
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("تاریخ شروع")]
        public DateTime StartDate { get; set; }
        [DisplayName("تاریخ پایان")]
        public DateTime EndDate { get; set; }
        [DisplayName("طرف قرارداد")]
        public string ContractingParty { get; set; }
        [DisplayName("شماره قرارداد")]
        public string Number { get; set; }
        [DisplayName("تاریخ قرارداد")]
        public DateTime Date { get; set; }
        [DisplayName("مبلغ قرارداد")]
        public decimal Amount { get; set; }
        [DisplayName("شرح کالا")]
        public string ProductName { get; set; }
        [DisplayName("وزن /مقدار")]
        public decimal WeightNumber { get; set; }
        [DisplayName("توضیح")]
        public string Description { get; set; }
        [DisplayName("زمان تحویل")]
        public DateTime DeliveryTime { get; set; }
        [DisplayName("درصد پیشرفت")]
        public decimal Progress { get; set; }
        [DisplayName("وضعیت قرارداد")]
        public ContractTypes ContractTypeId { get; set; }
        [DisplayName("شناسه")]
        public long UnitId { get; set; }
        [DisplayName("شناسه")]
        public string UserId { get; set; }
        //[DisplayName("وضعیت قرارداد")]
        //public virtual ContractType ContractType { get; set; }
        [DisplayName("واحد")]
        public virtual Unit Unit { get; set; }


    }
    public enum ContractTypes
    {
        Finished = 1,
        InProcess = 2
    }
}
