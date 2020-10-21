using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendor.Domain.Entites.Branch;
using Vendor.Domain.Entites.Cars;
using Vendor.Domain.Entites.Companies;
using Vendor.Domain.Entites.Contracts;
using Vendor.Domain.Entites.Customers;
using Vendor.Domain.Entites.Licenses;

namespace Vendor.Web.Models
{
    public class CompanyViewModel
    {
        public Company Company { get; set; }
        public Car Car { get; set; }
        public BranchAddress BranchAddress { get; set; }
        public BranchStaff BranchStaff { get; set; }
        public BranchInfrastructure BranchInfrastructure { get; set; }
        public Customer Customer { get; set; }
        public License License { get; set; }
        public Contract Contract { get; set; }

    }
}
