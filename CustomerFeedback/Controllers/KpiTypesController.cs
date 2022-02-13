#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CustomerFeedback.Data;
using CustomerFeedback.Models;

namespace CustomerFeedback.Controllers
{
    public class KpiTypesController : Controller
    {
        private readonly CSATContext _context;

        public KpiTypesController(CSATContext context)
        {
            _context = context;
        }

        // GET: KpiTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.KpiType.ToListAsync());
        }

        // GET: KpiTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kpiType = await _context.KpiType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpiType == null)
            {
                return NotFound();
            }

            return View(kpiType);
        }

        // GET: KpiTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KpiTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Description")] KpiType kpiType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kpiType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kpiType);
        }

        // GET: KpiTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kpiType = await _context.KpiType.FindAsync(id);
            if (kpiType == null)
            {
                return NotFound();
            }
            return View(kpiType);
        }

        // POST: KpiTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Description")] KpiType kpiType)
        {
            if (id != kpiType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kpiType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KpiTypeExists(kpiType.Id))
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
            return View(kpiType);
        }

        // GET: KpiTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kpiType = await _context.KpiType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpiType == null)
            {
                return NotFound();
            }

            return View(kpiType);
        }

        // POST: KpiTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kpiType = await _context.KpiType.FindAsync(id);
            _context.KpiType.Remove(kpiType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KpiTypeExists(int id)
        {
            return _context.KpiType.Any(e => e.Id == id);
        }
    }
}
