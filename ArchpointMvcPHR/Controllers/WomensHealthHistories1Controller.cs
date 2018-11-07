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
    public class WomensHealthHistories1Controller : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public WomensHealthHistories1Controller(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: WomensHealthHistories1
        public async Task<IActionResult> Index()
        {
            return View(await _context.WomensHealthHistory.ToListAsync());
        }

        // GET: WomensHealthHistories1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var womensHealthHistory = await _context.WomensHealthHistory
                .FirstOrDefaultAsync(m => m.WomensHealthHistoryId == id);
            if (womensHealthHistory == null)
            {
                return NotFound();
            }

            return View(womensHealthHistory);
        }

        // GET: WomensHealthHistories1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WomensHealthHistories1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WomensHealthHistoryId,MedCareProviderId,DateLastClinicialBreastExam,ResultsLastBreastExam,DateNextBreastExam,DateLastMammogram,ResultsLastMammogram,DateNextMammogram,DateLastPapExam,ResultsLastPapExam,DateNextPapExam,WomensDiseaseDisorder,DateOfDiagnosis,WomensDiseaseDisorderStatus,DateResolved,WomensHealthSurgeryProcedure,DateOfSurgeryProcedure,AgePeriodsStarted,PeriodsRegular,PeriodProblems,PeriodFlow,StillHavingPeriods,BirthControlMethod,HormoneReplacementTherapy,HrtDateStarted,HrtDateStopped,NumOfPregnancies,NumOfLiveBirths,NumOfPrematureBirths,NumOfStillBirths,NumOfMiscarriages,NumOfCsections,NumOfElectiveAbortions,PregnancyComplications")] WomensHealthHistory womensHealthHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(womensHealthHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(womensHealthHistory);
        }

        // GET: WomensHealthHistories1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var womensHealthHistory = await _context.WomensHealthHistory.FindAsync(id);
            if (womensHealthHistory == null)
            {
                return NotFound();
            }
            return View(womensHealthHistory);
        }

        // POST: WomensHealthHistories1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WomensHealthHistoryId,MedCareProviderId,DateLastClinicialBreastExam,ResultsLastBreastExam,DateNextBreastExam,DateLastMammogram,ResultsLastMammogram,DateNextMammogram,DateLastPapExam,ResultsLastPapExam,DateNextPapExam,WomensDiseaseDisorder,DateOfDiagnosis,WomensDiseaseDisorderStatus,DateResolved,WomensHealthSurgeryProcedure,DateOfSurgeryProcedure,AgePeriodsStarted,PeriodsRegular,PeriodProblems,PeriodFlow,StillHavingPeriods,BirthControlMethod,HormoneReplacementTherapy,HrtDateStarted,HrtDateStopped,NumOfPregnancies,NumOfLiveBirths,NumOfPrematureBirths,NumOfStillBirths,NumOfMiscarriages,NumOfCsections,NumOfElectiveAbortions,PregnancyComplications")] WomensHealthHistory womensHealthHistory)
        {
            if (id != womensHealthHistory.WomensHealthHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(womensHealthHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WomensHealthHistoryExists(womensHealthHistory.WomensHealthHistoryId))
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
            return View(womensHealthHistory);
        }

        // GET: WomensHealthHistories1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var womensHealthHistory = await _context.WomensHealthHistory
                .FirstOrDefaultAsync(m => m.WomensHealthHistoryId == id);
            if (womensHealthHistory == null)
            {
                return NotFound();
            }

            return View(womensHealthHistory);
        }

        // POST: WomensHealthHistories1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var womensHealthHistory = await _context.WomensHealthHistory.FindAsync(id);
            _context.WomensHealthHistory.Remove(womensHealthHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WomensHealthHistoryExists(int id)
        {
            return _context.WomensHealthHistory.Any(e => e.WomensHealthHistoryId == id);
        }
    }
}
