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
    public class StdHistoriesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public StdHistoriesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: StdHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.StdHistory.ToListAsync());
        }

        // GET: StdHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stdHistory = await _context.StdHistory
                .FirstOrDefaultAsync(m => m.StdHistoryId == id);
            if (stdHistory == null)
            {
                return NotFound();
            }

            return View(stdHistory);
        }

        // GET: StdHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StdHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StdHistoryId,StdType,StdDateOfDiagnosis,StdStatus,StdDateResolved,StdMedication,Comments")] StdHistory stdHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stdHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stdHistory);
        }

        // GET: StdHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stdHistory = await _context.StdHistory.FindAsync(id);
            if (stdHistory == null)
            {
                return NotFound();
            }
            return View(stdHistory);
        }

        // POST: StdHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StdHistoryId,StdType,StdDateOfDiagnosis,StdStatus,StdDateResolved,StdMedication,Comments")] StdHistory stdHistory)
        {
            if (id != stdHistory.StdHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stdHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StdHistoryExists(stdHistory.StdHistoryId))
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
            return View(stdHistory);
        }

        // GET: StdHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stdHistory = await _context.StdHistory
                .FirstOrDefaultAsync(m => m.StdHistoryId == id);
            if (stdHistory == null)
            {
                return NotFound();
            }

            return View(stdHistory);
        }

        // POST: StdHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stdHistory = await _context.StdHistory.FindAsync(id);
            _context.StdHistory.Remove(stdHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StdHistoryExists(int id)
        {
            return _context.StdHistory.Any(e => e.StdHistoryId == id);
        }
    }
}
