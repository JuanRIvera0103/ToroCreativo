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
    public class ProductosController : Controller
    {
        private readonly IProductosBusiness _context;

        public ProductosController(IProductosBusiness context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditarProductos([Bind("idProductos,Nombre,Descripcion,Estado,Categoria")] Productos productos)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarProductos(productos);
                return RedirectToAction("Index", "ProductosCategoria");
            }
            return View(productos);
        }

    }
}
