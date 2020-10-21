using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Vendor.Domain.Entities;

namespace Vendor.Domain.Entites.Contracts
{
   public class ContractType
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("نوع")]
        public int Type { get; set; }
      
        public virtual List<Contract> Contracts { get; set; }
    }
}
