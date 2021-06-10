using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ToroCreativo.Clases;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;
using ToroCreativo.ViewModels.Usuario;

namespace ToroCreativo.Controllers
{
    public class PedidosController : Controller
    {
        private readonly IPedidoBusiness _context;
        private readonly IClientesBusiness _clientes;
        private readonly IProductosBusiness _productos;
        private readonly IEntradaBusiness _entradas;
        private readonly INotificacionesBusiness _noti;
        public PedidosController(IPedidoBusiness context, IClientesBusiness clientes, IProductosBusiness productos, IEntradaBusiness entradas, INotificacionesBusiness noti)
        {
            _context = context;
            _clientes = clientes;
            _productos = productos;
            _entradas = entradas;
            _noti = noti;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            IEnumerable<Pedido> aceptados= await _context.ObtenerPedidosAceptados();
            IEnumerable<Pedido> cancelados=await _context.ObtenerPedidosCancelados();
            ViewBag.Aceptados = aceptados;
            ViewBag.Cancelados = cancelados;
            return View(await _context.ObtenerPedidosPendientes());


        }
        public async Task<IActionResult> VentaIndex()
        {
            IEnumerable<Pedido> SinEnviados = await _context.ObtenerVentasSinEnviar();
        
            ViewBag.SinEnviados = SinEnviados;
            
            return View(await _context.ObtenerVentasPorEnviar());


        }
        [ActionName("PedidosClientesDetalle")]
        public async Task<string> PedidosClientesDetalle(string id)
        {
            
            return JsonConvert.SerializeObject(await _context.ObtenerPedidosCliente(id));
        }

        [ActionName("VentasClientesDetalle")]
        public async Task<string> VentasClientesDetalle(string id)
        {            
            return JsonConvert.SerializeObject(await _context.ObtenerVentasCliente(id));
        }
        
        public async Task<IActionResult> AceptarPedido(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            List<DetallePedidoTabla> listaDetalle = _context.ObtenerDetallePedidos(id);
            
            var cantidad_deducida = 0;
            for (int i = 0; i<listaDetalle.Count; i++)
            {
               var entrada = await _entradas.ObtenerEntradaPorIdCaracteristica(listaDetalle[i].IdCaractersiticas);
                foreach (var entra in entrada)
                {
                   
                        cantidad_deducida = cantidad_deducida + entra.CantidadActual;
                    
                }
                 cantidad_deducida = cantidad_deducida- listaDetalle[i].Cantidad;
 
            }
            if (cantidad_deducida < 0)
            {
                TempData["CambiarPedido"] = "No";  
            }
            else
            {
                var pedido = await _context.ObtenerPedidoPorID(id);
                await _context.AceptarPedido(pedido);
                Notificacion notificacion = new Notificacion()
                {
                    IdUsuario = pedido.IdUsuario,
                    Direccion = pedido.IdPedido,
                    Fecha = DateTime.Now.ToShortDateString(),
                    Tipo="Aceptado",
                    Leido=false,
                };
                await _noti.CrearNotificacion(notificacion);
                TempData["CambiarPedido"] = "si";
            }



            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CancelarPedido(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.ObtenerPedidoPorID(id);
            await _context.CancelarPedido(pedido);
            Notificacion notificacion = new Notificacion()
            {
                IdUsuario = pedido.IdUsuario,
                Direccion = pedido.IdPedido,
                Fecha = DateTime.Now.ToShortDateString(),
                Tipo = "Cancelado",
                Leido = false,
            };                         
            
            await _noti.CrearNotificacion(notificacion);
            TempData["CambiarPedido"] = "si";
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CancelarPedidoCliente(int? id)
        {
            if (id == null)            
                return NotFound();

            var pedido = await _context.ObtenerPedidoPorID(id);
            await _context.CancelarPedido(pedido);
            TempData["CancelarPedido"] = "si";
            Notificacion notificacion = new Notificacion()
            {
                IdUsuario = pedido.IdUsuario,
                Direccion = pedido.IdPedido,
                Fecha = DateTime.Now.ToShortDateString(),
                Tipo = "CanceladoAdmin",
                Leido = false,
            };      

            await _noti.CrearNotificacion(notificacion);
            return RedirectToAction("Perfil", "Clientes");
        }
        public async Task<IActionResult> PedidoAVenta(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var comprobante = await _context.VerificarComprobante(id);
            if (comprobante == null)
            {
                TempData["Comprobante"] = "no";
                return RedirectToAction(nameof(Index));
            }
            List<DetallePedidoTabla> listaDetalle =  _context.ObtenerDetallePedidos(id);
            List<Entrada> entradasPorModificar = new List<Entrada>();
            var cantidad_total = 0;
            for (int i = 0; i < listaDetalle.Count; i++)
            {
                var entrada = await _entradas.ObtenerEntradaPorIdCaracteristica(listaDetalle[i].IdCaractersiticas);
                foreach (var entra in entrada)
                {

                    cantidad_total= cantidad_total + entra.CantidadActual;

                }
               int  cantidad_deducida = cantidad_total - listaDetalle[i].Cantidad;
                if (cantidad_deducida < 0)
                {
                    TempData["CambiarPedido"] = "No";
                    return RedirectToAction(nameof(Index));
                    
                    
                }
                else
                {
                    
                    int cantidad_descontada = 0;
                    for(int x =0; x < entrada.Count; x++)
                    {
                        if (x == 0)
                        {
                            cantidad_descontada = listaDetalle[i].Cantidad;
                        }
                        
                        
                       if(cantidad_descontada < entrada[x].CantidadActual)
                        {
                            
                            entrada[x].CantidadActual = entrada[x].CantidadActual - cantidad_descontada;
                            entradasPorModificar.Add(entrada[x]);
                            break;
                        }
                        
                        else if (cantidad_descontada >= entrada[x].CantidadActual && entrada[x].CantidadActual >0)
                        {
                            cantidad_descontada = cantidad_descontada - entrada[x].CantidadActual;
                            entrada[x].CantidadActual = 0;
                            entradasPorModificar.Add(entrada[x]);

                        }

                    }
                }

            }
            for(int y =0; y<entradasPorModificar.Count; y++)
            {
                await _entradas.GuardarEditarEntrada(entradasPorModificar[y]);
            }

            var Venta = await _context.ObtenerPedidoPorID(id);
            Venta.FechaVenta = DateTime.Now;
            
            Notificacion notificacion = new Notificacion()
            {
                IdUsuario = Venta.IdUsuario,
                Direccion = Venta.IdPedido,
                Fecha = DateTime.Now.ToShortDateString(),
                Tipo = "Vendido",
                Leido = false,
            };
            await _noti.CrearNotificacion(notificacion);
            await _context.PedidoAVentaNoEnviada(Venta);
            TempData["CambiarPedido"] = "si";
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> VentaSinEnviarAVentaEnviada(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            TempData["Enviada"] = "si";
            var pedido = await _context.ObtenerPedidoPorID(id);
            await _context.VentaNoEnviadaAVentaEnviada(pedido);
            Notificacion notificacion = new Notificacion()
            {
                IdUsuario = pedido.IdUsuario,
                Direccion = pedido.IdPedido,
                Fecha = DateTime.Now.ToShortDateString(),
                Tipo = "Enviado",
                Leido = false,
            };
            await _noti.CrearNotificacion(notificacion);

            return RedirectToAction(nameof(VentaIndex));
        }
        public async Task<IActionResult> AgregarComprobante(Pedido pedido)
        {

            await _context.AgregarComprobantePedido(pedido);                          
            TempData["Comprobante"] = "si";
            return RedirectToAction("Detalle", new { id = pedido.IdPedido });
        }
        public async Task<IActionResult> AgregarComprobanteCliente(Pedido pedido)
        {           
            await _context.AgregarComprobantePedido(pedido);
            Notificacion notificacion = new Notificacion()
            {
                IdUsuario = HttpContext.Session.GetString("usuario"),
                Direccion = pedido.IdPedido,
                Fecha = DateTime.Now.ToShortDateString(),
                Tipo = "Comprobante",
                Leido = false,

            };
            await _noti.CrearNotificacion(notificacion);
            TempData["Comprobante"] = "si";
            if (pedido.ImageName == "Detalle")
                return RedirectToAction("DetallePedidosCliente", new { id = pedido.IdPedido });
            else
                return RedirectToAction("Perfil","Clientes");
        }
        public async Task<IActionResult> CrearEditar(int id = 0)
        {
            ViewData["Usuarios"] = new SelectList(await _context.ObtenerUsuario(), "Id", "Email");
            if (id == 0)
                return View(new Pedido());
            else
                return View(await _context.ObtenerPedidoPorID(id));
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdPedido,Nombre,Apellido,IdUsuario,Estado,Direccion,Cedula,Telefono,FechaPedido,FechaVenta,Subtotal,TotalIva,Total,ImageName")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                pedido.FechaPedido = DateTime.Now;
                await _context.CrearEditarPedido(pedido);
                return RedirectToAction(nameof(Index));
            }
            return View(pedido);
        }
        public IActionResult Detalle(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var pedido = _context.ObtenerPedidoPorIDDetalle(id);
            IEnumerable<DetallePedidoTabla> listaDetalle = _context.ObtenerDetallePedidos(id);
            ViewBag.DetallePedidos = listaDetalle;            
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }
        public IActionResult DetallePedidosCliente(int? id)
        {

            if (id == null)
                return NotFound();
     
            var usuario = HttpContext.Session.GetString("usuario");
            TempData["Usuario"] = usuario;
            var pedido = _context.ObtenerPedidoPorIDDetalle(id);

            List<DetallePedidoTabla> listaDetalle =  _context.ObtenerDetallePedidos(id);
            ViewBag.DetallePedidos = listaDetalle;
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }
        public async Task<IActionResult> DetalleVentasCliente(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }


            var pedido = await _context.ObtenerPedidoPorID(id);

            List<DetallePedidoTabla> listaDetalle =  _context.ObtenerDetallePedidos(id);
            ViewBag.DetallePedidos = listaDetalle;
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }
        
        public async Task<IActionResult> FinalizarPedido()
        {
            var id = await _clientes.ObtenerClienteDetallePorUsuario(HttpContext.Session.GetString("usuario"));
            var usuario = HttpContext.Session.GetString("usuario");
            TempData["Usuario"] = usuario;
            double subtotal = 0;
            double iva = 0;
            double total = 0;
            List<CarritoDetalle> detalle = _productos.ObtenerCarrito(HttpContext.Session);
            if (detalle.Count == 0)            
                return RedirectToAction("Index", "Home");            
            ViewBag.Carrito = detalle;           
            for (int i = 0; i < detalle.Count; i++)
            {
                subtotal = detalle[i].Subtotal + subtotal;
                iva = detalle[i].IVA + iva;
                total = detalle[i].Precio + total;

            }
            ViewBag.Subtotal = subtotal;
            ViewBag.IVA = iva;
            ViewBag.Total = total;
            if (id == null)
                return View(new PerfilViewModel());
            else
            {
                PerfilViewModel perfil = new PerfilViewModel
                {
                    Nombre = id.Nombre,
                    Apellido = id.Apellido,
                    Cedula = id.Cedula,
                    Direccion = id.Direccion,
                    IdCliente = id.IdCliente,
                    Telefono = id.Telefono
                };
                return View(perfil);
            }

        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FinalizarPedido([Bind("IdCliente,Nombre,Apellido,Direccion,Cedula,Telefono")] PerfilViewModel datosPedido)
        {

            if (ModelState.IsValid)
            {
                double subtotal = 0;
                double iva = 0;
                double total = 0;
                List<CarritoDetalle> detalle = _productos.ObtenerCarrito(HttpContext.Session);
                for (int i=0; i<detalle.Count; i++)
                {
                    subtotal = detalle[i].Subtotal + subtotal;
                    iva = detalle[i].IVA + iva;
                    total = detalle[i].Precio + total;

                }
                Pedido pedido = new Pedido
                {
                    Nombre = datosPedido.Nombre,
                    Apellido = datosPedido.Apellido,
                    Cedula = datosPedido.Cedula,
                    Direccion = datosPedido.Direccion,
                    Total = total,
                    Subtotal = subtotal,
                    TotalIva = iva ,
                    FechaPedido = DateTime.Now,
                    Telefono = datosPedido.Telefono,
                    IdUsuario = HttpContext.Session.GetString("usuario"),
                    Estado = "Pendiente",
                };
                
                await _context.FinalizarPedido(pedido, detalle);
                List<Carrito> carrito = new List<Carrito>();                
                HttpContext.Session.SetString("Carrito", JsonConvert.SerializeObject(carrito));
                Notificacion notificacion = new Notificacion()
                {
                    IdUsuario = pedido.IdUsuario,
                    Direccion = pedido.IdPedido,
                    Fecha = DateTime.Now.ToShortDateString(),
                    Tipo = "Pendiente",
                    Leido = false,
                };
                await _noti.CrearNotificacion(notificacion);
                TempData["FinalizarPedido"] = "si";
                return RedirectToAction("ProductosCliente", "ProductosCategoria");
            }
            return View(datosPedido);
        }
    }

}
    
