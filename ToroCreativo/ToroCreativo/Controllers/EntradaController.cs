using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Crear(int? id)
        {

            var caracteristica = await _caracteristicaBusiness.ObtenerCaracteristicaDetallePorId(id);
            ViewBag.Caracteristicas = caracteristica;
            ViewBag.Producto = id;           
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("idEntrada,CantidadInicial, CantidadActual,F_Inicio,Caracteristica,idProducto")] Entrada entrada)
        {
            if (ModelState.IsValid)
            {
                entrada.CantidadActual = entrada.CantidadInicial;
                int guardarEditar = await _context.GuardarEditarEntrada(entrada);
                if (guardarEditar == 0)
                    TempData["guardarHistorial"] = "si";                
                else
                    TempData["editar"] = "si";
                return RedirectToAction("DetalleProducto", "ProductosCategoria", new { id = entrada.idProducto });
            }
            return View(entrada);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrada = await _context.ObtenerEntradaPorId(id);
            if (entrada == null)
            {
                return NotFound();
            }
            var caracteristica = await _caracteristicaBusiness.ObtenerCaracteristicaDetallePorId(entrada.Caracteristica);
            ViewBag.Caracteristicas = caracteristica;
            return View(entrada);
        }
    }
}
