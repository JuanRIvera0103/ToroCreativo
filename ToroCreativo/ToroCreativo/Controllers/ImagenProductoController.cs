using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class ImagenProductoController : Controller
    {
        private readonly IImagenProductoBusiness _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ImagenProductoController(IImagenProductoBusiness context, IWebHostEnvironment hostEnvironmen)
        {
            _context = context;
            this._hostEnvironment = hostEnvironmen;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdImagenProducto,IdProducto,ImageName,ImageFile,Estado")] ImagenProducto imagenProducto)
        {

            if (ModelState.IsValid)
            {
                imagenProducto.Estado = "Principal";

                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(imagenProducto.ImageFile.FileName);
                string extension = Path.GetExtension(imagenProducto.ImageFile.FileName);
                imagenProducto.ImageName = fileName = fileName + DateTime.Now.ToString("yymmsssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/imgProductos", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await imagenProducto.ImageFile.CopyToAsync(fileStream);
                }
                await _context.GuardarEditarImagenProducto(imagenProducto);

                return RedirectToAction("DetalleProducto", "ProductosCategoria", new { id = imagenProducto.IdProducto });
            }
            return View(imagenProducto);
        }


        // POST: ImagenIlustraciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var imagenIlustracion = await _context.ObtenerImagenProductoPorId(id);
            await _context.EliminarImagenProducto(id);
            return RedirectToAction("DetalleProducto", "ProductosCategoria", new { id = imagenIlustracion.IdProducto });
        }
    }
}
