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
    public class IvasController : Controller
    {
        private readonly IIvasBusiness _context;

        public IvasController(IIvasBusiness context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Crear(int? id)
        {
            ViewBag.Producto = id;
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("idIva,IVA,F_Inicio,F_Fin,idProducto")] Iva ivas)
        {
            if (ModelState.IsValid)
            {
                
                int guardarEditar = await _context.GuardarEditarIva(ivas);
                if (guardarEditar == 0)
                    TempData["guardarHistorial"] = "si";
                else
                    TempData["editar"] = "si";
                return RedirectToAction("DetalleProducto", "ProductosCategoria", new { id = ivas.idProducto });

            }
            return View(ivas);
        }
        [Authorize(Roles = "Admin")]
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
