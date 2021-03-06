using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Business
{
    public class PedidoBusiness : IPedidoBusiness
    {
        private readonly DbContextToroCreativo _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<Usuario> _userManager;
        public PedidoBusiness(DbContextToroCreativo context, IWebHostEnvironment hostEnvironmen, UserManager<Usuario> userManager)
        {
            _context = context;
            this._hostEnvironment = hostEnvironmen;
            _userManager = userManager;
        }

        public async Task<IEnumerable<Pedido>> ObtenerPedidosPendientes() => await _context.Pedidos.Where(e => e.Estado=="Pendiente").ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerPedidosAceptados() => await _context.Pedidos.Where(e => e.Estado == "Aceptado").ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerPedidosCancelados() => await _context.Pedidos.Where(e => e.Estado == "Cancelado").ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerVentasSinEnviar() => await _context.Pedidos.Where(e => e.Estado == "Sin Enviar").ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerVentasPorEnviar() => await _context.Pedidos.Where(e => e.Estado == "Enviado").ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerPedidosPendientesCliente(string id) => await _context.Pedidos.Where(e => e.Estado == "Pendiente" && e.IdUsuario == id).ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerPedidosAceptadosCliente(string id) => await _context.Pedidos.Where(e => e.Estado == "Aceptado" && e.IdUsuario == id).ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerPedidosCanceladosCliente(string id) => await _context.Pedidos.Where(e => e.Estado == "Cancelado" && e.IdUsuario == id).ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerVentasSinEnviarCliente(string id) => await _context.Pedidos.Where(e => e.Estado == "Sin Enviar" && e.IdUsuario == id).ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerVentasEnviadasCliente(string id) => await _context.Pedidos.Where(e => e.Estado == "Enviado" && e.IdUsuario == id).ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerVentas(string id) => await _context.Pedidos.Where(e => (e.Estado == "Enviado" || e.Estado == "Sin Enviar") && e.IdUsuario == id).ToListAsync();

        public async Task<IEnumerable<Pedido>> ObtenerPedidosCliente(string id) => await _context.Pedidos.Where(e => e.IdUsuario == id && e.Estado != "Sin Enviar" && e.Estado != "Enviado").ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerVentasCliente(string id) => await _context.Pedidos.Where(e => e.IdUsuario == id && e.Estado != "Pendiente" && e.Estado != "Aceptado" && e.Estado != "Cancelado").ToListAsync();

        public async Task<Pedido> ObtenerPedidoPorID(int? id)
        {
            Pedido pedido;
            pedido = null;

            if (id == null)
            {
                return pedido;
            }
            else
            {
                pedido = await _context.Pedidos.FindAsync(id);
                return pedido;
            }
        }
        public PedidoDetalle ObtenerPedidoPorIDDetalle(int? id)
        {
            PedidoDetalle pedido;
            pedido = null;

            if (id == null)
            {
                return pedido;
            }
            else
            {
               
                    pedido =
                       (from pedidos in _context.Pedidos
                        join usuarios in _userManager.Users
                        on pedidos.IdUsuario equals usuarios.Id
                        where pedidos.IdPedido == id

                        select new PedidoDetalle
                        {
                            IdPedido = pedidos.IdPedido,
                            Nombre = pedidos.Nombre + " " + pedidos.Apellido,
                            Direccion = pedidos.Direccion,
                            Cedula = pedidos.Cedula,
                            Telefono = pedidos.Telefono,
                            Estado = pedidos.Estado,
                            FechaPedido = pedidos.FechaPedido.ToString("dd/MM/yyyy"),
                            FechaVenta = pedidos.FechaVenta.ToString("dd/MM/yyyy"),
                            Subtotal = string.Format("{0:#,##0}", pedidos.Subtotal),
                            TotalIva = string.Format("{0:#,##0}", pedidos.TotalIva),
                            Total = string.Format("{0:#,##0}", pedidos.Total),
                            Correo = usuarios.Email,
                            ImageName = pedidos.ImageName
                        }).FirstOrDefault();

                    return (pedido);
               
            }
        }


        public async Task AceptarPedido(Pedido pedido)
        {
            try
            {
                if (pedido.Estado.Equals("Pendiente"))
                    pedido.Estado = "Aceptado";
                else
                    pedido.Estado = "Pendiente";

                _context.Pedidos.Update(pedido);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public async Task CancelarPedido(Pedido pedido)
        {
            try
            {
                pedido.Estado = "Cancelado";

                _context.Pedidos.Update(pedido);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public async Task PedidoAVentaNoEnviada(Pedido pedido)
        {
            try
            {
                if (pedido.Estado.Equals("Aceptado"))
                    pedido.Estado = "Sin Enviar";
                else
                    pedido.Estado = "Aceptado";

                _context.Pedidos.Update(pedido);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public async Task VentaNoEnviadaAVentaEnviada(Pedido pedido)
        {
            try
            {
                if (pedido.Estado.Equals("Sin Enviar"))
                    pedido.Estado = "Enviado";
                else
                    pedido.Estado = "Sin Enviar";

                _context.Pedidos.Update(pedido);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public async Task AgregarComprobantePedido(Pedido pedido)
        {
            try
            {
                var pedido1 = await _context.Pedidos.FirstOrDefaultAsync(e => e.IdPedido == pedido.IdPedido);
                pedido1.ImageFile = pedido.ImageFile;
                
                if (pedido1.ImageName != null) {
                    
                    var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "comprobantes", pedido1.ImageName);
                    if (File.Exists(imagePath)) File.Delete(imagePath);
                }
               
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(pedido1.ImageFile.FileName);
                string extension = Path.GetExtension(pedido1.ImageFile.FileName);
                pedido1.ImageName = fileName = fileName + DateTime.Now.ToString("yymmsssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/comprobantes", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await pedido1.ImageFile.CopyToAsync(fileStream);
                }

                _context.Pedidos.Update(pedido1);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public async Task CrearEditarPedido(Pedido pedido)
        {
            try
            {
                if (pedido.IdPedido == 0)
                    _context.Add(pedido);
                else

                    _context.Update(pedido);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();

            }

        }
        public List<DetallePedidoTabla> ObtenerDetallePedidos(int? id)
        {
           
                List<DetallePedidoTabla> detallePedido =
                   (from detallepedido in _context.DetallePedidos
                    join caracteristicas in _context.caracteristicas
                    on detallepedido.IdCaracteristica equals caracteristicas.idCaracteristicas
                    join producto in _context.productos
                    on caracteristicas.idProducto equals producto.idProductos                    
                    where detallepedido.IdPedido == id

                    select new DetallePedidoTabla
                    {
                        IdCaractersiticas = caracteristicas.idCaracteristicas,
                        Producto = producto.Nombre,
                        Cantidad = detallepedido.Cantidad,
                        Subtotal = string.Format("{0:#,##0}", detallepedido.Subtotal),
                        TotalIva = string.Format("{0:#,##0}", detallepedido.TotalIva),
                        Total = string.Format("{0:#,##0}", detallepedido.Total)
                    
                    }).ToList();

                return (detallePedido);
           
        }

        public async Task<IEnumerable<Usuario>> ObtenerUsuario()
        {
            return await _userManager.Users.ToListAsync();

        }
        public async Task<Usuario> ObtenerUsuarioPorId(string id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<Pedido> VerificarComprobante(int? id)
        {
            
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido.ImageName != null)
                return pedido;
            else
                return null;
        }
        public async Task FinalizarPedido(Pedido pedido, List<CarritoDetalle> detalle)
        {
            try
            {
                if (pedido.IdPedido == 0)
                    _context.Add(pedido);
                await _context.SaveChangesAsync();
              var Pedido =await  _context.Pedidos.OrderByDescending(x => x.IdPedido).Take(1).FirstOrDefaultAsync();
                for (int i = 0; i<detalle.Count; i++)
                {
                    DetallePedido detallePedido = new DetallePedido
                    {
                        IdPedido = Pedido.IdPedido,
                        IdCaracteristica = detalle[i].IdCaracteristica,
                        Cantidad = detalle[i].Cantidad,
                        Subtotal = detalle[i].Subtotal* detalle[i].Cantidad,
                        TotalIva = detalle[i].IVA* detalle[i].Cantidad,
                        Total = detalle[i].Precio* detalle[i].Cantidad

                    };
                    _context.Add(detallePedido);
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();

            }


        }

    }
}
