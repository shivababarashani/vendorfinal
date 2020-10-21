using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Vendor.Domain;
using Vendor.Domain.Entites.Branch;
using Vendor.Domain.Entites.Cars;
using Vendor.Domain.Entites.Companies;
using Vendor.Domain.Entites.Contracts;
using Vendor.Domain.Entites.Corroborants;
using Vendor.Domain.Entites.Customers;
using Vendor.Domain.Entites.Exports;
using Vendor.Domain.Entites.Licenses;
using Vendor.Domain.Entites.ProductionRates;
using Vendor.Domain.Entites.Products;
using Vendor.Domain.Entities.Contries;
using Vendor.Domain.Entities.Customers;

namespace Vendor.Datalayer
{
    public class VendorDbContext : IdentityDbContext
    {
        public VendorDbContext(DbContextOptions<VendorDbContext> options)
           : base(options)
        {
        }


        protected override  void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }


        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<BranchAddress> BranchAddresses { get; set; }
        public DbSet<BranchInfrastructure> BranchInfrastructures { get; set; }
        public DbSet<BranchStaff> BranchStaffs { get; set; }
        public DbSet<BranchType> BranchTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<OwnershipType> OwnershipType { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Contry> Contries { get; set; }
        public DbSet<Corroborant> Corroborants { get; set; }
        public DbSet<CorroborantType> CorroborantTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        //public DbSet<ExportProduct> ExportProducts { get; set; }
        public DbSet<Export> Exports { get; set; }
        public DbSet<Vendor.Domain.Entites.Licenses.License> Licenses { get; set; }
        public DbSet<LicenseType> LicenseTypes { get; set; }
        //public DbSet<ExportProduct> ProductCompanies { get; set; }
        public DbSet<ProductionRate> ProductionRates { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<BranchInfrastructureType> BranchInfrastructureType { get; set; }
        public DbSet<BranchStaffType> BranchStaffType { get; set; }
        public DbSet<DegreeEducation> DegreeEducation { get; set; }
        public DbSet<ManufacturingGroup> ManufacturingGroups { get; set; }

    }
}
