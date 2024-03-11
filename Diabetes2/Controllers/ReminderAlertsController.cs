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
    public class ReminderAlertsController : Controller
    {
        private readonly DataContext _context;

        public ReminderAlertsController(DataContext context)
        {
            _context = context;
        }

        // GET: ReminderAlerts
        public async Task<IActionResult> Index()
        {
            return View(await _context.reminderAlerts.ToListAsync());
        }

        // GET: ReminderAlerts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminderAlert = await _context.reminderAlerts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reminderAlert == null)
            {
                return NotFound();
            }

            return View(reminderAlert);
        }

        // GET: ReminderAlerts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReminderAlerts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HoraRecordatorio,SeguimientoDieta")] ReminderAlert reminderAlert)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reminderAlert);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reminderAlert);
        }

        // GET: ReminderAlerts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminderAlert = await _context.reminderAlerts.FindAsync(id);
            if (reminderAlert == null)
            {
                return NotFound();
            }
            return View(reminderAlert);
        }

        // POST: ReminderAlerts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HoraRecordatorio,SeguimientoDieta")] ReminderAlert reminderAlert)
        {
            if (id != reminderAlert.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reminderAlert);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReminderAlertExists(reminderAlert.Id))
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
            return View(reminderAlert);
        }

        // GET: ReminderAlerts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminderAlert = await _context.reminderAlerts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reminderAlert == null)
            {
                return NotFound();
            }

            return View(reminderAlert);
        }

        // POST: ReminderAlerts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reminderAlert = await _context.reminderAlerts.FindAsync(id);
            if (reminderAlert != null)
            {
                _context.reminderAlerts.Remove(reminderAlert);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReminderAlertExists(int id)
        {
            return _context.reminderAlerts.Any(e => e.Id == id);
        }
    }
}
