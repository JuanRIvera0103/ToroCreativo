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
    public class ImagenIlustracionesController : Controller
    {
        private readonly IImagenIlustracionBusiness _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ImagenIlustracionesController(IImagenIlustracionBusiness context, IWebHostEnvironment hostEnvironmen)
        {
            _context = context;
            this._hostEnvironment = hostEnvironmen;
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdImagenIlustracion,IdIlustracion,ImageName,ImageFile")] ImagenIlustracion imagenIlustracion)
        {
            imagenIlustracion.ImageName = "a";   
            imagenIlustracion.Estado = "Secundario";
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(imagenIlustracion.ImageFile.FileName);
            string extension = Path.GetExtension(imagenIlustracion.ImageFile.FileName);
            imagenIlustracion.ImageName = fileName = fileName + DateTime.Now.ToString("yymmsssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/imgIlustraciones", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await imagenIlustracion.ImageFile.CopyToAsync(fileStream);
            }
            await _context.GuardarEditarImagenIlustracion(imagenIlustracion);
            TempData["Imagen"] = "si";
            return RedirectToAction("DetalleIlustracion", "GenerosIlustracions", new { id = imagenIlustracion.IdIlustracion });

        }
            

        // POST: ImagenIlustraciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var imagenIlustracion = await _context.ObtenerImagenIlustracionPorId(id);
            await _context.EliminarImagenIlustracion(id);
            return RedirectToAction("Details", "Ilustracions", new { id = imagenIlustracion.IdIlustracion });
        }

       
    }
}
