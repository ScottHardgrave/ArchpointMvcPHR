using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArchpointMvcPHR.Models;
using Microsoft.AspNetCore.Authorization;

namespace ArchpointMvcPHR.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class AsthmaRisksController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public AsthmaRisksController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: AsthmaRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.AsthmaRisk.ToListAsync());
        }

        // GET: AsthmaRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asthmaRisk = await _context.AsthmaRisk
                .FirstOrDefaultAsync(m => m.AsthmaRiskId == id);
            if (asthmaRisk == null)
            {
                return NotFound();
            }

            return View(asthmaRisk);
        }

        // GET: AsthmaRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AsthmaRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AsthmaRiskId,AsthmaHospitalization,AsthmaHospitalizationDate,AsthmaIcu,IcuAdmitDate,AsthmaTriggers,AsthmaSymptoms,AsthmaSeverity,MedicationForAsthma,MedicationName,Comments")] AsthmaRisk asthmaRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asthmaRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(asthmaRisk);
        }

        // GET: AsthmaRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asthmaRisk = await _context.AsthmaRisk.FindAsync(id);
            if (asthmaRisk == null)
            {
                return NotFound();
            }
            return View(asthmaRisk);
        }

        // POST: AsthmaRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AsthmaRiskId,AsthmaHospitalization,AsthmaHospitalizationDate,AsthmaIcu,IcuAdmitDate,AsthmaTriggers,AsthmaSymptoms,AsthmaSeverity,MedicationForAsthma,MedicationName,Comments")] AsthmaRisk asthmaRisk)
        {
            if (id != asthmaRisk.AsthmaRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asthmaRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AsthmaRiskExists(asthmaRisk.AsthmaRiskId))
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
            return View(asthmaRisk);
        }

        // GET: AsthmaRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asthmaRisk = await _context.AsthmaRisk
                .FirstOrDefaultAsync(m => m.AsthmaRiskId == id);
            if (asthmaRisk == null)
            {
                return NotFound();
            }

            return View(asthmaRisk);
        }

        // POST: AsthmaRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var asthmaRisk = await _context.AsthmaRisk.FindAsync(id);
            _context.AsthmaRisk.Remove(asthmaRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AsthmaRiskExists(int id)
        {
            return _context.AsthmaRisk.Any(e => e.AsthmaRiskId == id);
        }
    }
}
