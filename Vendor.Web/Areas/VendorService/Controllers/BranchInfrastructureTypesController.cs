using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Branch;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class BranchInfrastructureTypesController : Controller
    {
        private readonly VendorDbContext _context;

        public BranchInfrastructureTypesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/BranchInfrastructureTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BranchInfrastructureType.ToListAsync());
        }

        // GET: VendorService/BranchInfrastructureTypes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchInfrastructureType = await _context.BranchInfrastructureType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchInfrastructureType == null)
            {
                return NotFound();
            }

            return View(branchInfrastructureType);
        }

        // GET: VendorService/BranchInfrastructureTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorService/BranchInfrastructureTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] BranchInfrastructureType branchInfrastructureType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchInfrastructureType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branchInfrastructureType);
        }

        // GET: VendorService/BranchInfrastructureTypes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchInfrastructureType = await _context.BranchInfrastructureType.FindAsync(id);
            if (branchInfrastructureType == null)
            {
                return NotFound();
            }
            return View(branchInfrastructureType);
        }

        // POST: VendorService/BranchInfrastructureTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] BranchInfrastructureType branchInfrastructureType)
        {
            if (id != branchInfrastructureType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchInfrastructureType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchInfrastructureTypeExists(branchInfrastructureType.Id))
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
            return View(branchInfrastructureType);
        }

        // GET: VendorService/BranchInfrastructureTypes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchInfrastructureType = await _context.BranchInfrastructureType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchInfrastructureType == null)
            {
                return NotFound();
            }

            return View(branchInfrastructureType);
        }

        // POST: VendorService/BranchInfrastructureTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var branchInfrastructureType = await _context.BranchInfrastructureType.FindAsync(id);
            _context.BranchInfrastructureType.Remove(branchInfrastructureType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchInfrastructureTypeExists(long id)
        {
            return _context.BranchInfrastructureType.Any(e => e.Id == id);
        }
    }
}
