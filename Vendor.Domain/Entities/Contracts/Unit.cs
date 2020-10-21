using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Vendor.Domain.Entites.Contracts
{
   public class Unit
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("نوع")]
        public decimal Amount { get; set; }
        public string UserId { get; set; }
        public virtual List<Contract> Contracts { get; set; }

    }
}
