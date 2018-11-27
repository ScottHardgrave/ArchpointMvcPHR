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
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class SurgicalHistoriesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public SurgicalHistoriesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: SurgicalHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.SurgicalHistory.ToListAsync());
        }

        // GET: SurgicalHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surgicalHistory = await _context.SurgicalHistory
                .FirstOrDefaultAsync(m => m.SurgicalHistoryId == id);
            if (surgicalHistory == null)
            {
                return NotFound();
            }

            return View(surgicalHistory);
        }

        // GET: SurgicalHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SurgicalHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurgicalHistoryId,SurgeryProcedure,DateOfSurgeryProcedure,MedProviderId,MedCareLocationId,ProblemWithAnesthesia,AnesthesiaProblemExplanation")] SurgicalHistory surgicalHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(surgicalHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(surgicalHistory);
        }

        // GET: SurgicalHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surgicalHistory = await _context.SurgicalHistory.FindAsync(id);
            if (surgicalHistory == null)
            {
                return NotFound();
            }
            return View(surgicalHistory);
        }

        // POST: SurgicalHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurgicalHistoryId,SurgeryProcedure,DateOfSurgeryProcedure,MedProviderId,MedCareLocationId,ProblemWithAnesthesia,AnesthesiaProblemExplanation")] SurgicalHistory surgicalHistory)
        {
            if (id != surgicalHistory.SurgicalHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surgicalHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurgicalHistoryExists(surgicalHistory.SurgicalHistoryId))
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
            return View(surgicalHistory);
        }

        // GET: SurgicalHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surgicalHistory = await _context.SurgicalHistory
                .FirstOrDefaultAsync(m => m.SurgicalHistoryId == id);
            if (surgicalHistory == null)
            {
                return NotFound();
            }

            return View(surgicalHistory);
        }

        // POST: SurgicalHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surgicalHistory = await _context.SurgicalHistory.FindAsync(id);
            _context.SurgicalHistory.Remove(surgicalHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurgicalHistoryExists(int id)
        {
            return _context.SurgicalHistory.Any(e => e.SurgicalHistoryId == id);
        }
    }
}
