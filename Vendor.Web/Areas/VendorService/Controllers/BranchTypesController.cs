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
    public class BranchTypesController : Controller
    {
        private readonly VendorDbContext _context;

        public BranchTypesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/BranchTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BranchTypes.ToListAsync());
        }

        // GET: VendorService/BranchTypes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchType = await _context.BranchTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchType == null)
            {
                return NotFound();
            }

            return View(branchType);
        }

        // GET: VendorService/BranchTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorService/BranchTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] BranchType branchType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branchType);
        }

        // GET: VendorService/BranchTypes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchType = await _context.BranchTypes.FindAsync(id);
            if (branchType == null)
            {
                return NotFound();
            }
            return View(branchType);
        }

        // POST: VendorService/BranchTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] BranchType branchType)
        {
            if (id != branchType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchTypeExists(branchType.Id))
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
            return View(branchType);
        }

        // GET: VendorService/BranchTypes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchType = await _context.BranchTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchType == null)
            {
                return NotFound();
            }

            return View(branchType);
        }

        // POST: VendorService/BranchTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var branchType = await _context.BranchTypes.FindAsync(id);
            _context.BranchTypes.Remove(branchType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchTypeExists(long id)
        {
            return _context.BranchTypes.Any(e => e.Id == id);
        }
    }
}
