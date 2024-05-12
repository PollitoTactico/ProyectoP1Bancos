using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoP1Bancos.Data;
using ProyectoP1Bancos.Models;

namespace ProyectoP1Bancos.Controllers
{
    public class ObjetoDesController : Controller
    {
        private readonly ProyectoP1BancosContext _context;

        public ObjetoDesController(ProyectoP1BancosContext context)
        {
            _context = context;
        }

        // GET: ObjetoDes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ObjetoDes.ToListAsync());
        }

        // GET: ObjetoDes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetoDes = await _context.ObjetoDes
                .FirstOrDefaultAsync(m => m.IdObjeto == id);
            if (objetoDes == null)
            {
                return NotFound();
            }

            return View(objetoDes);
        }

        // GET: ObjetoDes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ObjetoDes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdObjeto,NombreObjeto,Precio,Descripcion")] ObjetoDes objetoDes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objetoDes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(objetoDes);
        }

        // GET: ObjetoDes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetoDes = await _context.ObjetoDes.FindAsync(id);
            if (objetoDes == null)
            {
                return NotFound();
            }
            return View(objetoDes);
        }

        // POST: ObjetoDes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdObjeto,NombreObjeto,Precio,Descripcion")] ObjetoDes objetoDes)
        {
            if (id != objetoDes.IdObjeto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(objetoDes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObjetoDesExists(objetoDes.IdObjeto))
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
            return View(objetoDes);
        }

        // GET: ObjetoDes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetoDes = await _context.ObjetoDes
                .FirstOrDefaultAsync(m => m.IdObjeto == id);
            if (objetoDes == null)
            {
                return NotFound();
            }

            return View(objetoDes);
        }

        // POST: ObjetoDes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var objetoDes = await _context.ObjetoDes.FindAsync(id);
            if (objetoDes != null)
            {
                _context.ObjetoDes.Remove(objetoDes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObjetoDesExists(int id)
        {
            return _context.ObjetoDes.Any(e => e.IdObjeto == id);
        }
    }
}
