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
    public class DetallePedidosController : Controller
    {
          private readonly IDetallePedidoBusiness _context;
        
        public DetallePedidosController(IDetallePedidoBusiness context)
        {
            _context = context;
            
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdDetallePedido,IdPedido,IdCaracteristica,Cantidad,Subtotal,TotalIva,Total")] DetallePedido detallePedido)
        {
            
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarDetallePedido(detallePedido);

                return RedirectToAction("Detalle", "Pedidos", new { id=detallePedido.IdPedido }
                    );
            }
            return View(detallePedido);
        }


        // POST: ImagenIlustraciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var detallePedido = await _context.ObtenerDetallePedidoPorId(id);
            await _context.EliminarDetallePedido(id);
            return RedirectToAction("Detalle", "Pedidos", new { id = detallePedido.IdPedido });
        }

       
    }
}
