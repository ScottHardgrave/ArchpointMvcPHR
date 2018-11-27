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
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class PersonalInfoesController : Controller
    {
        private readonly ArchpointMvcPHRContext _context;

        public PersonalInfoesController(ArchpointMvcPHRContext context)
        {
            _context = context;
        }

        // GET: PersonalInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonalInfo.ToListAsync());
        }

        // GET: PersonalInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalInfo = await _context.PersonalInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalInfo == null)
            {
                return NotFound();
            }

            return View(personalInfo);
        }

        // GET: PersonalInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonalInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,MiddleInitial,LastName,Sex,BloodType,DateOfBirth,SocialSecurityNum,StreetAddress,City,State,ZipCode,Country,HomePhone,CellPhone,Race,MaritalStatus,Religion")] PersonalInfo personalInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personalInfo);
        }

        // GET: PersonalInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalInfo = await _context.PersonalInfo.FindAsync(id);
            if (personalInfo == null)
            {
                return NotFound();
            }
            return View(personalInfo);
        }

        // POST: PersonalInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,MiddleInitial,LastName,Sex,BloodType,DateOfBirth,SocialSecurityNum,StreetAddress,City,State,ZipCode,Country,HomePhone,CellPhone,Race,MaritalStatus,Religion")] PersonalInfo personalInfo)
        {
            if (id != personalInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalInfoExists(personalInfo.Id))
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
            return View(personalInfo);
        }

        // GET: PersonalInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalInfo = await _context.PersonalInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personalInfo == null)
            {
                return NotFound();
            }

            return View(personalInfo);
        }

        // POST: PersonalInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personalInfo = await _context.PersonalInfo.FindAsync(id);
            _context.PersonalInfo.Remove(personalInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalInfoExists(int id)
        {
            return _context.PersonalInfo.Any(e => e.Id == id);
        }
    }
}
