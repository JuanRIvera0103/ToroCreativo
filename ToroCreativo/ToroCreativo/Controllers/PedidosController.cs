using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public PedidosController(IPedidoBusiness context, IClientesBusiness clientes, IProductosBusiness productos)
        {
            _context = context;
            _clientes = clientes;
            _productos = productos;
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
        public async Task<IActionResult> PedidosClientes(string id)
        {
            IEnumerable<Pedido> aceptados = await _context.ObtenerPedidosAceptadosCliente(id);
            IEnumerable<Pedido> cancelados = await _context.ObtenerPedidosCanceladosCliente(id);
            ViewBag.Aceptados = aceptados;
            ViewBag.Cancelados = cancelados;
            return View(await _context.ObtenerPedidosPendientesCliente(id));
        }
        [ActionName("VentasClientes")]
        public async Task<IActionResult> VentasClientes(string id)
        {
            IEnumerable<Pedido> SinEnviados = await _context.ObtenerVentasSinEnviarCliente(id);

            ViewBag.SinEnviados = SinEnviados;

            return View(await _context.ObtenerVentasPorEnviarCliente(id));


        }
        public async Task<IActionResult> AceptarPedido(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            TempData["CambiarPedido"] = "si";        
            await _context.AceptarPedido(await _context.ObtenerPedidoPorID(id));

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CancelarPedido(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            await _context.CancelarPedido(await _context.ObtenerPedidoPorID(id));
            TempData["CambiarPedido"] = "si";
            return RedirectToAction(nameof(Index));
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
            var Venta = await _context.ObtenerPedidoPorID(id);
            Venta.FechaVenta = DateTime.Now;
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
            await _context.VentaNoEnviadaAVentaEnviada(await _context.ObtenerPedidoPorID(id));

            return RedirectToAction(nameof(VentaIndex));
        }
        public async Task<IActionResult> AgregarComprobante(Pedido pedido)
        {

            await _context.AgregarComprobantePedido(pedido);
            TempData["Comprobante"] = "si";
            return RedirectToAction("Detalle", new { id = pedido.IdPedido });
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
        public async Task<IActionResult> Detalle(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var pedido = _context.ObtenerPedidoPorIDDetalle(id);
            IEnumerable<DetallePedidoTabla> listaDetalle = await _context.ObtenerDetallePedidos(id);
            ViewBag.DetallePedidos = listaDetalle;            
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }
        public IActionResult AgregarDetallePedido(int id = 0)
        {

            ViewBag.id = id;

            return View(new DetallePedido());


        }
        public async Task<IActionResult> PedidoVistaCliente()
        {
            string id = HttpContext.Session.GetString("usuario");
            IEnumerable<Pedido> aceptados = await _context.ObtenerPedidosAceptadosCliente(id);
            IEnumerable<Pedido> cancelados = await _context.ObtenerPedidosCanceladosCliente(id);
            ViewBag.Aceptados = aceptados;
            ViewBag.Cancelados = cancelados;
            return View(await _context.ObtenerPedidosPendientesCliente(id));


        }
        public async Task<IActionResult> VentasVistaCliente()
        {
            string id = HttpContext.Session.GetString("usuario");
            IEnumerable<Pedido> SinEnviados = await _context.ObtenerVentasSinEnviarCliente(id);

            ViewBag.SinEnviados = SinEnviados;

            return View(await _context.ObtenerVentasPorEnviarCliente(id));


        }
        public async Task<IActionResult> DetallePedidosCliente(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }


            var pedido = await _context.ObtenerPedidoPorID(id);

            List<DetallePedidoTabla> listaDetalle = await _context.ObtenerDetallePedidos(id);
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

            List<DetallePedidoTabla> listaDetalle = await _context.ObtenerDetallePedidos(id);
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
            double subtotal = 0;
            double iva = 0;
            double total = 0;
            List<CarritoDetalle> detalle = await _productos.ObtenerCarrito(HttpContext.Session);
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
                List<CarritoDetalle> detalle = await _productos.ObtenerCarrito(HttpContext.Session);
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
                return RedirectToAction(nameof(Index));
            }
            return View(datosPedido);
        }
    }
}
    
