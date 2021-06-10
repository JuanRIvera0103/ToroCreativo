using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class CalificacionController : Controller
    {
        private readonly ICalificacionBusiness _calificacionBusiness;

        public CalificacionController(ICalificacionBusiness calificacionBusiness)
        {
            _calificacionBusiness = calificacionBusiness;
        }
        public async Task<IActionResult> ObtenerCalificaciones(int id)
        {
            var calificaciones = await _calificacionBusiness.ObtenerCalificacionesProducto(id);
            double sumaCalificaciones = 0;
            foreach (var item in calificaciones)
            {
                sumaCalificaciones += item.Calificacion;
            }
            double cantidad = calificaciones.Count();
            double promedio = 0;
            if (cantidad != 0)            
                promedio = sumaCalificaciones / cantidad;
                                                    
            return Json(new { cantidad = cantidad, calificacion = promedio });
        }

        [HttpPost]

        public async Task<IActionResult> CrearEditar([Bind("IdProducto, Calificacion")] CalificacionProducto calificacionProducto)
        {
            calificacionProducto.IdUsuario = HttpContext.Session.GetString("usuario");

            await _calificacionBusiness.CrearEditarCalificacion(calificacionProducto);

            return RedirectToAction("DetalleProductoCliente", "ProductosCategoria", new { id = calificacionProducto.IdProducto});

        }

        public async Task<int> ValidarCalificacion(int? idProducto)
        {
            var usuario = HttpContext.Session.GetString("usuario");
            if (usuario == null)
                return 2;
            var calificaciones = _calificacionBusiness.ObtenerCalificacionesUsuario(usuario, idProducto);
            if (calificaciones > 0)
                return 3;
            var productoPedido = await _calificacionBusiness.ValidarProductoPedido(usuario, idProducto);
            if (productoPedido == 0)
                return 4;
            return 1;
        }
    }
}
