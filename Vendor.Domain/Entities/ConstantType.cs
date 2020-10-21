using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Vendor.Domain.Entities
{
   public class ConstantType
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("نام")]

        public string Name { get; set; }

    }
}
