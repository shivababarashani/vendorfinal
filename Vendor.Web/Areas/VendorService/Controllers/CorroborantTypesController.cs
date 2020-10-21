using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Corroborants;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class CorroborantTypesController : Controller
    {
        private readonly VendorDbContext _context;

        public CorroborantTypesController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/CorroborantTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CorroborantTypes.ToListAsync());
        }

        // GET: VendorService/CorroborantTypes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corroborantType = await _context.CorroborantTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (corroborantType == null)
            {
                return NotFound();
            }

            return View(corroborantType);
        }

        // GET: VendorService/CorroborantTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorService/CorroborantTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] CorroborantType corroborantType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(corroborantType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(corroborantType);
        }

        // GET: VendorService/CorroborantTypes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corroborantType = await _context.CorroborantTypes.FindAsync(id);
            if (corroborantType == null)
            {
                return NotFound();
            }
            return View(corroborantType);
        }

        // POST: VendorService/CorroborantTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name")] CorroborantType corroborantType)
        {
            if (id != corroborantType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(corroborantType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorroborantTypeExists(corroborantType.Id))
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
            return View(corroborantType);
        }

        // GET: VendorService/CorroborantTypes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corroborantType = await _context.CorroborantTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (corroborantType == null)
            {
                return NotFound();
            }

            return View(corroborantType);
        }

        // POST: VendorService/CorroborantTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var corroborantType = await _context.CorroborantTypes.FindAsync(id);
            _context.CorroborantTypes.Remove(corroborantType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CorroborantTypeExists(long id)
        {
            return _context.CorroborantTypes.Any(e => e.Id == id);
        }
    }
}
