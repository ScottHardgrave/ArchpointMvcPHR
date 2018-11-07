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
    public class AlcoholRisksController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public AlcoholRisksController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: AlcoholRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.AlcoholRisk.ToListAsync());
        }

        // GET: AlcoholRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alcoholRisk = await _context.AlcoholRisk
                .FirstOrDefaultAsync(m => m.AlcoholRiskId == id);
            if (alcoholRisk == null)
            {
                return NotFound();
            }

            return View(alcoholRisk);
        }

        // GET: AlcoholRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlcoholRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlcoholRiskId,DrinkAlc,DailyDrinkCount,WeekendDrinkCount,SocialDrinkCount,YearsQuitDrinking,TreatedForAlcAbuse,YearTreated,LengthOfTreatment,TypeOfTreatment,Comments")] AlcoholRisk alcoholRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alcoholRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alcoholRisk);
        }

        // GET: AlcoholRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alcoholRisk = await _context.AlcoholRisk.FindAsync(id);
            if (alcoholRisk == null)
            {
                return NotFound();
            }
            return View(alcoholRisk);
        }

        // POST: AlcoholRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlcoholRiskId,DrinkAlc,DailyDrinkCount,WeekendDrinkCount,SocialDrinkCount,YearsQuitDrinking,TreatedForAlcAbuse,YearTreated,LengthOfTreatment,TypeOfTreatment,Comments")] AlcoholRisk alcoholRisk)
        {
            if (id != alcoholRisk.AlcoholRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alcoholRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlcoholRiskExists(alcoholRisk.AlcoholRiskId))
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
            return View(alcoholRisk);
        }

        // GET: AlcoholRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alcoholRisk = await _context.AlcoholRisk
                .FirstOrDefaultAsync(m => m.AlcoholRiskId == id);
            if (alcoholRisk == null)
            {
                return NotFound();
            }

            return View(alcoholRisk);
        }

        // POST: AlcoholRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alcoholRisk = await _context.AlcoholRisk.FindAsync(id);
            _context.AlcoholRisk.Remove(alcoholRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlcoholRiskExists(int id)
        {
            return _context.AlcoholRisk.Any(e => e.AlcoholRiskId == id);
        }
    }
}
