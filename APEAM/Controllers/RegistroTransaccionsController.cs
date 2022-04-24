#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using APEAM.Data;
using ExamenAPEAM.Models;

namespace APEAM.Controllers
{
    public class RegistroTransaccionsController : Controller
    {
        private readonly APEAMContext _context;

        public RegistroTransaccionsController(APEAMContext context)
        {
            _context = context;
        }

        // GET: RegistroTransaccions
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroTransaccion.ToListAsync());
        }

        // GET: RegistroTransaccions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroTransaccion = await _context.RegistroTransaccion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroTransaccion == null)
            {
                return NotFound();
            }

            return View(registroTransaccion);
        }

        // GET: RegistroTransaccions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistroTransaccions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,IdProducto,IdProveedor,IdTipoPago,Accion,Cantidad,CostoUnitario,Total")] RegistroTransaccion registroTransaccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroTransaccion);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(registroTransaccion);
        }

        // GET: RegistroTransaccions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroTransaccion = await _context.RegistroTransaccion.FindAsync(id);
            if (registroTransaccion == null)
            {
                return NotFound();
            }
            return View(registroTransaccion);
        }

        // POST: RegistroTransaccions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha,IdProducto,IdProveedor,IdTipoPago,Accion,Cantidad,CostoUnitario,Total")] RegistroTransaccion registroTransaccion)
        {
            if (id != registroTransaccion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroTransaccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroTransaccionExists(registroTransaccion.Id))
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
            return View(registroTransaccion);
        }

        // GET: RegistroTransaccions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroTransaccion = await _context.RegistroTransaccion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroTransaccion == null)
            {
                return NotFound();
            }

            return View(registroTransaccion);
        }

        // POST: RegistroTransaccions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroTransaccion = await _context.RegistroTransaccion.FindAsync(id);
            _context.RegistroTransaccion.Remove(registroTransaccion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroTransaccionExists(int id)
        {
            return _context.RegistroTransaccion.Any(e => e.Id == id);
        }
    }
}
