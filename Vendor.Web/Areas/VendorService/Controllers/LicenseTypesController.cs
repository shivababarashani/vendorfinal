using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Licenses;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class LicenseTypesController : Controller
    {
        private readonly VendorDbContext _context;

        public LicenseTypesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/LicenseTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.LicenseTypes.ToListAsync());
        }

        // GET: VendorService/LicenseTypes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licenseType = await _context.LicenseTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licenseType == null)
            {
                return NotFound();
            }

            return View(licenseType);
        }

        // GET: VendorService/LicenseTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorService/LicenseTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] LicenseType licenseType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(licenseType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(licenseType);
        }

        // GET: VendorService/LicenseTypes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licenseType = await _context.LicenseTypes.FindAsync(id);
            if (licenseType == null)
            {
                return NotFound();
            }
            return View(licenseType);
        }

        // POST: VendorService/LicenseTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] LicenseType licenseType)
        {
            if (id != licenseType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(licenseType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicenseTypeExists(licenseType.Id))
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
            return View(licenseType);
        }

        // GET: VendorService/LicenseTypes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licenseType = await _context.LicenseTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licenseType == null)
            {
                return NotFound();
            }

            return View(licenseType);
        }

        // POST: VendorService/LicenseTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var licenseType = await _context.LicenseTypes.FindAsync(id);
            _context.LicenseTypes.Remove(licenseType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicenseTypeExists(long id)
        {
            return _context.LicenseTypes.Any(e => e.Id == id);
        }
    }
}
