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
    public class EyeHistoriesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public EyeHistoriesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: EyeHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.EyeHistory.ToListAsync());
        }

        // GET: EyeHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eyeHistory = await _context.EyeHistory
                .FirstOrDefaultAsync(m => m.EyeHistoryId == id);
            if (eyeHistory == null)
            {
                return NotFound();
            }

            return View(eyeHistory);
        }

        // GET: EyeHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EyeHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EyeHistoryId,DateLastEyeExam,DateNextEyeExam,DateLastGlaucomaExam,DateNextGlaucomaExam,MedicalProviderId,Eyeglasses,ContactLenses,PrescriptionDate,ContactBrandName,EyeDiseaseDisorder,EyeDiseaseDisorderDiagnosisDate,EyeDiseaseDisorderStatus,EyeDiseaseDisorderResolveDate,PreviousEyeSurgery,EyeSurgeryProcedure,EyeSurgeryProcedureDate,MedCareLocationId,Comments")] EyeHistory eyeHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eyeHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eyeHistory);
        }

        // GET: EyeHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eyeHistory = await _context.EyeHistory.FindAsync(id);
            if (eyeHistory == null)
            {
                return NotFound();
            }
            return View(eyeHistory);
        }

        // POST: EyeHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EyeHistoryId,DateLastEyeExam,DateNextEyeExam,DateLastGlaucomaExam,DateNextGlaucomaExam,MedicalProviderId,Eyeglasses,ContactLenses,PrescriptionDate,ContactBrandName,EyeDiseaseDisorder,EyeDiseaseDisorderDiagnosisDate,EyeDiseaseDisorderStatus,EyeDiseaseDisorderResolveDate,PreviousEyeSurgery,EyeSurgeryProcedure,EyeSurgeryProcedureDate,MedCareLocationId,Comments")] EyeHistory eyeHistory)
        {
            if (id != eyeHistory.EyeHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eyeHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EyeHistoryExists(eyeHistory.EyeHistoryId))
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
            return View(eyeHistory);
        }

        // GET: EyeHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eyeHistory = await _context.EyeHistory
                .FirstOrDefaultAsync(m => m.EyeHistoryId == id);
            if (eyeHistory == null)
            {
                return NotFound();
            }

            return View(eyeHistory);
        }

        // POST: EyeHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eyeHistory = await _context.EyeHistory.FindAsync(id);
            _context.EyeHistory.Remove(eyeHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EyeHistoryExists(int id)
        {
            return _context.EyeHistory.Any(e => e.EyeHistoryId == id);
        }
    }
}
