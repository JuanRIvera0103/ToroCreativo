using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly DbContextToroCreativo _context;

        public CategoriasController(DbContextToroCreativo context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
            return View(await _context.categorias.ToListAsync());
        }

        // GET: Categorias/Create
        public async Task <IActionResult> CrearEditar(int id = 0)
        {
            if (id == 0)
                return View(new Categorias());
            else
                return View(await _context.categorias.FindAsync(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("idCategoria,Nombre,Estado")] Categorias categorias)
        {
            if (ModelState.IsValid)
            {
                if (categorias.idCategoria == 0)
                {
                    _context.Add(categorias);
                }                    
                else
                {
                    _context.Update(categorias);
                }                    

                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }
            return View(categorias);
        }

        // GET: Categorias/Delete/5
       

        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorias = await _context.categorias
                .FirstOrDefaultAsync(m => m.idCategoria == id);

            if (categorias == null)
            {
                return NotFound();
            }
            try
            {
                if (categorias.Estado.Equals("Habilitado"))
                    categorias.Estado = "Deshabilitado";
                else
                    categorias.Estado = "Habilitado";

                _context.categorias.Update(categorias);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }

            return View("Index");
        }


        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var categorias = await _context.categorias
        //        .FirstOrDefaultAsync(m => m.idCategoria == id);
        //    if (categorias == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(categorias);
        //}
    }
}
      