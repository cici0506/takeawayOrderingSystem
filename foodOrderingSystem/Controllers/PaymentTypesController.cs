﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using foodOrderingSystem.Data;
using foodOrderingSystem.Models;

namespace foodOrderingSystem.Controllers
{
    public class PaymentTypesController : Controller
    {
        private readonly FoodOrderingSystemContext _context;

        public PaymentTypesController(FoodOrderingSystemContext context)
        {
            _context = context;
        }

        // GET: PaymentTypes
        public async Task<IActionResult> Index()
        {
              return _context.PaymentTypes != null ? 
                          View(await _context.PaymentTypes.ToListAsync()) :
                          Problem("Entity set 'FoodOrderingSystemContext.PaymentTypes'  is null.");
        }

        // GET: PaymentTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PaymentTypes == null)
            {
                return NotFound();
            }

            var paymentType = await _context.PaymentTypes
                .FirstOrDefaultAsync(m => m.PaymentTypeId == id);
            if (paymentType == null)
            {
                return NotFound();
            }

            return View(paymentType);
        }

        // GET: PaymentTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentTypeId,PaymentType1")] PaymentType paymentType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentType);
        }

        // GET: PaymentTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PaymentTypes == null)
            {
                return NotFound();
            }

            var paymentType = await _context.PaymentTypes.FindAsync(id);
            if (paymentType == null)
            {
                return NotFound();
            }
            return View(paymentType);
        }

        // POST: PaymentTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaymentTypeId,PaymentType1")] PaymentType paymentType)
        {
            if (id != paymentType.PaymentTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentTypeExists(paymentType.PaymentTypeId))
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
            return View(paymentType);
        }

        // GET: PaymentTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PaymentTypes == null)
            {
                return NotFound();
            }

            var paymentType = await _context.PaymentTypes
                .FirstOrDefaultAsync(m => m.PaymentTypeId == id);
            if (paymentType == null)
            {
                return NotFound();
            }

            return View(paymentType);
        }

        // POST: PaymentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PaymentTypes == null)
            {
                return Problem("Entity set 'FoodOrderingSystemContext.PaymentTypes'  is null.");
            }
            var paymentType = await _context.PaymentTypes.FindAsync(id);
            if (paymentType != null)
            {
                _context.PaymentTypes.Remove(paymentType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentTypeExists(int id)
        {
          return (_context.PaymentTypes?.Any(e => e.PaymentTypeId == id)).GetValueOrDefault();
        }
    }
}
