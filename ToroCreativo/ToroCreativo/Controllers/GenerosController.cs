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
        // POST: Generos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("idGenero,Nombre,Estado")] Generos generos)
        {
            if (ModelState.IsValid)
            {
                int verificarGeneroRepetida = await _context.VerificarGeneroRepetido(generos.Nombre);
                if (verificarGeneroRepetida != 0)
                {
                    TempData["Repetido"] = "si";
                    return RedirectToAction("CrearEditarGenero", "GenerosIlustracions", new { id = generos.idGenero });
                }

                int guardarEditar = await _context.GuardarEditarGeneros(generos);
                if (guardarEditar == 0)
                    TempData["guardar"] = "si";
                else
                    TempData["editar"] = "si";

                return RedirectToAction("Index", "GenerosIlustracions");
            }
            return RedirectToAction("CrearEditarGenero", "GenerosIlustracions");
        }
    }
}
