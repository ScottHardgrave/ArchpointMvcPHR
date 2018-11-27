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
    public class CancerHistoriesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public CancerHistoriesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: CancerHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.CancerHistory.ToListAsync());
        }

        // GET: CancerHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cancerHistory = await _context.CancerHistory
                .FirstOrDefaultAsync(m => m.CancerHistoryId == id);
            if (cancerHistory == null)
            {
                return NotFound();
            }

            return View(cancerHistory);
        }

        // GET: CancerHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CancerHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CancerHistoryId,MedProviderId,TypeOfCancerTumor,DiagnosisDate,AgeAtDiagnosis,StageOfCancerTumor,MedCareLocationId,TreatmentReceived,TreatmentDate,Comments")] CancerHistory cancerHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cancerHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cancerHistory);
        }

        // GET: CancerHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cancerHistory = await _context.CancerHistory.FindAsync(id);
            if (cancerHistory == null)
            {
                return NotFound();
            }
            return View(cancerHistory);
        }

        // POST: CancerHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CancerHistoryId,MedProviderId,TypeOfCancerTumor,DiagnosisDate,AgeAtDiagnosis,StageOfCancerTumor,MedCareLocationId,TreatmentReceived,TreatmentDate,Comments")] CancerHistory cancerHistory)
        {
            if (id != cancerHistory.CancerHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cancerHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CancerHistoryExists(cancerHistory.CancerHistoryId))
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
            return View(cancerHistory);
        }

        // GET: CancerHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cancerHistory = await _context.CancerHistory
                .FirstOrDefaultAsync(m => m.CancerHistoryId == id);
            if (cancerHistory == null)
            {
                return NotFound();
            }

            return View(cancerHistory);
        }

        // POST: CancerHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cancerHistory = await _context.CancerHistory.FindAsync(id);
            _context.CancerHistory.Remove(cancerHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CancerHistoryExists(int id)
        {
            return _context.CancerHistory.Any(e => e.CancerHistoryId == id);
        }
    }
}
