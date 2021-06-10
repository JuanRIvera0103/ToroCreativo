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
    public class TamañoController : Controller
    {
        private readonly ITamañoBusiness tamañoBusiness;
        private readonly ICategoriasBusiness categoriasBusiness;

        public TamañoController(ITamañoBusiness context, ICategoriasBusiness _context)
        {
            tamañoBusiness = context;
            categoriasBusiness = _context;
        }

        // GET: Tamaño
        public async Task<IActionResult> Index()
        {
            return View(await tamañoBusiness.ObtenerTamaños());
        }
        public async Task<IActionResult> CrearEditar(int id = 0)
        {
            IEnumerable<Categorias> listaCategorias = await categoriasBusiness.ObtenerCategoriasSelect();
            ViewBag.Categorias = listaCategorias;
            if(id == 0)
            {
                ViewData["Accion"] = "Crear";
                return View(new Tamaño());
            }
            else
            {
                ViewData["Accion"] = "Editar";
                return View(await tamañoBusiness.ObtenerTamañoPorId(id));
            }
                
        }

        // POST: Tamaño/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("idTamaño,Medida,Categoria")] Tamaño tamaño)
        {
            if (ModelState.IsValid)
            {
                if (tamaño.idTamaño == 0)                
                    TempData["guardar"] = "si";
                else
                    TempData["editar"] = "si";
                await tamañoBusiness.GuardarEditarTamaño(tamaño);
                return RedirectToAction(nameof(Index));
            }
            return View(tamaño);
        }
    }
}
