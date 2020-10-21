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
    public class BranchStaffTypesController : Controller
    {
        private readonly VendorDbContext _context;

        public BranchStaffTypesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/BranchStaffTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BranchStaffType.ToListAsync());
        }

        // GET: VendorService/BranchStaffTypes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchStaffType = await _context.BranchStaffType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchStaffType == null)
            {
                return NotFound();
            }

            return View(branchStaffType);
        }

        // GET: VendorService/BranchStaffTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorService/BranchStaffTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] BranchStaffType branchStaffType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchStaffType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branchStaffType);
        }

        // GET: VendorService/BranchStaffTypes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchStaffType = await _context.BranchStaffType.FindAsync(id);
            if (branchStaffType == null)
            {
                return NotFound();
            }
            return View(branchStaffType);
        }

        // POST: VendorService/BranchStaffTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] BranchStaffType branchStaffType)
        {
            if (id != branchStaffType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchStaffType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchStaffTypeExists(branchStaffType.Id))
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
            return View(branchStaffType);
        }

        // GET: VendorService/BranchStaffTypes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branchStaffType = await _context.BranchStaffType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchStaffType == null)
            {
                return NotFound();
            }

            return View(branchStaffType);
        }

        // POST: VendorService/BranchStaffTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var branchStaffType = await _context.BranchStaffType.FindAsync(id);
            _context.BranchStaffType.Remove(branchStaffType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchStaffTypeExists(long id)
        {
            return _context.BranchStaffType.Any(e => e.Id == id);
        }
    }
}
