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
        private readonly ICaracteristicaBusiness _caracteristicaBusiness;
        private readonly IProductosBusiness _productosBusiness;

        public EntradaController(IEntradaBusiness context, ICaracteristicaBusiness caracteristicaBusiness,
            IProductosBusiness productosBusiness)
        {
            _context = context;
            _caracteristicaBusiness = caracteristicaBusiness;
            _productosBusiness = productosBusiness;
        }

        // GET: Precios/Create
        public async Task<IActionResult> Crear(int? id)
        {

            var caracteristica = await _caracteristicaBusiness.ObtenerCaracteristicaDetallePorId(id);
            ViewBag.Caracteristicas = caracteristica;
            ViewBag.Producto = id;           
            return View();
        }

        // POST: Precios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("idIva,Cantidad,F_Inicio,F_Fin,Caracteristica,idProducto")] Entrada entrada)
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
