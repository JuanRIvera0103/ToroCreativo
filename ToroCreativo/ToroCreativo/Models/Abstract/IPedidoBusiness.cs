using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IPedidoBusiness
    {
        Task<IEnumerable<Pedido>> ObtenerVentas(string id);
        Task<IEnumerable<Pedido>> ObtenerVentasSinEnviarCliente(string id);
        Task<IEnumerable<Pedido>> ObtenerPedidosCanceladosCliente(string id);
        Task<IEnumerable<Pedido>> ObtenerPedidosAceptadosCliente(string id);
        Task<IEnumerable<Pedido>> ObtenerVentasPorEnviarCliente(string id);
        Task<IEnumerable<Pedido>> ObtenerPedidosPendientesCliente(string id);
        Task<IEnumerable<Usuario>> ObtenerUsuario();
        Task CrearEditarPedido(Pedido pedido);
        Task AceptarPedido(Pedido pedido);
        Task<Pedido> ObtenerPedidoPorID(int? id);
        Task<IEnumerable<Pedido>> ObtenerPedidosPendientes();
        Task<Usuario> ObtenerUsuarioPorId(string id);
        Task AgregarComprobantePedido(Pedido pedido);
        Task CancelarPedido(Pedido pedido);
        Task PedidoAVentaNoEnviada(Pedido pedido);
        Task VentaNoEnviadaAVentaEnviada(Pedido pedido);
        Task<IEnumerable<Pedido>> ObtenerPedidosAceptados();
        Task<IEnumerable<Pedido>> ObtenerPedidosCancelados();
        Task<IEnumerable<Pedido>> ObtenerVentasSinEnviar();
        Task<IEnumerable<Pedido>> ObtenerVentasPorEnviar();
        Task<List<DetallePedido>> ObtenerDetallePedidos(int? id);
        Task<Pedido> VerificarComprobante(int? id);
        Task FinalizarPedido(Pedido pedido, List<CarritoDetalle> detalle);
        }
}
