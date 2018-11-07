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
    public class EarNoseThroatHistoriesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public EarNoseThroatHistoriesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: EarNoseThroatHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.EarNoseThroatHistory.ToListAsync());
        }

        // GET: EarNoseThroatHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var earNoseThroatHistory = await _context.EarNoseThroatHistory
                .FirstOrDefaultAsync(m => m.EarNoseThroatHistoryId == id);
            if (earNoseThroatHistory == null)
            {
                return NotFound();
            }

            return View(earNoseThroatHistory);
        }

        // GET: EarNoseThroatHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EarNoseThroatHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EarNoseThroatHistoryId,DiseaseDisorder,DiagnosisDate,CurrentStatus,DateResolved,MedicalProviderId,MedCareLocationId,Surgery")] EarNoseThroatHistory earNoseThroatHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(earNoseThroatHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(earNoseThroatHistory);
        }

        // GET: EarNoseThroatHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var earNoseThroatHistory = await _context.EarNoseThroatHistory.FindAsync(id);
            if (earNoseThroatHistory == null)
            {
                return NotFound();
            }
            return View(earNoseThroatHistory);
        }

        // POST: EarNoseThroatHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EarNoseThroatHistoryId,DiseaseDisorder,DiagnosisDate,CurrentStatus,DateResolved,MedicalProviderId,MedCareLocationId,Surgery")] EarNoseThroatHistory earNoseThroatHistory)
        {
            if (id != earNoseThroatHistory.EarNoseThroatHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(earNoseThroatHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EarNoseThroatHistoryExists(earNoseThroatHistory.EarNoseThroatHistoryId))
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
            return View(earNoseThroatHistory);
        }

        // GET: EarNoseThroatHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var earNoseThroatHistory = await _context.EarNoseThroatHistory
                .FirstOrDefaultAsync(m => m.EarNoseThroatHistoryId == id);
            if (earNoseThroatHistory == null)
            {
                return NotFound();
            }

            return View(earNoseThroatHistory);
        }

        // POST: EarNoseThroatHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var earNoseThroatHistory = await _context.EarNoseThroatHistory.FindAsync(id);
            _context.EarNoseThroatHistory.Remove(earNoseThroatHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EarNoseThroatHistoryExists(int id)
        {
            return _context.EarNoseThroatHistory.Any(e => e.EarNoseThroatHistoryId == id);
        }
    }
}
