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
    public class CNHREmergencyContactsController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public CNHREmergencyContactsController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: CNHREmergencyContacts
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmergencyContact.ToListAsync());
        }

        // GET: CNHREmergencyContacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencyContact = await _context.EmergencyContact
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emergencyContact == null)
            {
                return NotFound();
            }

            return View(emergencyContact);
        }

        // GET: CNHREmergencyContacts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CNHREmergencyContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,RelationshipToPatient,HomePhone,EveningPhone,CellPhone,EmerContactEmail,EmerContactStreetAddress,EmerContactCity,EmerContactStateProvince,EmerContactZip,EmerContactCountry")] EmergencyContact emergencyContact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emergencyContact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emergencyContact);
        }

        // GET: CNHREmergencyContacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencyContact = await _context.EmergencyContact.FindAsync(id);
            if (emergencyContact == null)
            {
                return NotFound();
            }
            return View(emergencyContact);
        }

        // POST: CNHREmergencyContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,RelationshipToPatient,HomePhone,EveningPhone,CellPhone,EmerContactEmail,EmerContactStreetAddress,EmerContactCity,EmerContactStateProvince,EmerContactZip,EmerContactCountry")] EmergencyContact emergencyContact)
        {
            if (id != emergencyContact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emergencyContact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmergencyContactExists(emergencyContact.Id))
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
            return View(emergencyContact);
        }

        // GET: CNHREmergencyContacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencyContact = await _context.EmergencyContact
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emergencyContact == null)
            {
                return NotFound();
            }

            return View(emergencyContact);
        }

        // POST: CNHREmergencyContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emergencyContact = await _context.EmergencyContact.FindAsync(id);
            _context.EmergencyContact.Remove(emergencyContact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmergencyContactExists(int id)
        {
            return _context.EmergencyContact.Any(e => e.Id == id);
        }
    }
}
