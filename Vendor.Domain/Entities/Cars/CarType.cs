using System.Collections.Generic;
using Vendor.Domain.Entities;

namespace Vendor.Domain.Entites.Cars
{ 
  public  class CarType:ConstantType
    {
        public virtual List<Car> Cars { get; set; }

    }
}
