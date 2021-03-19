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
    public class ProductosCategoriaController : Controller
    {
        private readonly IProductosBusiness productosBusiness;
        private readonly ICategoriasBusiness categoriasBusiness;


        public ProductosCategoriaController(IProductosBusiness context, ICategoriasBusiness _context)
        {
            productosBusiness = context;
            categoriasBusiness = _context;
        }
               
        public async Task<IActionResult> Index()
        {
            ViewBag.Categorias = await categoriasBusiness.ObtenerCategorias();
            return View(await productosBusiness.ObtenerProductos());
        }

        //CRUD Categorias
        public async Task<IActionResult> CrearEditarCategoria(int id = 0)
        {
            if (id == 0)
                return View(new Categorias());
            else
                return View(await categoriasBusiness.ObtenerCategoriaPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditarCateoria([Bind("idCategoria,Nombre,Estado")] Categorias categorias)
        {
            if (ModelState.IsValid)
            {
                await categoriasBusiness.GuardarEditarCategorias(categorias);

                return RedirectToAction(nameof(Index));
            }
            return View(categorias);
        }


        public async Task<IActionResult> CambiarEstadoCategoria(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await categoriasBusiness.CambiarEstadoCategoria(await categoriasBusiness.ObtenerCategoriaPorId(id));

            return RedirectToAction(nameof(Index));
        }
           
        public async Task<IActionResult> DetalleCategoria(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Categoria = await categoriasBusiness.ObtenerCategoriaPorId(id);

            return View(await productosBusiness.ObtenerProductosPorCategoria(id));

        }

        //CRUD Productos

        public async Task<IActionResult> CrearEditarProducto(int id = 0)
        {
            if (id == 0)
                return View(new Productos());
            else
                return View(await productosBusiness.ObtenerProductoPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditarProducto([Bind("idProductos,Nombre,Descripcion,Estado,Categoria")] Productos productos)
        {
            if (ModelState.IsValid)
            {
                await productosBusiness.GuardarEditarProductos(productos);
                return RedirectToAction(nameof(Index));
            }
            return View(productos);
        }


        public async Task<IActionResult> CambiarEstadoProducto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await productosBusiness.CambiarEstadoProductos(await productosBusiness.ObtenerProductoPorId(id));

            return RedirectToAction(nameof(Index));
        }

    }
}
