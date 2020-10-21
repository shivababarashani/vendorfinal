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
    public class OwnershipTypesController : Controller
    {
        private readonly VendorDbContext _context;

        public OwnershipTypesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/OwnershipTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.OwnershipType.ToListAsync());
        }

        // GET: VendorService/OwnershipTypes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ownershipType = await _context.OwnershipType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ownershipType == null)
            {
                return NotFound();
            }

            return View(ownershipType);
        }

        // GET: VendorService/OwnershipTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorService/OwnershipTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] OwnershipType ownershipType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ownershipType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ownershipType);
        }

        // GET: VendorService/OwnershipTypes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ownershipType = await _context.OwnershipType.FindAsync(id);
            if (ownershipType == null)
            {
                return NotFound();
            }
            return View(ownershipType);
        }

        // POST: VendorService/OwnershipTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] OwnershipType ownershipType)
        {
            if (id != ownershipType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ownershipType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OwnershipTypeExists(ownershipType.Id))
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
            return View(ownershipType);
        }

        // GET: VendorService/OwnershipTypes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ownershipType = await _context.OwnershipType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ownershipType == null)
            {
                return NotFound();
            }

            return View(ownershipType);
        }

        // POST: VendorService/OwnershipTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var ownershipType = await _context.OwnershipType.FindAsync(id);
            _context.OwnershipType.Remove(ownershipType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OwnershipTypeExists(long id)
        {
            return _context.OwnershipType.Any(e => e.Id == id);
        }
    }
}
