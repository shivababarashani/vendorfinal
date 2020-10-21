using System;
using System.Collections.Generic;
using System.Text;
using Vendor.Domain.Entities;

namespace Vendor.Domain.Entites.Branch
{
   public class BranchType : ConstantType
    {
        public virtual List<BranchAddress> BranchAddresses { get; set; }
    }
}
