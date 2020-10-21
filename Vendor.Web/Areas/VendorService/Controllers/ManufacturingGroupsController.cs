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
    public class ManufacturingGroupsController : Controller
    {
        private readonly VendorDbContext _context;

        public ManufacturingGroupsController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/ManufacturingGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.ManufacturingGroups.ToListAsync());
        }

        // GET: VendorService/ManufacturingGroups/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturingGroup = await _context.ManufacturingGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (manufacturingGroup == null)
            {
                return NotFound();
            }

            return View(manufacturingGroup);
        }

        // GET: VendorService/ManufacturingGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorService/ManufacturingGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ManufacturingGroup manufacturingGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(manufacturingGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manufacturingGroup);
        }

        // GET: VendorService/ManufacturingGroups/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturingGroup = await _context.ManufacturingGroups.FindAsync(id);
            if (manufacturingGroup == null)
            {
                return NotFound();
            }
            return View(manufacturingGroup);
        }

        // POST: VendorService/ManufacturingGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] ManufacturingGroup manufacturingGroup)
        {
            if (id != manufacturingGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(manufacturingGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManufacturingGroupExists(manufacturingGroup.Id))
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
            return View(manufacturingGroup);
        }

        // GET: VendorService/ManufacturingGroups/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturingGroup = await _context.ManufacturingGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (manufacturingGroup == null)
            {
                return NotFound();
            }

            return View(manufacturingGroup);
        }

        // POST: VendorService/ManufacturingGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var manufacturingGroup = await _context.ManufacturingGroups.FindAsync(id);
            _context.ManufacturingGroups.Remove(manufacturingGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManufacturingGroupExists(long id)
        {
            return _context.ManufacturingGroups.Any(e => e.Id == id);
        }
    }
}
