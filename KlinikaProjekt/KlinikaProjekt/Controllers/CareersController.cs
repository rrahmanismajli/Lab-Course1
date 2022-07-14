using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KlinikaProjekt.Data;
using KlinikaProjekt.Models;
using Microsoft.AspNetCore.Authorization;

namespace KlinikaProjekt.Controllers
{
    public class CareersController : Controller
    {
        private readonly AppDbContext _context;

        public CareersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Careers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Careers.ToListAsync());
        }

        // GET: Careers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var careers = await _context.Careers
                .FirstOrDefaultAsync(m => m.id == id);
            if (careers == null)
            {
                return NotFound();
            }

            return View(careers);
        }

        // GET: Careers/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Careers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,image,title,description,deadLine")] Careers careers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(careers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(careers);
        }

        // GET: Careers/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var careers = await _context.Careers.FindAsync(id);
            if (careers == null)
            {
                return NotFound();
            }
            return View(careers);
        }

        // POST: Careers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,image,title,description,deadLine")] Careers careers)
        {
            if (id != careers.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(careers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CareersExists(careers.id))
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
            return View(careers);
        }

        // GET: Careers/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var careers = await _context.Careers
                .FirstOrDefaultAsync(m => m.id == id);
            if (careers == null)
            {
                return NotFound();
            }

            return View(careers);
        }

        // POST: Careers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var careers = await _context.Careers.FindAsync(id);
            _context.Careers.Remove(careers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CareersExists(int id)
        {
            return _context.Careers.Any(e => e.id == id);
        }
    }
}
