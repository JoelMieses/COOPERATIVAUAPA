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
    public class SolicitudPrestamoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SolicitudPrestamoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SolicitudPrestamo
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SolicitudPrestamos.Include(s => s.Estatus).Include(s => s.TipoPrestamo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SolicitudPrestamo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPrestamos = await _context.SolicitudPrestamos
                .Include(s => s.Estatus)
                .Include(s => s.TipoPrestamo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudPrestamos == null)
            {
                return NotFound();
            }

            return View(solicitudPrestamos);
        }

        // GET: SolicitudPrestamo/Create
        public IActionResult Create()
        {

            CargaListas();

            return View();
        }

        public IActionResult Aprobacion([FromQuery] bool decision, int id)
        {
            var _solicitud = _context.SolicitudPrestamos.FirstOrDefault(s => s.Id == id);

            if (_solicitud == null) return NotFound();

            if (decision)
            {
                _solicitud.EstatusId = 2;
                
            }
            else
            {
                _solicitud.EstatusId = 3;
                
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        private void CargaListas()
        {
     
            ViewBag.TipoPrestamo = new SelectList(_context.TipoPrestamo.ToList(), "Id", "Nombre");
            ViewBag.EstatusSolicitud = new SelectList(_context.EstatusSolicitud.ToList(), "Id", "Nombre");
        }

        [HttpPost]
        public IActionResult Create([FromForm] SolicitudPrestamos solicitud)
        {
            try
            {



                if (ModelState.IsValid)
                {
                    solicitud.EstatusId = 1;
                    solicitud.Fecha = DateTime.Now;

                    _context.SolicitudPrestamos.Add(solicitud);

                    _context.SaveChanges();

                }

                return View("Gracias");

            }
            catch (Exception)
            {
                CargaListas();
                return View(solicitud);

            }

        }

    
        // GET: SolicitudPrestamo/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var solicitudPrestamos = await _context.SolicitudPrestamos.FindAsync(id);
        //    if (solicitudPrestamos == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["EstatusId"] = new SelectList(_context.EstatusSolicitud, "Id", "Id", solicitudPrestamos.EstatusId);
        //    ViewData["TipoPrestamoId"] = new SelectList(_context.TipoPrestamo, "Id", "Id", solicitudPrestamos.TipoPrestamoId);
        //    return View(solicitudPrestamos);
        //}

        //// POST: SolicitudPrestamo/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,Nombre,PrimerApellido,SegundoApellido,NumeroIdentificacion,Sexo,FechaNacimiento,Nacionalidad,EstadoCivil,Direccion,TelefonoResidencia,CelularPersonal,Email,NombreConyugue,ParienteCercano,Parentesco,TelefonoContactoPariente,DireccionPariente,OtroTelefonoContacto,GaranteNombre,GarantePrimerApellido,GaranteSegundoApellido,GaranteNumeroIdentificacion,GaranteSexo,GaranteFechaNacimiento,GaranteNacionalidad,GaranteEstadoCivil,GaranteDireccion,GaranteTelefonoResidencia,GaranteCelularPersonal,GaranteEmail,Monto,DuracionMeses,Tasa,EstatusId,TipoPrestamoId")] SolicitudPrestamos solicitudPrestamos)
        //{
        //    if (id != solicitudPrestamos.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(solicitudPrestamos);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SolicitudPrestamosExists(solicitudPrestamos.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["EstatusId"] = new SelectList(_context.EstatusSolicitud, "Id", "Id", solicitudPrestamos.EstatusId);
        //    ViewData["TipoPrestamoId"] = new SelectList(_context.TipoPrestamo, "Id", "Id", solicitudPrestamos.TipoPrestamoId);
        //    return View(solicitudPrestamos);
        //}

        //// GET: SolicitudPrestamo/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var solicitudPrestamos = await _context.SolicitudPrestamos
        //        .Include(s => s.Estatus)
        //        .Include(s => s.TipoPrestamo)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (solicitudPrestamos == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(solicitudPrestamos);
        //}

        //// POST: SolicitudPrestamo/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var solicitudPrestamos = await _context.SolicitudPrestamos.FindAsync(id);
        //    _context.SolicitudPrestamos.Remove(solicitudPrestamos);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool SolicitudPrestamosExists(int id)
        //{
        //    return _context.SolicitudPrestamos.Any(e => e.Id == id);
        //}
    }
}
