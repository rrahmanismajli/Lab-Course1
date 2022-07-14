using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KlinikaProjekt.Data;
using KlinikaProjekt.Models;


namespace KlinikaProjekt.Controllers
{
    public class MedicamentOrdersController : Controller
    {
        private readonly AppDbContext _context;

        public MedicamentOrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MedicamentOrders
        public async Task<IActionResult> Index()
        {
           
            return View(await _context.MedicamentOrder.ToListAsync());
        }

        // GET: MedicamentOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamentOrder = await _context.MedicamentOrder
                .FirstOrDefaultAsync(m => m.id == id);
            if (medicamentOrder == null)
            {
                return NotFound();
            }

            return View(medicamentOrder);
        }

        // GET: MedicamentOrders/Create
        public IActionResult Buy()
        {
            return View();
        }

        // POST: MedicamentOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buy([Bind("id,Name,shippingAdress,quantity,note,orderDate")] MedicamentOrder medicamentOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicamentOrder);
                await _context.SaveChangesAsync();
                return View("OrderCompleted");
            }
            return View(medicamentOrder);
        }

        // GET: MedicamentOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamentOrder = await _context.MedicamentOrder.FindAsync(id);
            if (medicamentOrder == null)
            {
                return NotFound();
            }
            return View(medicamentOrder);
        }

        // POST: MedicamentOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,shippingAdress,quantity,note,orderDate")] MedicamentOrder medicamentOrder)
        {
            if (id != medicamentOrder.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicamentOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicamentOrderExists(medicamentOrder.id))
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
            return View(medicamentOrder);
        }

        // GET: MedicamentOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamentOrder = await _context.MedicamentOrder
                .FirstOrDefaultAsync(m => m.id == id);
            if (medicamentOrder == null)
            {
                return NotFound();
            }

            return View(medicamentOrder);
        }

        // POST: MedicamentOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicamentOrder = await _context.MedicamentOrder.FindAsync(id);
            _context.MedicamentOrder.Remove(medicamentOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicamentOrderExists(int id)
        {
            return _context.MedicamentOrder.Any(e => e.id == id);
        }
    }
}
