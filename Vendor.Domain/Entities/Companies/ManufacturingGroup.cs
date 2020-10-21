using System.Collections.Generic;
using Vendor.Domain.Entities;

namespace Vendor.Domain.Entites.Companies
{
    public class ManufacturingGroup : ConstantType
    {
        public virtual List<Company> Companies { get; set; }
    }
}
