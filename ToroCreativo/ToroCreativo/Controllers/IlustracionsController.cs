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
        private readonly IWebHostEnvironment _hostEnvironment;

        public IlustracionsController(IIlustracionBusiness context, IWebHostEnvironment hostEnvironmen)
        {
            _context = context;
            this._hostEnvironment = hostEnvironmen;
        }

        // GET: Estados
        public async Task<IActionResult> Index()
        {
            return View(await _context.ObtenerTodosLasIlustraciones());
        }

        // GET: Estados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ilustracion = await _context.ObtenerIlustracionPorId(id);
            if (ilustracion == null)
            {
                return NotFound();
            }

            return View(ilustracion);
        }

        // GET: Estados/Create
        public async Task<IActionResult> CrearEditar(int id = 0)
        {
            IEnumerable<Generos> listagenero1 = await _context.ObtenerGenero();
            ViewBag.Generos = listagenero1;
            if (id == 0)
                return View(new Ilustracion());
            else
                return View(await _context.ObtenerIlustracionPorId(id));
        }

        // POST: Estados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdIlustracion,Nombre,IdGenero,Estado,Descripcion,ImageFile,ImageName ")] Ilustracion ilustracion)
        {

            if (ModelState.IsValid)
            {
                if (ilustracion.IdIlustracion > 0)
                {

                    var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "image", ilustracion.ImageName);
                    if (System.IO.File.Exists(imagePath)) System.IO.File.Delete(imagePath);

                }
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(ilustracion.ImageFile.FileName);
                string extension = Path.GetExtension(ilustracion.ImageFile.FileName);
                ilustracion.ImageName = fileName = fileName + DateTime.Now.ToString("yymmsssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/imgIlustraciones", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await ilustracion.ImageFile.CopyToAsync(fileStream);
                }


                await _context.CrearEditarIlustracion(ilustracion);

                return RedirectToAction(nameof(Index));
            }
            return View(ilustracion);
        }



        // GET: Estados/Delete/5
        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _context.CambiarEstadoIlustracion(await _context.ObtenerIlustracionPorId(id));

            return RedirectToAction(nameof(Index));
        }
    }
}
