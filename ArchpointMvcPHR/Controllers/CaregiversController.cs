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
    public class CaregiversController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public CaregiversController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: Caregivers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Caregivers.ToListAsync());
        }

        // GET: Caregivers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caregivers = await _context.Caregivers
                .FirstOrDefaultAsync(m => m.CaregiversId == id);
            if (caregivers == null)
            {
                return NotFound();
            }

            return View(caregivers);
        }

        // GET: Caregivers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Caregivers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CaregiversId,PatientFirstName,PatientMiddleInitial,patientLastName,RelationshipToPatient,StreetAddress,City,StateProvince,ZipCode,Country,PhoneNumber,EveningPhone,CellPhone,PatientCurrentlyInNursingFacility")] Caregivers caregivers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caregivers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caregivers);
        }

        // GET: Caregivers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caregivers = await _context.Caregivers.FindAsync(id);
            if (caregivers == null)
            {
                return NotFound();
            }
            return View(caregivers);
        }

        // POST: Caregivers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CaregiversId,PatientFirstName,PatientMiddleInitial,patientLastName,RelationshipToPatient,StreetAddress,City,StateProvince,ZipCode,Country,PhoneNumber,EveningPhone,CellPhone,PatientCurrentlyInNursingFacility")] Caregivers caregivers)
        {
            if (id != caregivers.CaregiversId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caregivers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaregiversExists(caregivers.CaregiversId))
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
            return View(caregivers);
        }

        // GET: Caregivers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caregivers = await _context.Caregivers
                .FirstOrDefaultAsync(m => m.CaregiversId == id);
            if (caregivers == null)
            {
                return NotFound();
            }

            return View(caregivers);
        }

        // POST: Caregivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caregivers = await _context.Caregivers.FindAsync(id);
            _context.Caregivers.Remove(caregivers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaregiversExists(int id)
        {
            return _context.Caregivers.Any(e => e.CaregiversId == id);
        }
    }
}
