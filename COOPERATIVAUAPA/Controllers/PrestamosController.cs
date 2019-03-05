using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COOPERATIVAUAPA.Data;
using COOPERATIVAUAPA.Models;

namespace COOPERATIVAUAPA.Controllers
{
    public class PrestamosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrestamosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prestamos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Prestamos.Include(p => p.Clientes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Prestamos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamos = await _context.Prestamos
                .Include(p => p.Clientes)
                .FirstOrDefaultAsync(m => m.IdPrestamos == id);
            if (prestamos == null)
            {
                return NotFound();
            }

            return View(prestamos);
        }

        // GET: Prestamos/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre");
            return View();
        }

        // POST: Prestamos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPrestamos,IdCliente,Capital,TasaInteres,Periodo")] Prestamos prestamos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestamos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", prestamos.IdCliente);
            return View(prestamos);
        }

        // GET: Prestamos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamos = await _context.Prestamos.FindAsync(id);
            if (prestamos == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", prestamos.IdCliente);
            return View(prestamos);
        }

        // POST: Prestamos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPrestamos,IdCliente,Capital,TasaInteres,Periodo")] Prestamos prestamos)
        {
            if (id != prestamos.IdPrestamos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestamos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestamosExists(prestamos.IdPrestamos))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "IdCliente", "Nombre", prestamos.IdCliente);
            return View(prestamos);
        }

        // GET: Prestamos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamos = await _context.Prestamos
                .Include(p => p.Clientes)
                .FirstOrDefaultAsync(m => m.IdPrestamos == id);
            if (prestamos == null)
            {
                return NotFound();
            }

            return View(prestamos);
        }

        // POST: Prestamos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prestamos = await _context.Prestamos.FindAsync(id);
            _context.Prestamos.Remove(prestamos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestamosExists(int id)
        {
            return _context.Prestamos.Any(e => e.IdPrestamos == id);
        }


    }
}
