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
                //Buscar otra manera de validar el crear
                //var hallarCategoria = await _context.ObtenerCategoriaPorId(categorias.idCategoria);
                await _context.GuardarEditarCategorias(categorias);                
                //if (hallarCategoria == null)
                //    TempData["Guardar"] = "si";
                //else
                    TempData["Editar"] = "si";
                return RedirectToAction("Index", "ProductosCategoria");
            }
            return View(categorias);
        }

    }
}
      