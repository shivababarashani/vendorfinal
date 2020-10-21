using System.Collections.Generic;
using Vendor.Domain.Entities;

namespace Vendor.Domain.Entites.Branch
{
    public class BranchInfrastructureType : ConstantType
    {
        public virtual List<BranchInfrastructure> BranchInfrastructures { get; set; }
    }
}
