using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToroCreativo.Clases;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class IlustracionsController : Controller
    {
        private readonly IIlustracionBusiness _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public IlustracionsController(IIlustracionBusiness context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // POST: Estados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdIlustracion,Nombre,IdGenero,Estado,Descripcion,ImageName,ImageFile")] IlustracionRegistroCompleto ilustracion)
        {
            int verificarIlustracion = _context.VerificarIlustracionRepetida(ilustracion.Nombre);
            if (verificarIlustracion != 0)
            {
                TempData["Repetido"] = "si";
                return RedirectToAction("CrearEditarIlustracion", "GenerosIlustracions", new { id = ilustracion.IdIlustracion });
            }

            if (ilustracion.IdIlustracion == 0)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(ilustracion.ImageFile.FileName);
                    string extension = Path.GetExtension(ilustracion.ImageFile.FileName);
                    ilustracion.ImageName = fileName = fileName + DateTime.Now.ToString("yymmsssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/imgIlustraciones", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ilustracion.ImageFile.CopyToAsync(fileStream);
                    }                    
                }
            int guardarEditar = await _context.CrearEditarIlustracion(ilustracion);
            if (guardarEditar == 0)
                TempData["guardar"] = "si";
            else
                TempData["editar"] = "si";

            return RedirectToAction("Index", "GenerosIlustracions");

        }

    }
}
