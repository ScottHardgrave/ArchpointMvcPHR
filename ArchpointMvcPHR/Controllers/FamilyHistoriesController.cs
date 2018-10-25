﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArchpointMvcPHR.Models;

namespace ArchpointMvcPHR.Controllers
{
    public class FamilyHistoriesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public FamilyHistoriesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: FamilyHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.FamilyHistory.ToListAsync());
        }

        // GET: FamilyHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familyHistory = await _context.FamilyHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familyHistory == null)
            {
                return NotFound();
            }

            return View(familyHistory);
        }

        // GET: FamilyHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FamilyHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,MemberType,Age,Disease,Comment")] FamilyHistory familyHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(familyHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(familyHistory);
        }

        // GET: FamilyHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familyHistory = await _context.FamilyHistory.FindAsync(id);
            if (familyHistory == null)
            {
                return NotFound();
            }
            return View(familyHistory);
        }

        // POST: FamilyHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,MemberType,Age,Disease,Comment")] FamilyHistory familyHistory)
        {
            if (id != familyHistory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(familyHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamilyHistoryExists(familyHistory.Id))
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
            return View(familyHistory);
        }

        // GET: FamilyHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familyHistory = await _context.FamilyHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familyHistory == null)
            {
                return NotFound();
            }

            return View(familyHistory);
        }

        // POST: FamilyHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var familyHistory = await _context.FamilyHistory.FindAsync(id);
            _context.FamilyHistory.Remove(familyHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FamilyHistoryExists(int id)
        {
            return _context.FamilyHistory.Any(e => e.Id == id);
        }
    }
}