using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Market.Data;
using Market.Models;

namespace Market.Controllers
{
    public class ReyonlarController : Controller
    {
        private readonly MarketDbContext _context;

        public ReyonlarController(MarketDbContext context)
        {
            _context = context;
        }

        // GET: Reyonlar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reyonlars.ToListAsync());
        }

        // GET: Reyonlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reyonlar = await _context.Reyonlars
                .FirstOrDefaultAsync(m => m.reyonNo == id);
            if (reyonlar == null)
            {
                return NotFound();
            }

            return View(reyonlar);
        }

        // GET: Reyonlar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reyonlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("reyonNo,reyonAdi")] Reyonlar reyonlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reyonlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reyonlar);
        }

        // GET: Reyonlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reyonlar = await _context.Reyonlars.FindAsync(id);
            if (reyonlar == null)
            {
                return NotFound();
            }
            return View(reyonlar);
        }

        // POST: Reyonlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("reyonNo,reyonAdi")] Reyonlar reyonlar)
        {
            if (id != reyonlar.reyonNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reyonlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReyonlarExists(reyonlar.reyonNo))
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
            return View(reyonlar);
        }

        // GET: Reyonlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reyonlar = await _context.Reyonlars
                .FirstOrDefaultAsync(m => m.reyonNo == id);
            if (reyonlar == null)
            {
                return NotFound();
            }

            return View(reyonlar);
        }

        // POST: Reyonlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reyonlar = await _context.Reyonlars.FindAsync(id);
            _context.Reyonlars.Remove(reyonlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReyonlarExists(int id)
        {
            return _context.Reyonlars.Any(e => e.reyonNo == id);
        }
    }
}
