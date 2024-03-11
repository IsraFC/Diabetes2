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
    public class MealPlanningsController : Controller
    {
        private readonly DataContext _context;

        public MealPlanningsController(DataContext context)
        {
            _context = context;
        }

        // GET: MealPlannings
        public async Task<IActionResult> Index()
        {
            return View(await _context.MealPlannings.ToListAsync());
        }

        // GET: MealPlannings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealPlanning = await _context.MealPlannings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mealPlanning == null)
            {
                return NotFound();
            }

            return View(mealPlanning);
        }

        // GET: MealPlannings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MealPlannings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Recipes,PMealPlans")] MealPlanning mealPlanning)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mealPlanning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mealPlanning);
        }

        // GET: MealPlannings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealPlanning = await _context.MealPlannings.FindAsync(id);
            if (mealPlanning == null)
            {
                return NotFound();
            }
            return View(mealPlanning);
        }

        // POST: MealPlannings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Recipes,PMealPlans")] MealPlanning mealPlanning)
        {
            if (id != mealPlanning.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mealPlanning);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealPlanningExists(mealPlanning.Id))
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
            return View(mealPlanning);
        }

        // GET: MealPlannings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealPlanning = await _context.MealPlannings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mealPlanning == null)
            {
                return NotFound();
            }

            return View(mealPlanning);
        }

        // POST: MealPlannings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mealPlanning = await _context.MealPlannings.FindAsync(id);
            if (mealPlanning != null)
            {
                _context.MealPlannings.Remove(mealPlanning);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MealPlanningExists(int id)
        {
            return _context.MealPlannings.Any(e => e.Id == id);
        }
    }
}
