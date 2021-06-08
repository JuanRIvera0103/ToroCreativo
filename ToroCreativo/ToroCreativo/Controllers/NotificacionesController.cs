using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class NotificacionesController : Controller
    {
        private readonly INotificacionesBusiness _context;
        

        public NotificacionesController(INotificacionesBusiness context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            return View();
        } 
        public JsonResult ObtenerNotificaciones(bool bIsGetOnlyUnread=false)
        {
            var IdUsuario = HttpContext.Session.GetString("usuario");
            List<Notificacion> listanotificacion = new List<Notificacion>();
            listanotificacion = _context.ObtenerNotificaciones(IdUsuario, bIsGetOnlyUnread);
            return Json(listanotificacion);
        }
        public JsonResult ObtenerNotificacionesAdmin()
        {
            
            List<Notificacion> listanotificacion = new List<Notificacion>();
            listanotificacion = _context.ObtenerNotificacionesAdmin();
            return Json(listanotificacion);
        }
    }
}
