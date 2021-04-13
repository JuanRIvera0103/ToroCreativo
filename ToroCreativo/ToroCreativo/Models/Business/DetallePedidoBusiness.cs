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
    public class DetallePedidoBusiness : IDetallePedidoBusiness
    {
        private readonly DbContextToroCreativo _context;

        public DetallePedidoBusiness(DbContextToroCreativo context)
        {
            _context = context;

        }

        public async Task<DetallePedido> ObtenerDetallePedidoPorId(int? id)
        {
            DetallePedido detallePedido;
            detallePedido = null;

            if (id == null)
                return detallePedido;
            else
            {
                detallePedido = await _context.DetallePedidos.FirstOrDefaultAsync(e => e.IdDetallePedido == id);
                return detallePedido;
            }
        }

        public async Task GuardarEditarDetallePedido(DetallePedido detallePedido)
        {
            try
            {
                if (detallePedido.IdDetallePedido == 0)
                {

                    _context.Add(detallePedido);
                }
                else
                    _context.Update(detallePedido);

                await _context.SaveChangesAsync();
                var pedido = await _context.Pedidos.FirstOrDefaultAsync(e => e.IdPedido == detallePedido.IdPedido);
                pedido.Subtotal = await _context.DetallePedidos.Where(e => e.IdPedido == detallePedido.IdPedido).SumAsync(e => e.Subtotal);
                pedido.TotalIva = await _context.DetallePedidos.Where(e => e.IdPedido == detallePedido.IdPedido).SumAsync(e => e.TotalIva);
                pedido.Total = await _context.DetallePedidos.Where(e => e.IdPedido == detallePedido.IdPedido).SumAsync(e => e.Total);
                _context.Pedidos.Update(pedido);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public async Task EliminarDetallePedido(int id)
        {

            var detallePedido = await _context.DetallePedidos.FirstOrDefaultAsync(e => e.IdDetallePedido == id);
            _context.DetallePedidos.Remove(detallePedido);
            await _context.SaveChangesAsync();

        }

    }
}

