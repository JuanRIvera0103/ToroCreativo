using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IPedidoBusiness
    {
        Task<IEnumerable<Usuario>> ObtenerUsuario();
        Task CrearEditarPedido(Pedido pedido);
        Task AceptarPedido(Pedido pedido);
        Task<Pedido> ObtenerPedidoPorID(int? id);
        Task<IEnumerable<Pedido>> ObtenerPedidosPendientes();
        //Task<Usuario> ObtenerUsuarioPorId(int? id);
        Task AgregarComprobantePedido(Pedido pedido);
        Task CancelarPedido(Pedido pedido);
        Task PedidoAVentaNoEnviada(Pedido pedido);
        Task VentaNoEnviadaAVentaEnviada(Pedido pedido);
        Task<IEnumerable<Pedido>> ObtenerPedidosAceptados();
        Task<IEnumerable<Pedido>> ObtenerPedidosCancelados();
        Task<IEnumerable<Pedido>> ObtenerVentasSinEnviar();
        Task<IEnumerable<Pedido>> ObtenerVentasPorEnviar();
        Task<List<DetallePedido>> ObtenerDetallePedidos(int? id);
        }
}
