﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendor.Datalayer;
using Vendor.Domain.Entites.Customers;

namespace Vendor.Web.Areas.VendorService.Controllers
{
    [Area("VendorService")]
    public class CustomersController : Controller
    {
        private readonly VendorDbContext _context;

        public CustomersController(VendorDbContext context)
        {
            _context = context;
        }

        // GET: VendorService/Customers
        public async Task<IActionResult> Index()
        {
            var vendorDbContext = _context.Customers.Include(c => c.CustomerType);
            return View(await vendorDbContext.ToListAsync());
        }

        // GET: VendorService/Customers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.CustomerType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: VendorService/Customers/Create
        public IActionResult Create()
        {
            ViewData["CustomerTypeId"] = new SelectList(_context.CustomerTypes, "Id", "Id");
            return View();
        }

        // POST: VendorService/Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Family,FatherName,NationalCode,IDNumber,BirthDate,DegreeEducation,Tel,Fax,Email,Post,WorkExperience,TheSignatory,CustomerTypeId,UserId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerTypeId"] = new SelectList(_context.CustomerTypes, "Id", "Id", customer.CustomerTypeId);
            return View(customer);
        }

        // GET: VendorService/Customers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["CustomerTypeId"] = new SelectList(_context.CustomerTypes, "Id", "Id", customer.CustomerTypeId);
            return View(customer);
        }

        // POST: VendorService/Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Family,FatherName,NationalCode,IDNumber,BirthDate,DegreeEducation,Tel,Fax,Email,Post,WorkExperience,TheSignatory,CustomerTypeId,UserId")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
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
            ViewData["CustomerTypeId"] = new SelectList(_context.CustomerTypes, "Id", "Id", customer.CustomerTypeId);
            return View(customer);
        }

        // GET: VendorService/Customers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.CustomerType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: VendorService/Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(long id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
