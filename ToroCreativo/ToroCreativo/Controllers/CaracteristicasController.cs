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
    public class CaracteristicasController : Controller
    {
        private readonly ICaracteristicaBusiness _context;
        private readonly ITamañoBusiness _tamaños;
        private readonly IProductosBusiness _productosBusiness;

        public CaracteristicasController(ICaracteristicaBusiness context,
            IProductosBusiness productosBusiness, ITamañoBusiness tamañoBusiness)
        {
            _context = context;            
            _productosBusiness = productosBusiness;
            _tamaños = tamañoBusiness;
        }

        // GET: Caracteristicas/Create
        public async Task<IActionResult> Crear (int? id)
        {
            var producto = await _productosBusiness.ObtenerProductoPorId(id);
            IEnumerable<Tamaño> listaTamaños = await _tamaños.ObtenerTamañosSelectPorCategoria(producto.Categoria);
            ViewBag.Tamaños = listaTamaños;
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
                await _context.GuardarCaracteristica(caracteristica);
                TempData["id"] = caracteristica.idProducto;
                return RedirectToAction("DetalleProducto", "ProductosCategoria");
            }
            return View(caracteristica);
        }

        // GET: Caracteristicas/Edit/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producto = await _productosBusiness.ObtenerProductoPorId(id);
            IEnumerable<Tamaño> listaTamaños = await _tamaños.ObtenerTamañosSelectPorCategoria(producto.Categoria);
            ViewBag.Tamaños = listaTamaños;
            var caracteristica = await _context.ObtenerCaracteristicaPorId(id);
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
        public async Task<IActionResult> Editar(int id, [Bind("idCaracteristicas,Color,Estado,idProducto,Medida")] Caracteristica caracteristica)
        {
            if (id != caracteristica.idCaracteristicas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await _context.EditarCaracteristica(caracteristica);
                TempData["id"] = caracteristica.idProducto;
                return RedirectToAction("DetalleProducto", "ProductosCategoria");
            }
            return View(caracteristica);
        }

        public async Task<IActionResult> CambiarEstadoCaracteristica(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _context.CambiarEstadoCaracteristica(await _context.ObtenerCaracteristicaPorId(id));

            return RedirectToAction(nameof(Index));
        }
    }
}
