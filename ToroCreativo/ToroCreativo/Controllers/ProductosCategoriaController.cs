﻿using System;
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
        private readonly IProductosBusiness _productosBusiness;
        private readonly ICategoriasBusiness _categoriasBusiness;
        private readonly ICaracteristicaBusiness _caracteristicaBusiness;


        public ProductosCategoriaController(IProductosBusiness productosBusiness, ICategoriasBusiness categoriasBusiness, 
            ICaracteristicaBusiness caracteristicaBusiness)
        {
            _productosBusiness = productosBusiness;
            _categoriasBusiness = categoriasBusiness;
            _caracteristicaBusiness = caracteristicaBusiness;
        }
               
        public async Task<IActionResult> Index()
        {
            ViewBag.Categorias = await _categoriasBusiness.ObtenerCategorias();
            return View(await _productosBusiness.ObtenerProductos());
        }

        //CRUD Categorias
        public async Task<IActionResult> CrearEditarCategoria(int id = 0)
        {
            if (id == 0)
                return View(new Categorias());
            else
                return View(await _categoriasBusiness.ObtenerCategoriaPorId(id));
        }


        public async Task<IActionResult> CambiarEstadoCategoria(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _categoriasBusiness.CambiarEstadoCategoria(await _categoriasBusiness.ObtenerCategoriaPorId(id));

            return RedirectToAction(nameof(Index));
        }
           
        public async Task<IActionResult> DetalleCategoria(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Categoria = await _categoriasBusiness.ObtenerCategoriaPorId(id);

            return View(await _productosBusiness.ObtenerProductosPorCategoria(id));

        }



        //CRUD Productos

        public async Task<IActionResult> CrearEditarProducto(int id = 0)
        {
            IEnumerable<Categorias> listaCategorias = await _categoriasBusiness.ObtenerCategoriasSelect();
            ViewBag.Categorias = listaCategorias;
            if (id == 0)
                return View(new Productos());
            else
                return View(await _productosBusiness.ObtenerProductoPorId(id));
        }



        public async Task<IActionResult> CambiarEstadoProducto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _productosBusiness.CambiarEstadoProductos(await _productosBusiness.ObtenerProductoPorId(id));

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DetalleProducto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producto = await _productosBusiness.ObtenerProductoPorId(id);
            ViewBag.Categoria = await _categoriasBusiness.ObtenerCategoriaPorId(producto.Categoria);
            ViewBag.Caracteristicas = await _caracteristicaBusiness.ObtenerCaracteristicasProducto(id);
            return View(producto);

        }

    }
}