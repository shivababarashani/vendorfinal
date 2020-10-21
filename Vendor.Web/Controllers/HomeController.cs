using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Products;
using Vendor.Web.Models;

namespace Vendor.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VendorDbContext _context;

        public HomeController(ILogger<HomeController> logger, VendorDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult PrintPage()
        {
            return View("PrintPage");
        }
        public IActionResult Print()
        {
            //StiReport report = new StiReport();
            //report.Load(StiNetCoreHelper.MapPath(this, "wwwroot/Reports/VendorReport.mrt"));
            //var venor = _context.CarTypes.ToList();
            //report.RegData("dt", venor);
            //return StiNetCoreViewer.GetReportResult(this, report);
            return null;
        }
        public IActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }
        [Authorize]
        public IActionResult Index()
        {
            var ProductCount =  _context.Products
               .Where(p => p.IsAccepted !=AcceptedTypes.Accepte).Count();
            ViewData["ProductCount"] = ProductCount;

            var CountOfVendor = _context.Products
                .Where(p => p.IsAccepted == AcceptedTypes.Accepte).Count();
            ViewData["VendorCount"] = CountOfVendor;

            var CountOfCompany =  _context.Companies.Count();
            ViewData["CompanyCount"] = CountOfCompany;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
