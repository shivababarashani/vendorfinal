using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Licenses;

namespace Vendor.Web.Areas.VendorService.Views
{
    [Area("VendorService")]
    public class LicensesController : Controller
    {
        private readonly VendorDbContext _context;

        public LicensesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/Licenses
        public async Task<IActionResult> Index()
        {
            var vendorDbContext = _context.Licenses.Include(l => l.LicenseType);
            return View(await vendorDbContext.ToListAsync());
        }

        // GET: VendorService/Licenses/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var license = await _context.Licenses
                .Include(l => l.LicenseType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (license == null)
            {
                return NotFound();
            }

            return View(license);
        }

        // GET: VendorService/Licenses/Create
        public IActionResult Create()
        {
            ViewData["LicenseTypeId"] = new SelectList(_context.LicenseTypes, "Id", "Id");
            return View();
        }

        // POST: VendorService/Licenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate,UploadLinces,LicenseTypeId,UserId")] License license)
        {
            if (ModelState.IsValid)
            {
                _context.Add(license);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LicenseTypeId"] = new SelectList(_context.LicenseTypes, "Id", "Id", license.LicenseTypeId);
            return View(license);
        }

        // GET: VendorService/Licenses/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var license = await _context.Licenses.FindAsync(id);
            if (license == null)
            {
                return NotFound();
            }
            ViewData["LicenseTypeId"] = new SelectList(_context.LicenseTypes, "Id", "Id", license.LicenseTypeId);
            return View(license);
        }

        // POST: VendorService/Licenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,StartDate,EndDate,UploadLinces,LicenseTypeId,UserId")] License license)
        {
            if (id != license.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(license);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicenseExists(license.Id))
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
            ViewData["LicenseTypeId"] = new SelectList(_context.LicenseTypes, "Id", "Id", license.LicenseTypeId);
            return View(license);
        }

        // GET: VendorService/Licenses/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var license = await _context.Licenses
                .Include(l => l.LicenseType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (license == null)
            {
                return NotFound();
            }

            return View(license);
        }

        // POST: VendorService/Licenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var license = await _context.Licenses.FindAsync(id);
            _context.Licenses.Remove(license);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicenseExists(long id)
        {
            return _context.Licenses.Any(e => e.Id == id);
        }
    }
}
