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
    public class CategoriasController : Controller
    {
        private readonly ICategoriasBusiness _context;

        public CategoriasController(ICategoriasBusiness context)
        {
            _context = context;
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditarCategoria([Bind("idCategoria,Nombre,Estado")] Categorias categorias)
        {
            if (ModelState.IsValid)
            {                
                var guardarEditar = await _context.GuardarEditarCategorias(categorias);
                if (guardarEditar == 0)
                    TempData["guardar"] = "si";
                else
                    TempData["editar"] = "si";
                return RedirectToAction("Index", "ProductosCategoria");
            }
            return View(categorias);
        }

    }
}
      