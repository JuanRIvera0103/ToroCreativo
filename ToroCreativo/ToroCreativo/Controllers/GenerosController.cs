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
    public class GenerosController : Controller
    {
        private readonly IGenerosBusiness _context;

        public GenerosController(IGenerosBusiness context)
        {
            _context = context;
        }

        // GET: Generos
        public async Task<IActionResult> Index()
        {
            return View(await _context.ObtenerGeneros());
        }


        // GET: Generos/Create
        public async Task<IActionResult> CrearEditar(int id = 0)
        {
            if (id == 0)
                return View(new Generos());
            else
                return View(await _context.ObtenerGeneroPorId(id));
            
        }

        // POST: Generos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("idGenero,Nombre,Estado")] Generos generos)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarGeneros(generos);

                return RedirectToAction(nameof(Index));
            }
            return View(generos);
        }


        // GET: Generos/Delete/5
        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await _context.CambiarEstadoGenero(await _context.ObtenerGeneroPorId(id));

            return RedirectToAction(nameof(Index));
        }

        // GET: Generos/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var generos = await _context.generos
        //        .FirstOrDefaultAsync(m => m.idGenero == id);
        //    if (generos == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(generos);
        //}

    }
}
