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
        private readonly IProductosBusiness _productosBusiness;
        private readonly ICategoriasBusiness _categoriasBusiness;
        private readonly ICaracteristicaBusiness _caracteristicaBusiness;
        private readonly IPrecioBusiness _precioBusiness;
        private readonly IIvasBusiness _ivasBusiness;
        private readonly IEntradaBusiness _entradaBusiness;
        private readonly IImagenProductoBusiness _imagenProductoBusiness;


        public ProductosCategoriaController(IProductosBusiness productosBusiness, ICategoriasBusiness categoriasBusiness,
            ICaracteristicaBusiness caracteristicaBusiness, IPrecioBusiness precioBusiness, IIvasBusiness ivasBusiness,
            IEntradaBusiness entradaBusiness, IImagenProductoBusiness imagenProductoBusiness)
        {
            _productosBusiness = productosBusiness;
            _categoriasBusiness = categoriasBusiness;
            _caracteristicaBusiness = caracteristicaBusiness;
            _precioBusiness = precioBusiness;
            _ivasBusiness = ivasBusiness;
            _entradaBusiness = entradaBusiness;
            _imagenProductoBusiness = imagenProductoBusiness;
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
            {
                var productos = await _categoriasBusiness.VerificarProductosHabilitados(id);
                if (productos > 0)
                {
                    TempData["Editar"] = "no";
                    return RedirectToAction(nameof(Index));
                }
                return View(await _categoriasBusiness.ObtenerCategoriaPorId(id));
            }
                
        }


        public async Task<IActionResult> CambiarEstadoCategoria(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productos = await _categoriasBusiness.VerificarProductosHabilitados(id);
            if (productos > 0)
            {
                TempData["Cambiar"] = "no";                
            }                     
            else
            {
                await _categoriasBusiness.CambiarEstadoCategoria(await _categoriasBusiness.ObtenerCategoriaPorId(id));
                TempData["Cambiar"] = "si";                              
            }                

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
            if (TempData["id"] != null)
                id = (int?)TempData["id"];
            if (id == null)
            {
                return NotFound();
            }
            var producto = await _productosBusiness.ObtenerProductoPorId(id);
            var categoria = await _categoriasBusiness.ObtenerCategoriaPorId(producto.Categoria);
            ViewData["categoria"] = categoria.Nombre;
            ViewData["precioTotal"] = await _precioBusiness.ObtenerPrecioConIvaProducto(producto.idProductos);
            var imagen = await _imagenProductoBusiness.ObtenerImagenProductoPorProducto(producto.idProductos);
            if (imagen != null)
                ViewBag.Imagen = imagen.ImageName;
            ViewBag.Precios = await _precioBusiness.ObtenerPreciosProducto(producto.idProductos);
            ViewBag.Ivas = await _ivasBusiness.ObteneIvasProducto(producto.idProductos);
            ViewBag.Entradas = await _entradaBusiness.ObtenerEntradaProducto(producto.idProductos);
            ViewBag.Caracteristicas = await _caracteristicaBusiness.ObtenerCaracteristicasProducto(id);
            return View(producto);

        }

        public IActionResult AgregarImagen(int id = 0)
        {

            ViewBag.id = id;

            return View(new ImagenProducto());


        }

        public async Task<IActionResult> ProductosCliente(int? id)
        {
            ViewBag.Precios = await _precioBusiness.ObtenerPrecios();
            ViewBag.Imagenes = await _imagenProductoBusiness.ObtenerImagenes();
            ViewBag.Categorias = await _categoriasBusiness.ObtenerCategorias();
            if (id == null)
                return View(await _productosBusiness.ObtenerProductosCliente());
            else
                return View(await _productosBusiness.ObtenerProductosPorCategoriaCliente(id));
        }
        [HttpPost]
        public async Task<IActionResult> ProductosCliente(string busqueda)
        {

            ViewBag.Precios = await _precioBusiness.ObtenerPrecios();
            ViewBag.Imagenes = await _imagenProductoBusiness.ObtenerImagenes();
            ViewBag.Categorias = await _categoriasBusiness.ObtenerCategorias();

            if (!string.IsNullOrEmpty(busqueda))
            {
                return View(await _productosBusiness.ObtenerProductosPorBusquedaCliente(busqueda));
            }
            else
                return View(await _productosBusiness.ObtenerProductosCliente());
        }


        public async Task<IActionResult> DetalleProductoCliente(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producto = await _productosBusiness.ObtenerProductoPorId(id);
            var categoria = await _categoriasBusiness.ObtenerCategoriaPorId(producto.Categoria);
            ViewData["categoria"] = categoria.Nombre;
            ViewData["precioTotal"] = await _precioBusiness.ObtenerPrecioConIvaProducto(producto.idProductos);
            var imagen = await _imagenProductoBusiness.ObtenerImagenProductoPorProducto(producto.idProductos);
            if (imagen != null)
                ViewBag.Imagen = imagen.ImageName;
            ViewBag.Precios = await _precioBusiness.ObtenerPreciosProducto(producto.idProductos);
            ViewBag.Ivas = await _ivasBusiness.ObteneIvasProducto(producto.idProductos);
            ViewBag.Entradas = await _entradaBusiness.ObtenerEntradaProducto(producto.idProductos);
            ViewBag.Caracteristicas = await _caracteristicaBusiness.ObtenerCaracteristicasProducto(id);
            return View(producto);

        }

    }
}
