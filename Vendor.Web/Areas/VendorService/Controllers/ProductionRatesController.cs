using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.ProductionRates;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class ProductionRatesController : Controller
    {
        private readonly VendorDbContext _context;

        public ProductionRatesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/ProductionRates
        public async Task<IActionResult> Index()
        {
            var vendorDbContext = _context.ProductionRates.Include(p => p.Product);
            return View(await vendorDbContext.ToListAsync());
        }

        // GET: VendorService/ProductionRates/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionRate = await _context.ProductionRates
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productionRate == null)
            {
                return NotFound();
            }

            return View(productionRate);
        }

        // GET: VendorService/ProductionRates/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return View();
        }

        // POST: VendorService/ProductionRates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Year,Amount,ProductId,UserId")] ProductionRate productionRate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productionRate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", productionRate.ProductId);
            return View(productionRate);
        }

        // GET: VendorService/ProductionRates/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionRate = await _context.ProductionRates.FindAsync(id);
            if (productionRate == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", productionRate.ProductId);
            return View(productionRate);
        }

        // POST: VendorService/ProductionRates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Year,Amount,ProductId,UserId")] ProductionRate productionRate)
        {
            if (id != productionRate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productionRate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductionRateExists(productionRate.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", productionRate.ProductId);
            return View(productionRate);
        }

        // GET: VendorService/ProductionRates/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionRate = await _context.ProductionRates
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productionRate == null)
            {
                return NotFound();
            }

            return View(productionRate);
        }

        // POST: VendorService/ProductionRates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var productionRate = await _context.ProductionRates.FindAsync(id);
            _context.ProductionRates.Remove(productionRate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductionRateExists(long id)
        {
            return _context.ProductionRates.Any(e => e.Id == id);
        }
    }
}
