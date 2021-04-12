using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class PreciosController : Controller
    {
        private readonly IPrecioBusiness _context;

        public PreciosController(IPrecioBusiness context)
        {
            _context = context;
        }

        // GET: Precios/Create
        public IActionResult CrearEditar()
        {
            return View();
        }

        // POST: Precios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("idPrecios,Valor,F_Inicio,F_Fin,idProducto")] Precio precio)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarPrecio(precio);
                TempData["id"] = precio.idProducto;
                return RedirectToAction("DetalleProducto", "ProductosCategoria");
            }
            return View(precio);
        }

        //// GET: Precios/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var precio = await _context.precios.FindAsync(id);
        //    if (precio == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(precio);
        //}

        //// POST: Precios/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("idPrecios,Valor,F_Inicio,F_Fin,idProducto")] Precio precio)
        //{
        //    if (id != precio.idPrecios)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(precio);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PrecioExists(precio.idPrecios))
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
        //    return View(precio);
        //}
    }
}
