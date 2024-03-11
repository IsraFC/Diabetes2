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
    public class GlucoseMonitoringsController : Controller
    {
        private readonly DataContext _context;

        public GlucoseMonitoringsController(DataContext context)
        {
            _context = context;
        }

        // GET: GlucoseMonitorings
        public async Task<IActionResult> Index()
        {
            return View(await _context.GlucoseMonitorings.ToListAsync());
        }

        // GET: GlucoseMonitorings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glucoseMonitoring = await _context.GlucoseMonitorings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (glucoseMonitoring == null)
            {
                return NotFound();
            }

            return View(glucoseMonitoring);
        }

        // GET: GlucoseMonitorings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GlucoseMonitorings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GlucoseIn,FoodReport")] GlucoseMonitoring glucoseMonitoring)
        {
            if (ModelState.IsValid)
            {
                _context.Add(glucoseMonitoring);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(glucoseMonitoring);
        }

        // GET: GlucoseMonitorings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glucoseMonitoring = await _context.GlucoseMonitorings.FindAsync(id);
            if (glucoseMonitoring == null)
            {
                return NotFound();
            }
            return View(glucoseMonitoring);
        }

        // POST: GlucoseMonitorings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GlucoseIn,FoodReport")] GlucoseMonitoring glucoseMonitoring)
        {
            if (id != glucoseMonitoring.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(glucoseMonitoring);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GlucoseMonitoringExists(glucoseMonitoring.Id))
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
            return View(glucoseMonitoring);
        }

        // GET: GlucoseMonitorings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glucoseMonitoring = await _context.GlucoseMonitorings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (glucoseMonitoring == null)
            {
                return NotFound();
            }

            return View(glucoseMonitoring);
        }

        // POST: GlucoseMonitorings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var glucoseMonitoring = await _context.GlucoseMonitorings.FindAsync(id);
            if (glucoseMonitoring != null)
            {
                _context.GlucoseMonitorings.Remove(glucoseMonitoring);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GlucoseMonitoringExists(int id)
        {
            return _context.GlucoseMonitorings.Any(e => e.Id == id);
        }
    }
}
