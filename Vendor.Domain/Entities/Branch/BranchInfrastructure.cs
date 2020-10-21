using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Vendor.Domain.Entites.Branch
{
    public class BranchInfrastructure 
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("متراژ")]
        public Decimal Area { get; set; }
        
        [DisplayName("شناسه")]
        public long BranchInfrastructureTypeId { get; set; }
        [DisplayName("نوع ملک")]
        public InfrastructureTypes InfrastructureType { get; set; }
        public string UploadOwnershipDocuments { get; set; }
        [DisplayName("نوع زیربنا")]
        public virtual BranchInfrastructureType BranchInfrastructureType { get; set; }
        public virtual List<BranchAddress> BranchAddresses { get; set; }
    }
    public enum InfrastructureTypes
    {
        Melki = 1,
        Estijari=2,
    }
}
