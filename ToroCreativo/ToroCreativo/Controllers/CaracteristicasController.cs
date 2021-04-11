using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class CaracteristicasController : Controller
    {
        private readonly DbContextToroCreativo _context;

        public CaracteristicasController(DbContextToroCreativo context)
        {
            _context = context;
        }

        // GET: Caracteristicas
        public async Task<IActionResult> Index()
        {
            return View(await _context.caracteristicas.ToListAsync());
        }

      

        // GET: Caracteristicas/Create
        public IActionResult Crear(int? id)
        {
            ViewBag.Producto = id;
            return View();
        }

        // POST: Caracteristicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("idCaracteristicas,Color,Estado,idProducto,Medida")] Caracteristica caracteristica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caracteristica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caracteristica);
        }

        // GET: Caracteristicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caracteristica = await _context.caracteristicas.FindAsync(id);
            if (caracteristica == null)
            {
                return NotFound();
            }
            return View(caracteristica);
        }

        // POST: Caracteristicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCaracteristicas,Color,Estado,idProducto,Medida")] Caracteristica caracteristica)
        {
            if (id != caracteristica.idCaracteristicas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caracteristica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaracteristicaExists(caracteristica.idCaracteristicas))
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
            return View(caracteristica);
        }

        // GET: Caracteristicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caracteristica = await _context.caracteristicas
                .FirstOrDefaultAsync(m => m.idCaracteristicas == id);
            if (caracteristica == null)
            {
                return NotFound();
            }

            return View(caracteristica);
        }

        // POST: Caracteristicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caracteristica = await _context.caracteristicas.FindAsync(id);
            _context.caracteristicas.Remove(caracteristica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaracteristicaExists(int id)
        {
            return _context.caracteristicas.Any(e => e.idCaracteristicas == id);
        }
    }
}
