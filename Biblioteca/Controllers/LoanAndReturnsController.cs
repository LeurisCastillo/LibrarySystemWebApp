using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class LoanAndReturnsController : Controller
    {
        private readonly LibraryDbContext _context;

        public LoanAndReturnsController(LibraryDbContext context)
        {
            _context = context;
        }

        // GET: LoanAndReturns
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoanAndReturns.ToListAsync());
        }

        // GET: LoanAndReturns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanAndReturn = await _context.LoanAndReturns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanAndReturn == null)
            {
                return NotFound();
            }

            return View(loanAndReturn);
        }

        // GET: LoanAndReturns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoanAndReturns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Employee,Book,User,LoanDate,ReturnDate,PricePerDay,Days,Comments,Status")] LoanAndReturn loanAndReturn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loanAndReturn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loanAndReturn);
        }

        // GET: LoanAndReturns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanAndReturn = await _context.LoanAndReturns.FindAsync(id);
            if (loanAndReturn == null)
            {
                return NotFound();
            }
            return View(loanAndReturn);
        }

        // POST: LoanAndReturns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Employee,Book,User,LoanDate,ReturnDate,PricePerDay,Days,Comments,Status")] LoanAndReturn loanAndReturn)
        {
            if (id != loanAndReturn.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loanAndReturn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanAndReturnExists(loanAndReturn.Id))
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
            return View(loanAndReturn);
        }

        // GET: LoanAndReturns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanAndReturn = await _context.LoanAndReturns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanAndReturn == null)
            {
                return NotFound();
            }

            return View(loanAndReturn);
        }

        // POST: LoanAndReturns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loanAndReturn = await _context.LoanAndReturns.FindAsync(id);
            if (loanAndReturn != null)
            {
                _context.LoanAndReturns.Remove(loanAndReturn);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanAndReturnExists(int id)
        {
            return _context.LoanAndReturns.Any(e => e.Id == id);
        }
    }
}
