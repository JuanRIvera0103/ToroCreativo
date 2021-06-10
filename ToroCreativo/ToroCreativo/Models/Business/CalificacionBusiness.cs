using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Business
{
    public class CalificacionBusiness: ICalificacionBusiness
    {
        private readonly DbContextToroCreativo _context;
        public CalificacionBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }
        public async Task<List<CalificacionProducto>> ObtenerCalificacionesProducto(int? id)
        {
            return await _context.CalificacionProductos.Where(c => c.IdProducto == id).ToListAsync();      
        }
        public async Task CrearEditarCalificacion(CalificacionProducto calificacionProducto)
        {
            try
            {
                if (calificacionProducto.IdCalificacion == 0)
                    _context.Add(calificacionProducto);
                else

                    _context.Update(calificacionProducto);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();

            }
        }
        public int ObtenerCalificacionesUsuario(string idUsuario, int? idProducto)
        {
            return  _context.CalificacionProductos.Where(c => c.IdUsuario == idUsuario && c.IdProducto == idProducto).Count();
        }
        public async Task<int> ValidarProductoPedido(string idUsuario, int? idProducto)
        {
            await using (_context)
            {
                IEnumerable<Pedido> listaProductoDetalle =
                    (from detallePedido in _context.DetallePedidos
                     join caracteristica in _context.caracteristicas
                     on detallePedido.IdCaracteristica equals caracteristica.idCaracteristicas
                     join producto in _context.productos
                     on caracteristica.idProducto equals producto.idProductos
                     join pedido in _context.Pedidos
                     on detallePedido.IdPedido equals pedido.IdPedido
                     where pedido.IdUsuario == idUsuario
                     where pedido.Estado == "Enviado" || pedido.Estado == "Enviada"
                     where producto.idProductos == idProducto                     

                     select new Pedido
                     {
                         IdPedido = pedido.IdPedido,                         

                     }).ToList();

                int pedidos = listaProductoDetalle.Count();
                return (pedidos);
            }
           
        }
    }
}
