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
    public class EntradaController : Controller
    {
        // GET: EntradaController
        private readonly IEntradaBusiness _context;

        public EntradaController(IEntradaBusiness context)
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
        public async Task<IActionResult> CrearEditar([Bind("idIva,Cantidad,F_Inicio,F_Fin,Caracteristica,idProducto")] Entrada entrada)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEntrada(entrada);
                TempData["id"] = entrada.idProducto;
                return RedirectToAction("DetalleProducto", "ProductosCategoria");
            }
            return View(entrada);
        }
    }
}
