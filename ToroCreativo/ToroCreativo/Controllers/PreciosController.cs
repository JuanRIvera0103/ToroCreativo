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
        public async Task<IActionResult> CrearEditar([Bind("idPrecios,Valor,F_Inicio,F_Fin,idProducto")] Precio precio)
        {
            if (ModelState.IsValid)
            {
                int guardarEditar = await _context.GuardarEditarPrecio(precio);
                if (guardarEditar == 0)
                    TempData["guardarHistorial"] = "si";
                else
                    TempData["editar"] = "si";

                return RedirectToAction("DetalleProducto", "ProductosCategoria", new { id = precio.idProducto });
            }
            return View(precio);
        }

        // GET: Precios/Edit/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precio = await _context.ObtenerPreciosPorId(id);
            if (precio == null)
            {
                return NotFound();
            }
            return View(precio);
        }
    }
}
