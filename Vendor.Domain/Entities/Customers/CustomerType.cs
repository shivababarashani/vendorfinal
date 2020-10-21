using System;
using System.Collections.Generic;
using System.Text;
using Vendor.Domain.Entities;

namespace Vendor.Domain.Entites.Customers
{
    public class CustomerType:ConstantType
    {
        public virtual List<Customer> Customers { get; set; }
    }
}
