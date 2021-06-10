using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("idCaracteristicas,Color,Estado,idProducto,Medida")] Caracteristica caracteristica)
        {
            if (ModelState.IsValid)
            {
                
                int guardarEditar = await _context.GuardarEditarCaracteristica(caracteristica);
                if (guardarEditar == 0)
                    TempData["guardar"] = "si";
                else
                    TempData["editar"] = "si";                
                return RedirectToAction("DetalleProducto", "ProductosCategoria", new { id = caracteristica.idProducto });
            }
            return View(caracteristica);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }            
           
            var caracteristica = await _context.ObtenerCaracteristicaPorId(id);
            IEnumerable<Tamaño> listaTamaños = await _tamaños.ObtenerTamañosCaracteristica(id);
            ViewBag.Tamaños = listaTamaños;
            if (caracteristica == null)
            {
                return NotFound();
            }
            return View(caracteristica);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CambiarEstadoCaracteristica(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int caracteristicas = _context.VerificarCaracteristicaEnPedidos(id);
            var caracteristica = await _context.ObtenerCaracteristicaPorId(id);
            if (caracteristicas > 0)       
                TempData["Cambiar"] = "no";            
            else
            {
                await _context.CambiarEstadoCaracteristica(caracteristica);                
                TempData["Cambiar"] = "si";
            }                        

            return RedirectToAction("DetalleProducto", "ProductosCategoria", new { id = caracteristica.idProducto });
        }
    }
}
