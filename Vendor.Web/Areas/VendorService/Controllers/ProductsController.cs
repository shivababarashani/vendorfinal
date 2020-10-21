using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Vendor.Datalayer;
using Vendor.Domain;
using Vendor.Domain.Entites.Exports;
using Vendor.Domain.Entites.ProductionRates;
using Vendor.Domain.Entites.Products;
using Vendor.Utilities.Files;
using Vendor.Web.Areas.VendorService.Models;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class ProductsController : Controller
    {
        private readonly VendorDbContext _context;
        private readonly IWebHostEnvironment _enviroment;
        private readonly UserManager<ApplicationUser> _usermanager;

        public ProductsController(IWebHostEnvironment enviroment, VendorDbContext context,
            UserManager<ApplicationUser> usermanager)
        {
            _enviroment = enviroment;
            _context = context;
            _usermanager = usermanager;
            
        }

        [Route("DownloadFile/{name}")]
        public IActionResult DownloadFile(string name)
        {
            // var ffile =await _UnitOfWork.Requests.GetAsync(id);

            string FilePath = Path.Combine(_enviroment.WebRootPath, "image/Document") + $@"\{name}";

            //string FileName = $"{name.Name}.{name.Type}";
            string FileName = $"{name}";

            var fileProvider = new Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider();
            if (!fileProvider.TryGetContentType(FilePath, out string contentType))
            {
                throw new ArgumentOutOfRangeException($"Unable to find Content Type for file name {FilePath}.");
            }

            byte[] file = System.IO.File.ReadAllBytes(FilePath);//به بایت تبدیل کن
            return File(file, contentType, fileDownloadName: FileName);

        }
        //public ProductsController(VendorDbContext context, UserManager<ApplicationUser> usermanager)
        //{
        //    _context = context;
        //    _usermanager = usermanager;
        //}
        public IActionResult PrintPage()
        {
            return View("PrintPage");
        }
        public async Task<IActionResult> Print()
        {
            StiReport report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, "wwwroot/Reports/VendorReport.mrt"));
            var venor = _context.Products.Where(p=>p.IsAccepted==AcceptedTypes.Accepte).Select(p => new { p.Id,Name=p.Reason   }).ToList();
            report.RegData("dt", venor);
            return await StiNetCoreViewer.GetReportResultAsync(this, report);
        }
        public IActionResult ViewerEvent()
        {
            IActionResult result = null;
            try
            {
                result = StiNetCoreViewer.ViewerEventResult(this);
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                var data = ex.Data;
            }

            return result;

        }

        public IActionResult DesignerEvent()
        {
            return StiNetCoreDesigner.DesignerEventResult(this);
        }
        // GET: VendorService/Products
        public async Task<IActionResult> Index()
        {
            var products = _context.Products
                .Where(p=> p.IsAccepted != AcceptedTypes.Accepte)
                .OrderByDescending(p=>p.ModifiedDate)
                .ToListAsync();

            return View(await products);
        }
        public async Task<IActionResult> Views()
        {
            var products = _context.Products
                .Where(p => p.IsAccepted != AcceptedTypes.Accepte)
                .OrderByDescending(p => p.ModifiedDate)
                .ToListAsync();

            return View(await products);
        }
        public async Task<IActionResult> IndexByUserId()
        {
            var user=await _usermanager.GetUserAsync(User);
            var vendor= _context.Products
                .Where(p=>p.UserId== user.Id)
                .OrderByDescending(p => p.ModifiedDate)
                .ToListAsync();

            return View(await vendor);
        }
        public async Task<IActionResult> IndexVendorList()
        {
            var user = await _usermanager.GetUserAsync(User);
            var vendor = _context.Products.Where(p => p.UserId == user.Id
             && p.IsAccepted == AcceptedTypes.Accepte)
                .OrderByDescending(p => p.ModifiedDate)
                .ToListAsync();
            return View(await vendor);
        }
        public async Task<IActionResult> IsAcssept(long? id,AcceptedTypes AccessTypeId,string Reason)
        {

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try
                {
                    product.IsAccepted = AccessTypeId;
                    product.Reason = Reason;
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
            }
            ViewData["CorroborantId"] = new SelectList(_context.Corroborants, "Id", "Id", product.CorroborantId);
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Id", product.ProductTypeId);
            return RedirectToAction(nameof(Index));
        }
        // GET: VendorService/Products/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            ViewData["CorroborantId"] = new SelectList(_context.Corroborants, "Id", "Name");
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name");
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Name");
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Corroborant)
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: VendorService/Products/Create
        public IActionResult Create()
        {
          
            ViewData["CorroborantId"] = new SelectList(_context.Corroborants, "Id", "Name");
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name");
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Name");
            return View();
        }

        // POST: VendorService/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Root dd,IFormFile  UploadControlForm)
        {

            //IFormFile ggg = (IFormFile) dd.UploadControlForm;

            //string newFileName = string.Empty;


            //newFileName = Guid.NewGuid().ToString() + Path.GetExtension(ggg.FileName);

            //string ImagePath = Path.Combine(_enviroment.WebRootPath, "image/Document") + $@"\{newFileName}";
            //using (var Stream = new FileStream(ImagePath, FileMode.Create))
            //{
            //    await ggg.CopyToAsync(Stream);
            //}

            //return newFileName;




            var user = await _usermanager.GetUserAsync(User);
            //product.UserId=user.Id;
            //product.CreateDate= DateTime.UtcNow;

            //product.ModifiedDate= DateTime.UtcNow;
            //FileManager fileManager = new FileManager(_enviroment);
            //if (UploadControlForm != null)
            //    product.UploadControlForm = await fileManager.InsertFiles(UploadControlForm, "image/Document");

            //if (ModelState.IsValid)
            //{
            //    _context.Add(product);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["CorroborantId"] = new SelectList(_context.Corroborants, "Id", "Id", product.CorroborantId);
            //ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Id", product.ProductTypeId);
            //return View(product);
            return View(user);
        }

        // GET: VendorService/Products/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CorroborantId"] = new SelectList(_context.Corroborants, "Id", "Name");
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name");
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Name");
            return View(product);
        }

        // POST: VendorService/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Code,Description,Guarantee,Environment,IsAccepted,UploadControlForm,ProductTypeId,CorroborantId,CompanyId,ManufacturerCenters")] Product product)
        {
            //product.UserId = _usermanager.GetUserAsync(User).Id.ToString();

            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (product.IsAccepted==AcceptedTypes.Reject)
                    {
                        product.IsAccepted = AcceptedTypes.Edited;
                    }
                    product.ModifiedDate = DateTime.UtcNow;

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
            }
            ViewData["CorroborantId"] = new SelectList(_context.Corroborants, "Id", "Id", product.CorroborantId);
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Id", product.ProductTypeId);
            return View(product);
        }

        // GET: VendorService/Products/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Corroborant)
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: VendorService/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(long id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
      
        
    }
}
