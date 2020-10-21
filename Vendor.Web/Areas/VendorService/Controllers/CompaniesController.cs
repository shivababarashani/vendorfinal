using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Companies;
using Vendor.Utilities.Files;
using Vendor.Web.Models;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class CompaniesController : Controller
    {
        private readonly VendorDbContext _context;
        private readonly IWebHostEnvironment _enviroment;

        public CompaniesController(VendorDbContext context, IWebHostEnvironment environment)
        {
            _enviroment = environment;
            _context = context;
        }

        // GET: VendorService/Companies
        public async Task<IActionResult> Index()
        {
            var vendorDbContext = _context.Companies;
            return View(await vendorDbContext.ToListAsync());
        }

        public IActionResult IndexComplete()
        {
            #region Company
           
            ViewData["CompanyTypeId"] = new SelectList(_context.CompanyTypes, "Id", "Name");
            ViewData["OwnershipTypeId"] = new SelectList(_context.OwnershipType, "Id", "Name");
            ViewData["ManufacturingGroupId"] = new SelectList(_context.ManufacturingGroups, "Id", "Name");

            #endregion


            ViewData["BranchStaffTypeId"] = new SelectList(_context.BranchStaffType, "Id", "Name");
            ViewData["BranchInfrastructureTypeId"] = new SelectList(_context.BranchInfrastructureType, "Id", "Name");

            ViewData["CustomerTypeId"] = new SelectList(_context.CustomerTypes, "Id", "Name");

            ViewData["DegreeEducationId"] = new SelectList(_context.DegreeEducation, "Id", "Name");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexComplete([Bind("Name,RecordNumber,RecordPlace," +
          "NationalId,EconomicCode,UseLicenseNumber," +
          "ActivityDescription,MaterialList,Randd,ConstructionMetod,QcProgram,ResearchMember" +
            ",CompanyTypeId,OwnershipTypeId,CarId,LicenseId")] Company company,string RecordDate,string CompanyStartDate,string FactoryStartDate,string FactoryUseDate,string UseLicenseDate )
        {
            
            CompanyViewModel companyViewModel = new CompanyViewModel();
            return RedirectToAction(nameof(Index));
        }
        // GET: VendorService/Companies/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .Include(c => c.Cars)
                .Include(c => c.CompanyType)
                .Include(c => c.License)
                .Include(c => c.OwnershipType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: VendorService/Companies/Create
        public IActionResult Create()
        {
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Id");
            ViewData["CompanyTypeId"] = new SelectList(_context.CompanyTypes, "Id", "Name");
            ViewData["LicenseId"] = new SelectList(_context.Licenses, "Id", "Id");
            ViewData["OwnershipTypeId"] = new SelectList(_context.OwnershipType, "Id", "Name");
            return View();
        }

        // POST: VendorService/Companies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,RecordNumber,RecordDate,RecordPlace,CompanyStartDate," +
            "FactoryStartDate,FactoryUseDate,NationalId,EconomicCode,UseLicenseNumber,UseLicenseDate," +
           "ActivityDescription,MaterialList,Randd,ConstructionMetod,QcProgram,ResearchMember" +
            ",CompanyTypeId,OwnershipTypeId,CarId,LicenseId")] Company company,
            IFormFile UploadDocuments, IFormFile UploadUseLicensePic, IFormFile UploadStatutePic,
            IFormFile UploadOfficialnewspapers, IFormFile UploadProductCatalog, IFormFile UploadMemberOfTheInstitute)
        {
            FileManager fileManager = new FileManager(_enviroment);
            if (UploadDocuments != null)
                company.UploadDocuments = await fileManager.InsertFiles(UploadDocuments, "image/Document");

            if (UploadUseLicensePic != null)
                company.UploadUseLicensePic = await fileManager.InsertFiles(UploadUseLicensePic, "image/Document");

            if (UploadStatutePic != null)
                company.UploadStatutePic = await fileManager.InsertFiles(UploadStatutePic, "image/Document");

            if (UploadOfficialnewspapers != null)
                company.UploadOfficialnewspapers = await fileManager.InsertFiles(UploadOfficialnewspapers, "image/Document");

            if (UploadProductCatalog != null)
                company.UploadProductCatalog = await fileManager.InsertFiles(UploadProductCatalog, "image/Document");
            
            if (UploadMemberOfTheInstitute != null)
                company.UploadMemberOfTheInstitute = await fileManager.InsertFiles(UploadMemberOfTheInstitute, "image/Document");


            if (ModelState.IsValid)
            {
                _context.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                //ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Id", company.Car.CarType.Name);
                ViewData["CompanyTypeId"] = new SelectList(_context.CompanyTypes, "Id", "Id", company.CompanyType.Id);
                ViewData["LicenseId"] = new SelectList(_context.Licenses, "Id", "Id", company.License.LicenseType.Name);
                ViewData["OwnershipTypeId"] = new SelectList(_context.OwnershipType, "Id", "Id", company.OwnershipType.Id);
            }
          
            return View(company);
        }

        // GET: VendorService/Companies/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            //ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Id", company.Cars.Id );
            ViewData["CompanyTypeId"] = new SelectList(_context.CompanyTypes, "Id", "Id", company.CompanyType.Id);
            ViewData["LicenseId"] = new SelectList(_context.Licenses, "Id", "Id", company.License.Id);
            ViewData["OwnershipTypeId"] = new SelectList(_context.OwnershipType, "Id", "Id", company.OwnershipType.Id);
            return View(company);
        }

        // POST: VendorService/Companies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,RecordNumber,RecordDate,RecordPlace,CompanyStartDate,FactoryStartDate,FactoryUseDate,NationalId,EconomicCode,UseLicenseNumber,UseLicenseDate,ActivityDescription,MaterialList,Randd,ConstructionMetod,QcProgram,ResearchMember,UploadUseLicensePic,UploadStatutePic,UploadOfficialnewspapers,UploadProductCatalog,UploadDocuments,UploadMemberOfTheInstitute,CompanyTypeId,OwnershipTypeId,CarId,LicenseId")] Company company)
        {
            if (id != company.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Id", company.Car.Id);
            ViewData["CompanyTypeId"] = new SelectList(_context.CompanyTypes, "Id", "Id", company.CompanyType.Id);
            ViewData["LicenseId"] = new SelectList(_context.Licenses, "Id", "Id", company.License.Id);
            ViewData["OwnershipTypeId"] = new SelectList(_context.OwnershipType, "Id", "Id", company.OwnershipType.Id);
            return View(company);
        }

        // GET: VendorService/Companies/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .Include(c => c.Cars)
                .Include(c => c.CompanyType)
                .Include(c => c.License)
                .Include(c => c.OwnershipType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: VendorService/Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var company = await _context.Companies.FindAsync(id);
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyExists(long id)
        {
            return _context.Companies.Any(e => e.Id == id);
        }
    }
}
