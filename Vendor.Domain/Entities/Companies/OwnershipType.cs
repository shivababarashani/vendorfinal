﻿using System;
using System.Collections.Generic;
using System.Text;
using Vendor.Domain.Entities;

namespace Vendor.Domain.Entites.Companies
{
    public class OwnershipType : ConstantType
    {
        public virtual List<Company> Companies { get; set; }
    }
}
