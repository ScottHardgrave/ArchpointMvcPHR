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
    public class WeightAndMeasurementRisksController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public WeightAndMeasurementRisksController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: WeightAndMeasurementRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.WeightAndMeasurementRisk.ToListAsync());
        }

        // GET: WeightAndMeasurementRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weightAndMeasurementRisk = await _context.WeightAndMeasurementRisk
                .FirstOrDefaultAsync(m => m.WeightAndMeasurementRiskId == id);
            if (weightAndMeasurementRisk == null)
            {
                return NotFound();
            }

            return View(weightAndMeasurementRisk);
        }

        // GET: WeightAndMeasurementRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WeightAndMeasurementRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WeightAndMeasurementRiskId,Weight,DateTaken,WeightGoal,Height,Bmi,CurrentWaistSize,WaistSizeGoal,Comments")] WeightAndMeasurementRisk weightAndMeasurementRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(weightAndMeasurementRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(weightAndMeasurementRisk);
        }

        // GET: WeightAndMeasurementRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weightAndMeasurementRisk = await _context.WeightAndMeasurementRisk.FindAsync(id);
            if (weightAndMeasurementRisk == null)
            {
                return NotFound();
            }
            return View(weightAndMeasurementRisk);
        }

        // POST: WeightAndMeasurementRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WeightAndMeasurementRiskId,Weight,DateTaken,WeightGoal,Height,Bmi,CurrentWaistSize,WaistSizeGoal,Comments")] WeightAndMeasurementRisk weightAndMeasurementRisk)
        {
            if (id != weightAndMeasurementRisk.WeightAndMeasurementRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weightAndMeasurementRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeightAndMeasurementRiskExists(weightAndMeasurementRisk.WeightAndMeasurementRiskId))
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
            return View(weightAndMeasurementRisk);
        }

        // GET: WeightAndMeasurementRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weightAndMeasurementRisk = await _context.WeightAndMeasurementRisk
                .FirstOrDefaultAsync(m => m.WeightAndMeasurementRiskId == id);
            if (weightAndMeasurementRisk == null)
            {
                return NotFound();
            }

            return View(weightAndMeasurementRisk);
        }

        // POST: WeightAndMeasurementRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var weightAndMeasurementRisk = await _context.WeightAndMeasurementRisk.FindAsync(id);
            _context.WeightAndMeasurementRisk.Remove(weightAndMeasurementRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeightAndMeasurementRiskExists(int id)
        {
            return _context.WeightAndMeasurementRisk.Any(e => e.WeightAndMeasurementRiskId == id);
        }
    }
}
