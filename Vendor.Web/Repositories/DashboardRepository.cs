using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Products;

namespace Vendor.Web.Repositories
{
    public class DashboardRepository
    {
        private readonly VendorDbContext _context;

        public DashboardRepository(VendorDbContext context)
        {
            _context = context;
        }

        public async Task<int> CountOfProduct()
        {
            var product = await _context.Products
                .Where(p => p.IsAccepted != AcceptedTypes.Accepte).CountAsync();
            return product;
        }
        public async Task<int> CountOfVendor()
        {
            var product = await _context.Products
                .Where(p => p.IsAccepted == AcceptedTypes.Accepte).CountAsync();
            return product;
        }
        public async Task<int> CountOfCompany()
        {
            var Companies = await _context.Companies.CountAsync();
            return Companies;
        }
    }
}
