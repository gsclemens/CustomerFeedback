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
    public class CommodityTypesController : Controller
    {
        private readonly CSATContext _context;

        public CommodityTypesController(CSATContext context)
        {
            _context = context;
        }

        // GET: CommodityTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommodityType.ToListAsync());
        }

        // GET: CommodityTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commodityType = await _context.CommodityType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commodityType == null)
            {
                return NotFound();
            }

            return View(commodityType);
        }

        // GET: CommodityTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommodityTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Description")] CommodityType commodityType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commodityType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(commodityType);
        }

        // GET: CommodityTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commodityType = await _context.CommodityType.FindAsync(id);
            if (commodityType == null)
            {
                return NotFound();
            }
            return View(commodityType);
        }

        // POST: CommodityTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Description")] CommodityType commodityType)
        {
            if (id != commodityType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commodityType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommodityTypeExists(commodityType.Id))
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
            return View(commodityType);
        }

        // GET: CommodityTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commodityType = await _context.CommodityType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commodityType == null)
            {
                return NotFound();
            }

            return View(commodityType);
        }

        // POST: CommodityTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commodityType = await _context.CommodityType.FindAsync(id);
            _context.CommodityType.Remove(commodityType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommodityTypeExists(int id)
        {
            return _context.CommodityType.Any(e => e.Id == id);
        }
    }
}
