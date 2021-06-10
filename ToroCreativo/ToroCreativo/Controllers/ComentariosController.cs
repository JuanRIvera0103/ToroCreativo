using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToroCreativo.Clases;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly IComentarioBusiness _context;


        public ComentariosController(IComentarioBusiness context)
        {
            _context = context;

        }
        
        public JsonResult ObtenerComentarios(int id)
        {
           
            List<ComentarioUsuario> listacomentario = new List<ComentarioUsuario>();
            listacomentario = _context.ObtenerComentariosPorIlustracionAsync(id);
            return Json(listacomentario);
        }

        [HttpPost]
        
        public async Task<IActionResult> CrearEditar([Bind("IdComentario,IdIlustracion,Texto")] Comentario comentario)
        {
            comentario.Fecha = DateTime.Now.ToShortDateString();
            comentario.IdUsuario = HttpContext.Session.GetString("usuario");

            await _context.CrearEditarComentario(comentario);

            return RedirectToAction("IlustracionesCliente", "GenerosIlustracions");

        }
    }
    
    
}
