using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Diabetes2.Data;
using Diabetes2.Data.Entities;

namespace Diabetes2.Controllers
{
    public class HealthcarePsController : Controller
    {
        private readonly DataContext _context;

        public HealthcarePsController(DataContext context)
        {
            _context = context;
        }

        // GET: HealthcarePs
        public async Task<IActionResult> Index()
        {
            return View(await _context.HealthcarePs.ToListAsync());
        }

        // GET: HealthcarePs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthcareP = await _context.HealthcarePs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (healthcareP == null)
            {
                return NotFound();
            }

            return View(healthcareP);
        }

        // GET: HealthcarePs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HealthcarePs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Name,profession")] HealthcareP healthcareP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(healthcareP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(healthcareP);
        }

        // GET: HealthcarePs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthcareP = await _context.HealthcarePs.FindAsync(id);
            if (healthcareP == null)
            {
                return NotFound();
            }
            return View(healthcareP);
        }

        // POST: HealthcarePs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Name,profession")] HealthcareP healthcareP)
        {
            if (id != healthcareP.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(healthcareP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HealthcarePExists(healthcareP.Id))
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
            return View(healthcareP);
        }

        // GET: HealthcarePs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthcareP = await _context.HealthcarePs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (healthcareP == null)
            {
                return NotFound();
            }

            return View(healthcareP);
        }

        // POST: HealthcarePs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var healthcareP = await _context.HealthcarePs.FindAsync(id);
            if (healthcareP != null)
            {
                _context.HealthcarePs.Remove(healthcareP);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HealthcarePExists(int id)
        {
            return _context.HealthcarePs.Any(e => e.Id == id);
        }
    }
}
