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
    public class HeartHistoriesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public HeartHistoriesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: HeartHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.HeartHistory.ToListAsync());
        }

        // GET: HeartHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heartHistory = await _context.HeartHistory
                .FirstOrDefaultAsync(m => m.HeartHistoryId == id);
            if (heartHistory == null)
            {
                return NotFound();
            }

            return View(heartHistory);
        }

        // GET: HeartHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HeartHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HeartHistoryId,MedicalProviderId,HeartDiseaseDisorder,DiagnosisDate,DiagnosisStatus,DateResolved,Comments")] HeartHistory heartHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(heartHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(heartHistory);
        }

        // GET: HeartHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heartHistory = await _context.HeartHistory.FindAsync(id);
            if (heartHistory == null)
            {
                return NotFound();
            }
            return View(heartHistory);
        }

        // POST: HeartHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HeartHistoryId,MedicalProviderId,HeartDiseaseDisorder,DiagnosisDate,DiagnosisStatus,DateResolved,Comments")] HeartHistory heartHistory)
        {
            if (id != heartHistory.HeartHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(heartHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeartHistoryExists(heartHistory.HeartHistoryId))
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
            return View(heartHistory);
        }

        // GET: HeartHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heartHistory = await _context.HeartHistory
                .FirstOrDefaultAsync(m => m.HeartHistoryId == id);
            if (heartHistory == null)
            {
                return NotFound();
            }

            return View(heartHistory);
        }

        // POST: HeartHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var heartHistory = await _context.HeartHistory.FindAsync(id);
            _context.HeartHistory.Remove(heartHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeartHistoryExists(int id)
        {
            return _context.HeartHistory.Any(e => e.HeartHistoryId == id);
        }
    }
}
