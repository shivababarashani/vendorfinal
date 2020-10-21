using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Companies;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class CompanyTypesController : Controller
    {
        private readonly VendorDbContext _context;

        public CompanyTypesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/CompanyTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyTypes.ToListAsync());
        }

        // GET: VendorService/CompanyTypes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyType = await _context.CompanyTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyType == null)
            {
                return NotFound();
            }

            return View(companyType);
        }

        // GET: VendorService/CompanyTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorService/CompanyTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] CompanyType companyType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyType);
        }

        // GET: VendorService/CompanyTypes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyType = await _context.CompanyTypes.FindAsync(id);
            if (companyType == null)
            {
                return NotFound();
            }
            return View(companyType);
        }

        // POST: VendorService/CompanyTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] CompanyType companyType)
        {
            if (id != companyType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyTypeExists(companyType.Id))
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
            return View(companyType);
        }

        // GET: VendorService/CompanyTypes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var companyType = await _context.CompanyTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyType == null)
            {
                return NotFound();
            }

            return View(companyType);
        }

        // POST: VendorService/CompanyTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var companyType = await _context.CompanyTypes.FindAsync(id);
            _context.CompanyTypes.Remove(companyType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyTypeExists(long id)
        {
            return _context.CompanyTypes.Any(e => e.Id == id);
        }
    }
}
