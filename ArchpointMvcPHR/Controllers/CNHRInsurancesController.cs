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
    public class CNHRInsurancesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public CNHRInsurancesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: CNHRInsurances
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurance.ToListAsync());
        }

        // GET: CNHRInsurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insurance == null)
            {
                return NotFound();
            }

            return View(insurance);
        }

        // GET: CNHRInsurances/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CNHRInsurances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PrimaryOrSecondary,InsuranceName,InsurancePhoneNum,InsuranceStreetAddress,InsuranceCity,InsuranceState,InsuranceCountry,PolicyIdNo,GroupNo,PlanEffectiveDate,AuthorizationPhoneNum,MedicareClaimNum,MedicaidClaimNum,MedicareMedicaidEffectiveDate,PolicyHolderFirstName,PolicyHolderMidInit,PolicyHolderLastName,RelationshipToPolicyHolder,DateOfBirth,SocialSecurityNo")] Insurance insurance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(insurance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insurance);
        }

        // GET: CNHRInsurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurance.FindAsync(id);
            if (insurance == null)
            {
                return NotFound();
            }
            return View(insurance);
        }

        // POST: CNHRInsurances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PrimaryOrSecondary,InsuranceName,InsurancePhoneNum,InsuranceStreetAddress,InsuranceCity,InsuranceState,InsuranceCountry,PolicyIdNo,GroupNo,PlanEffectiveDate,AuthorizationPhoneNum,MedicareClaimNum,MedicaidClaimNum,MedicareMedicaidEffectiveDate,PolicyHolderFirstName,PolicyHolderMidInit,PolicyHolderLastName,RelationshipToPolicyHolder,DateOfBirth,SocialSecurityNo")] Insurance insurance)
        {
            if (id != insurance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsuranceExists(insurance.Id))
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
            return View(insurance);
        }

        // GET: CNHRInsurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insurance = await _context.Insurance
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insurance == null)
            {
                return NotFound();
            }

            return View(insurance);
        }

        // POST: CNHRInsurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insurance = await _context.Insurance.FindAsync(id);
            _context.Insurance.Remove(insurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsuranceExists(int id)
        {
            return _context.Insurance.Any(e => e.Id == id);
        }
    }
}
