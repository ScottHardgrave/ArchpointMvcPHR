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
    public class SmokingHistoryRisksController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public SmokingHistoryRisksController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: SmokingHistoryRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.SmokingHistoryRisk.ToListAsync());
        }

        // GET: SmokingHistoryRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smokingHistoryRisk = await _context.SmokingHistoryRisk
                .FirstOrDefaultAsync(m => m.SmokingHistoryRiskId == id);
            if (smokingHistoryRisk == null)
            {
                return NotFound();
            }

            return View(smokingHistoryRisk);
        }

        // GET: SmokingHistoryRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SmokingHistoryRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SmokingHistoryRiskId,Smoker,AgeStarted,AgeQuit,ChewingSmokelessTobacco,QuittingGoal")] SmokingHistoryRisk smokingHistoryRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(smokingHistoryRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(smokingHistoryRisk);
        }

        // GET: SmokingHistoryRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smokingHistoryRisk = await _context.SmokingHistoryRisk.FindAsync(id);
            if (smokingHistoryRisk == null)
            {
                return NotFound();
            }
            return View(smokingHistoryRisk);
        }

        // POST: SmokingHistoryRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SmokingHistoryRiskId,Smoker,AgeStarted,AgeQuit,ChewingSmokelessTobacco,QuittingGoal")] SmokingHistoryRisk smokingHistoryRisk)
        {
            if (id != smokingHistoryRisk.SmokingHistoryRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(smokingHistoryRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SmokingHistoryRiskExists(smokingHistoryRisk.SmokingHistoryRiskId))
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
            return View(smokingHistoryRisk);
        }

        // GET: SmokingHistoryRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smokingHistoryRisk = await _context.SmokingHistoryRisk
                .FirstOrDefaultAsync(m => m.SmokingHistoryRiskId == id);
            if (smokingHistoryRisk == null)
            {
                return NotFound();
            }

            return View(smokingHistoryRisk);
        }

        // POST: SmokingHistoryRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var smokingHistoryRisk = await _context.SmokingHistoryRisk.FindAsync(id);
            _context.SmokingHistoryRisk.Remove(smokingHistoryRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SmokingHistoryRiskExists(int id)
        {
            return _context.SmokingHistoryRisk.Any(e => e.SmokingHistoryRiskId == id);
        }
    }
}
