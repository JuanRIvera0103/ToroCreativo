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
    public class ProductosController : Controller
    {
        private readonly IProductosBusiness _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductosController(IProductosBusiness context, IWebHostEnvironment hostEnvironmen)
        {
            _context = context;
            _hostEnvironment = hostEnvironmen;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditarProductos([Bind("idProductos,Nombre,Descripcion,Categoria,Estado,Color,Medida,IVA,Valor,ImageName,ImageFile")] ProductoRegistroCompleto productos)
        {
            if (ModelState.IsValid)
            {
                if (productos.idProductos == 0)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(productos.ImageFile.FileName);
                    string extension = Path.GetExtension(productos.ImageFile.FileName);
                    productos.ImageName = fileName = fileName + DateTime.Now.ToString("yymmsssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/imgProductos", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await productos.ImageFile.CopyToAsync(fileStream);
                    }
                }                
                var guardarEditar = await _context.GuardarEditarProductos(productos);
                if (guardarEditar == 0)
                    TempData["guardar"] = "si";
                else
                    TempData["editar"] = "si";
                return RedirectToAction("Index", "ProductosCategoria");
            }
            return View(productos);
        }

    }
}
