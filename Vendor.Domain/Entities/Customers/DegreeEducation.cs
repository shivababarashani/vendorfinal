using System;
using System.Collections.Generic;
using System.Text;
using Vendor.Domain.Entites.Customers;

namespace Vendor.Domain.Entities.Customers
{
   public class DegreeEducation:ConstantType
    {
        public virtual List<Customer> Customers { get; set; }
    }
}
