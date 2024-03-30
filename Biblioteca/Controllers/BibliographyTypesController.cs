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
    public class BibliographyTypesController : Controller
    {
        private readonly LibraryDbContext _context;

        public BibliographyTypesController(LibraryDbContext context)
        {
            _context = context;
        }

        // GET: BibliographyTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BibliographyTypes.ToListAsync());
        }

        // GET: BibliographyTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bibliographyType = await _context.BibliographyTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bibliographyType == null)
            {
                return NotFound();
            }

            return View(bibliographyType);
        }

        // GET: BibliographyTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BibliographyTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Status")] BibliographyType bibliographyType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bibliographyType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bibliographyType);
        }

        // GET: BibliographyTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bibliographyType = await _context.BibliographyTypes.FindAsync(id);
            if (bibliographyType == null)
            {
                return NotFound();
            }
            return View(bibliographyType);
        }

        // POST: BibliographyTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Status")] BibliographyType bibliographyType)
        {
            if (id != bibliographyType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bibliographyType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BibliographyTypeExists(bibliographyType.Id))
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
            return View(bibliographyType);
        }

        // GET: BibliographyTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bibliographyType = await _context.BibliographyTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bibliographyType == null)
            {
                return NotFound();
            }

            return View(bibliographyType);
        }

        // POST: BibliographyTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bibliographyType = await _context.BibliographyTypes.FindAsync(id);
            if (bibliographyType != null)
            {
                _context.BibliographyTypes.Remove(bibliographyType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BibliographyTypeExists(int id)
        {
            return _context.BibliographyTypes.Any(e => e.Id == id);
        }
    }
}
