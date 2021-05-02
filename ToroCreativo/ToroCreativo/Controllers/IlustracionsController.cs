using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class IlustracionsController : Controller
    {
        private readonly IIlustracionBusiness _context;

        public IlustracionsController(IIlustracionBusiness context)
        {
            _context = context;   
        }

        // POST: Estados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdIlustracion,Nombre,IdGenero,Estado,Descripcion")] Ilustracion ilustracion)
        {

            if (ModelState.IsValid)
            {
                
                int guardarEditar = await _context.CrearEditarIlustracion(ilustracion);
                if (guardarEditar == 0)
                    TempData["guardar"] = "si";
                else
                    TempData["editar"] = "si";


                return RedirectToAction("Index", "GenerosIlustracions");
            }
            return View(ilustracion);
        }

    }
}
