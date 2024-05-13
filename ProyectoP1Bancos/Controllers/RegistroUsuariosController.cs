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
    public class RegistroUsuariosController : Controller
    {
        private readonly ProyectoP1BancosContext _context;
       

        public RegistroUsuariosController(ProyectoP1BancosContext context)
        {
            
            _context = context;
        }

        // GET: RegistroUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroUsuario.ToListAsync());
        }

        // GET: RegistroUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroUsuario = await _context.RegistroUsuario
                .FirstOrDefaultAsync(m => m.IdRegistro == id);
            if (registroUsuario == null)
            {
                return NotFound();
            }

            return View(registroUsuario);
        }

        // GET: RegistroUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult IndexGay(string nombre, string contraseña)
        {
            var usuario = _context.RegistroUsuario.FirstOrDefault(u => u.NombreUsuario == nombre && u.Contraseña == contraseña);

            if (usuario != null)
            {

                return RedirectToAction("IndexGay", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Nombre o contraseña incorrectos.";
                return View();
            }

        }


        // POST: RegistroUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRegistro,NombreUsuario,Contraseña")] RegistroUsuario registroUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroUsuario);
        }

        // GET: RegistroUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroUsuario = await _context.RegistroUsuario.FindAsync(id);
            if (registroUsuario == null)
            {
                return NotFound();
            }
            return View(registroUsuario);
        }

        // POST: RegistroUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRegistro,NombreUsuario,Contraseña")] RegistroUsuario registroUsuario)
        {
            if (id != registroUsuario.IdRegistro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroUsuarioExists(registroUsuario.IdRegistro))
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
            return View(registroUsuario);
        }

        // GET: RegistroUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroUsuario = await _context.RegistroUsuario
                .FirstOrDefaultAsync(m => m.IdRegistro == id);
            if (registroUsuario == null)
            {
                return NotFound();
            }

            return View(registroUsuario);
        }

        // POST: RegistroUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroUsuario = await _context.RegistroUsuario.FindAsync(id);
            if (registroUsuario != null)
            {
                _context.RegistroUsuario.Remove(registroUsuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroUsuarioExists(int id)
        {
            return _context.RegistroUsuario.Any(e => e.IdRegistro == id);
        }
    }
}
