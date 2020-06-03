using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Zoo.Models;

namespace MVC_Zoo.Controllers
{
    public class HabitatsController : Controller
    {
        private readonly MVC_ZooContext _context;

        public HabitatsController(MVC_ZooContext context)
        {
            _context = context;
        }

        // GET: Habitats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Habitat.ToListAsync());
        }

        // GET: Habitats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitat = await _context.Habitat
                .Include(c => c.itinerario)
                .Include(c => c.habitatEspecies)
                .ThenInclude(HabitatEspecie=>HabitatEspecie.especie)
                .FirstOrDefaultAsync(m => m.Id == id);
            ViewData["EspecieId"] = new SelectList(_context.Especie, "Id", "Nombre");

            if (habitat == null)
            {
                return NotFound();
            }

            return View(habitat);
        }

        // GET: Habitats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Habitats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nombre,clima,vegetacion")] Habitat habitat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(habitat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(habitat);
        }

        // GET: Habitats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitat = await _context.Habitat.FindAsync(id);
            if (habitat == null)
            {
                return NotFound();
            }
            return View(habitat);
        }

        // POST: Habitats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nombre,clima,vegetacion")] Habitat habitat)
        {
            if (id != habitat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(habitat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HabitatExists(habitat.Id))
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
            return View(habitat);
        }

        // GET: Habitats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitat = await _context.Habitat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habitat == null)
            {
                return NotFound();
            }

            return View(habitat);
        }

        // POST: Habitats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var habitat = await _context.Habitat.FindAsync(id);
            _context.Habitat.Remove(habitat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HabitatExists(int id)
        {
            return _context.Habitat.Any(e => e.Id == id);
        }
    }
}
