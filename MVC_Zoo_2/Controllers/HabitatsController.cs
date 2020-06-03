using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Zoo_2.Models;

namespace MVC_Zoo_2.Controllers
{
    public class HabitatsController : Controller
    {
        private readonly MVC_Zoo_2Context _context;

        public HabitatsController(MVC_Zoo_2Context context)
        {
            _context = context;
        }

        // GET: Habitats
        public async Task<IActionResult> Index()
        {
            var mVC_Zoo_2Context = _context.Habitat.Include(h => h.Itinerario);
            return View(await mVC_Zoo_2Context.ToListAsync());
        }

        // GET: Habitats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitat = await _context.Habitat
                .Include(h => h.Itinerario)
                .Include(h => h.HabitatEspecie)
                .ThenInclude(HabitatEspecie => HabitatEspecie.Especie)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habitat == null)
            {
                return NotFound();
            }

            return View(habitat);
        }

        // GET: Habitats/Create
        public IActionResult Create()
        {
            ViewData["ItinerarioId"] = new SelectList(_context.Set<Itinerario>(), "Id", "Id");
            return View();
        }

        // POST: Habitats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Clima,Vegetacion,ItinerarioId")] Habitat habitat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(habitat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItinerarioId"] = new SelectList(_context.Set<Itinerario>(), "Id", "Id", habitat.ItinerarioId);
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
            ViewData["ItinerarioId"] = new SelectList(_context.Set<Itinerario>(), "Id", "Id", habitat.ItinerarioId);
            return View(habitat);
        }

        // POST: Habitats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Clima,Vegetacion,ItinerarioId")] Habitat habitat)
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
            ViewData["ItinerarioId"] = new SelectList(_context.Set<Itinerario>(), "Id", "Id", habitat.ItinerarioId);
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
                .Include(h => h.Itinerario)
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
