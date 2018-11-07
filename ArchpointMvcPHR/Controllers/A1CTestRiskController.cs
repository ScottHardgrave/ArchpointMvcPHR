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
    public class A1CTestRiskController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public A1CTestRiskController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: A1CTestRisk
        public async Task<IActionResult> Index()
        {
            return View(await _context.A1CTestRisk.ToListAsync());
        }

        // GET: A1CTestRisk/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var a1CTestRisk = await _context.A1CTestRisk
                .FirstOrDefaultAsync(m => m.A1cTestRiskId == id);
            if (a1CTestRisk == null)
            {
                return NotFound();
            }

            return View(a1CTestRisk);
        }

        // GET: A1CTestRisk/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: A1CTestRisk/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("A1cTestRiskId,DateEntered,DateTested,A1cTestResults,A1cTargetRangeGoal,Comments")] A1CTestRisk a1CTestRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(a1CTestRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(a1CTestRisk);
        }

        // GET: A1CTestRisk/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var a1CTestRisk = await _context.A1CTestRisk.FindAsync(id);
            if (a1CTestRisk == null)
            {
                return NotFound();
            }
            return View(a1CTestRisk);
        }

        // POST: A1CTestRisk/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("A1cTestRiskId,DateEntered,DateTested,A1cTestResults,A1cTargetRangeGoal,Comments")] A1CTestRisk a1CTestRisk)
        {
            if (id != a1CTestRisk.A1cTestRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(a1CTestRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!A1CTestRiskExists(a1CTestRisk.A1cTestRiskId))
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
            return View(a1CTestRisk);
        }

        // GET: A1CTestRisk/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var a1CTestRisk = await _context.A1CTestRisk
                .FirstOrDefaultAsync(m => m.A1cTestRiskId == id);
            if (a1CTestRisk == null)
            {
                return NotFound();
            }

            return View(a1CTestRisk);
        }

        // POST: A1CTestRisk/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var a1CTestRisk = await _context.A1CTestRisk.FindAsync(id);
            _context.A1CTestRisk.Remove(a1CTestRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool A1CTestRiskExists(int id)
        {
            return _context.A1CTestRisk.Any(e => e.A1cTestRiskId == id);
        }
    }
}
