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
        public async Task<IEnumerable<Pedido>> ObtenerVentasPorEnviarCliente(string id) => await _context.Pedidos.Where(e => e.Estado == "Enviado" && e.IdUsuario == id).ToListAsync();
        public async Task<IEnumerable<Pedido>> ObtenerVentas(string id) => await _context.Pedidos.Where(e => (e.Estado == "Enviado" || e.Estado == "Sin Enviar") && e.IdUsuario == id).ToListAsync();
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
                pedido = await _context.Pedidos.FirstOrDefaultAsync(e => e.IdPedido == id);
                return pedido;
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
                if (pedido.Estado.Equals("Pendiente"))
                    pedido.Estado = "Cancelado";
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
        public async Task<List<DetallePedido>> ObtenerDetallePedidos(int? id)
        {
            return await _context.DetallePedidos.Where(e => e.IdPedido == id).ToListAsync();
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
                        Subtotal = detalle[i].Subtotal,
                        TotalIva = detalle[i].IVA,
                        Total = detalle[i].Precio
                        
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
