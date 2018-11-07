using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArchpointMvcPHR.Models;

namespace ArchpointMvcPHR.Controllers
{
    public class MentalHealthHistoriesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public MentalHealthHistoriesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: MentalHealthHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.MentalHealthHistory.ToListAsync());
        }

        // GET: MentalHealthHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mentalHealthHistory = await _context.MentalHealthHistory
                .FirstOrDefaultAsync(m => m.MentalHealthHistoryid == id);
            if (mentalHealthHistory == null)
            {
                return NotFound();
            }

            return View(mentalHealthHistory);
        }

        // GET: MentalHealthHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MentalHealthHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MentalHealthHistoryid,CurrentTreatmentForMentalDisorder,MedCareLocationId,TypeOfTreatment,TreatedInPast,MentalConditionDisorder,CurrentMedication,MedicalProviderId,Comments")] MentalHealthHistory mentalHealthHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mentalHealthHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mentalHealthHistory);
        }

        // GET: MentalHealthHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mentalHealthHistory = await _context.MentalHealthHistory.FindAsync(id);
            if (mentalHealthHistory == null)
            {
                return NotFound();
            }
            return View(mentalHealthHistory);
        }

        // POST: MentalHealthHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MentalHealthHistoryid,CurrentTreatmentForMentalDisorder,MedCareLocationId,TypeOfTreatment,TreatedInPast,MentalConditionDisorder,CurrentMedication,MedicalProviderId,Comments")] MentalHealthHistory mentalHealthHistory)
        {
            if (id != mentalHealthHistory.MentalHealthHistoryid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mentalHealthHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MentalHealthHistoryExists(mentalHealthHistory.MentalHealthHistoryid))
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
            return View(mentalHealthHistory);
        }

        // GET: MentalHealthHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mentalHealthHistory = await _context.MentalHealthHistory
                .FirstOrDefaultAsync(m => m.MentalHealthHistoryid == id);
            if (mentalHealthHistory == null)
            {
                return NotFound();
            }

            return View(mentalHealthHistory);
        }

        // POST: MentalHealthHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mentalHealthHistory = await _context.MentalHealthHistory.FindAsync(id);
            _context.MentalHealthHistory.Remove(mentalHealthHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MentalHealthHistoryExists(int id)
        {
            return _context.MentalHealthHistory.Any(e => e.MentalHealthHistoryid == id);
        }
    }
}
