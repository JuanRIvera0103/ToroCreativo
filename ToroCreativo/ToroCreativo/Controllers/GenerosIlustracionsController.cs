using System;
using System.Collections.Generic;
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
    public class GenerosIlustracionsController : Controller
    {
        private readonly IGenerosBusiness _generosBusiness;
        private readonly IIlustracionBusiness _ilustracionBusiness;
        private readonly IWebHostEnvironment _hostEnvironment;

        public GenerosIlustracionsController(IGenerosBusiness generosBusiness, IIlustracionBusiness ilustracionBusiness, IWebHostEnvironment hostEnvironmen)
        {
            _generosBusiness = generosBusiness;
            _ilustracionBusiness = ilustracionBusiness;
            this._hostEnvironment = hostEnvironmen;
        }

        // GET: Estados
        public async Task<IActionResult> Index()
        {
            ViewBag.Generos = await _generosBusiness.ObtenerGeneros();
            return View(await _ilustracionBusiness.ObtenerTodosLasIlustraciones());
        }

        //CRUD Genero
        public async Task<IActionResult> CrearEditarGenero(int id = 0)
        {
            if (id == 0)
            {
                ViewData["CrearEditar"] = "Crear";
                return View(new Generos());
            }                
            else
            {
                int productos = await _generosBusiness.VerificarIlustracionesHabilitados(id);
                if (productos > 0)
                {
                    TempData["Editar"] = "no";
                    return RedirectToAction(nameof(Index));
                }
                ViewData["CrearEditar"] = "Editar";
                return View(await _generosBusiness.ObtenerGeneroPorId(id));
            }
        }
        public async Task<IActionResult> CambiarEstadoGenero(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int productos = await _generosBusiness.VerificarIlustracionesHabilitados(id);
            if (productos > 0)            
                TempData["Cambiar"] = "no";            
            else
            {
                await _generosBusiness.CambiarEstadoGenero(await _generosBusiness.ObtenerGeneroPorId(id));
                TempData["Cambiar"] = "si";
            }
           
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DetalleGenero(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Genero = await _generosBusiness.ObtenerGeneroPorId(id);

            return View(await _ilustracionBusiness.ObtenerIlustracionesPorCategoria(id));

        }

        //CRUD Ilustracione

        public async Task<IActionResult> DetalleIlustracion(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            IEnumerable<ImagenIlustracion> listaImagen = await _ilustracionBusiness.ObtenerImagenesIlustracion(id);
            ViewBag.Imagenes = listaImagen;
            var ilustracion = await _ilustracionBusiness.ObtenerIlustracionPorId(id);
            if (ilustracion == null)
            {
                return NotFound();
            }

            return View(ilustracion);
        }

        // GET: Estados/Create
        public async Task<IActionResult> CrearEditarIlustracion(int id = 0)
        {
            IEnumerable<Generos> listagenero = await _ilustracionBusiness.ObtenerGenero();
            ViewBag.Generos = listagenero;
            if (id == 0)
            {
                ViewData["CrearEditar"] = "Crear";
                return View(new IlustracionRegistroCompleto());
            }
            else
            {
                ViewData["CrearEditar"] = "Editar";
                return View(await _ilustracionBusiness.ObtenerIlustracionPorIdIndex(id));
            }
                
        }

        // GET: Estados/Delete/5
        public async Task<IActionResult> CambiarEstadoIlustracion(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            await _ilustracionBusiness.CambiarEstadoIlustracion(await _ilustracionBusiness.ObtenerIlustracionPorId(id));
            TempData["Cambiar"] = "si";

            return RedirectToAction(nameof(Index));
        }
        public IActionResult AgregarImagen(int id = 0)
        {
            ViewBag.id = id;
            return View(new ImagenIlustracion());


        }

    }
}
