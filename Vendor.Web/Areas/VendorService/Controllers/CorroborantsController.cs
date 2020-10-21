using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Corroborants;
using Vendor.Utilities.Files;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class CorroborantsController : Controller
    {
        private readonly VendorDbContext _context;
        private readonly IWebHostEnvironment _enviroment;

        public CorroborantsController(VendorDbContext context, IWebHostEnvironment enviroment)
        {
            _context = context;
            _enviroment = enviroment;
        }

        // GET: VendorService/Corroborants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Corroborants.ToListAsync());
        }

        // GET: VendorService/Corroborants/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corroborant = await _context.Corroborants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (corroborant == null)
            {
                return NotFound();
            }

            return View(corroborant);
        }

        // GET: VendorService/Corroborants/Create
        public IActionResult Create()
        {
            ViewData["CorroborantTypeId"] = new SelectList(_context.CorroborantTypes, "Id", "Name");
            return View();
        }

        // POST: VendorService/Corroborants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate,CorroborantTypeId,Name")] Corroborant corroborant,
            IFormFile UploadLinces, string startdate, string enddate)
        {
            FileManager fileManager = new FileManager(_enviroment);
            if (UploadLinces != null)
                corroborant.UploadLinces = await fileManager.InsertFiles(UploadLinces, "image/Document");

            DateTime sdate = Convert.ToDateTime(startdate);
            DateTime edate = Convert.ToDateTime(enddate);

            if (ModelState.IsValid)
            {
                corroborant.StartDate = sdate;
                corroborant.EndDate = edate;
                _context.Add(corroborant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CorroborantTypeId"] = new SelectList(_context.Corroborants, "Id", "Id", corroborant.CorroborantTypeId);

            return View(corroborant);
        }
        // GET: VendorService/Corroborants/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corroborant = await _context.Corroborants.FindAsync(id);
            if (corroborant == null)
            {
                return NotFound();
            }
            ViewData["CorroborantTypeId"] = new SelectList(_context.CorroborantTypes, "Id", "Name");

            return View(corroborant);
        }

        // POST: VendorService/Corroborants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,UploadLinces,CorroborantTypeId,Name")] Corroborant corroborant,
            IFormFile UploadLinces, string startdate, string enddate)
        {
            DateTime sdate = Convert.ToDateTime(startdate);
            DateTime edate = Convert.ToDateTime(enddate);
            if (id != corroborant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    corroborant.StartDate = sdate;
                    corroborant.EndDate = edate;
                    _context.Update(corroborant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorroborantExists(corroborant.Id))
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
            ViewData["CorroborantTypeId"] = new SelectList(_context.CorroborantTypes, "Id", "Name");

            return View(corroborant);
        }

        // GET: VendorService/Corroborants/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corroborant = await _context.Corroborants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (corroborant == null)
            {
                return NotFound();
            }

            return View(corroborant);
        }

        // POST: VendorService/Corroborants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var corroborant = await _context.Corroborants.FindAsync(id);
            _context.Corroborants.Remove(corroborant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CorroborantExists(long id)
        {
            return _context.Corroborants.Any(e => e.Id == id);
        }
    }
}
