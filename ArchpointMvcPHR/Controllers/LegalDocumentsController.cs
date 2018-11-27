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
    public class LegalDocumentsController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public LegalDocumentsController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: LegalDocuments
        public async Task<IActionResult> Index()
        {
            return View(await _context.LegalDocument.ToListAsync());
        }

        // GET: LegalDocuments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legalDocument = await _context.LegalDocument
                .FirstOrDefaultAsync(m => m.ID == id);
            if (legalDocument == null)
            {
                return NotFound();
            }

            return View(legalDocument);
        }

        // GET: LegalDocuments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LegalDocuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Will,WillDateSigned,WillLastUpdated,WillCopy,FamilyAware,MedPowerOfAttorney,MedPowerOfAttorneyName,DateMedPowerOfAttorney,DateUpdatedMedPowerOfAttorney,MedPowerOfAttorneyCopyOnFile,HealthCareProxy,HealthCareProxyName,HealthCareProxyDateSign,HealthCareProxyLastUpdate,DoNotResuscitate,DnrDateSign,DnrDateUpdate,OrganDonorDocument,OrganDonorDocumentDateSign,OrganDonorDocumentLastUpdate,DocumentLocation,DocumentContactFirstName,DocumentContactLastName,DocumentContactPhone,AttorneyFirstName,AttorneyLastName,AttorneyPhone,Comments")] LegalDocument legalDocument)
        {
            if (ModelState.IsValid)
            {
                _context.Add(legalDocument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(legalDocument);
        }

        // GET: LegalDocuments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legalDocument = await _context.LegalDocument.FindAsync(id);
            if (legalDocument == null)
            {
                return NotFound();
            }
            return View(legalDocument);
        }

        // POST: LegalDocuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Will,WillDateSigned,WillLastUpdated,WillCopy,FamilyAware,MedPowerOfAttorney,MedPowerOfAttorneyName,DateMedPowerOfAttorney,DateUpdatedMedPowerOfAttorney,MedPowerOfAttorneyCopyOnFile,HealthCareProxy,HealthCareProxyName,HealthCareProxyDateSign,HealthCareProxyLastUpdate,DoNotResuscitate,DnrDateSign,DnrDateUpdate,OrganDonorDocument,OrganDonorDocumentDateSign,OrganDonorDocumentLastUpdate,DocumentLocation,DocumentContactFirstName,DocumentContactLastName,DocumentContactPhone,AttorneyFirstName,AttorneyLastName,AttorneyPhone,Comments")] LegalDocument legalDocument)
        {
            if (id != legalDocument.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(legalDocument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LegalDocumentExists(legalDocument.ID))
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
            return View(legalDocument);
        }

        // GET: LegalDocuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legalDocument = await _context.LegalDocument
                .FirstOrDefaultAsync(m => m.ID == id);
            if (legalDocument == null)
            {
                return NotFound();
            }

            return View(legalDocument);
        }

        // POST: LegalDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var legalDocument = await _context.LegalDocument.FindAsync(id);
            _context.LegalDocument.Remove(legalDocument);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LegalDocumentExists(int id)
        {
            return _context.LegalDocument.Any(e => e.ID == id);
        }
    }
}
