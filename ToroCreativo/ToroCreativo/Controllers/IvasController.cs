using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class IvasController : Controller
    {
        private readonly IIvasBusiness _context;

        public IvasController(IIvasBusiness context)
        {
            _context = context;
        }

        // GET: Precios/Create
        public IActionResult Crear(int? id)
        {
            ViewBag.Producto = id;
            return View();
        }

        // POST: Precios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("idIva,IVA,F_Inicio,F_Fin,idProducto")] Iva ivas)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarIva(ivas);                
                return RedirectToAction("DetalleProducto", "ProductosCategoria", new { id = ivas.idProducto });

            }
            return View(ivas);
        }
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precio = await _context.ObtenerIvaPorId(id);
            if (precio == null)
            {
                return NotFound();
            }
            return View(precio);
        }
    }
}
