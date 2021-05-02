using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class PedidosController : Controller
    {
        private readonly IPedidoBusiness _context;


        public PedidosController(IPedidoBusiness context)
        {
            _context = context;
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
        public async Task<IActionResult> PedidosClientes(string id)
        {
            IEnumerable<Pedido> aceptados = await _context.ObtenerPedidosAceptadosCliente(id);
            IEnumerable<Pedido> cancelados = await _context.ObtenerPedidosCanceladosCliente(id);
            ViewBag.Aceptados = aceptados;
            ViewBag.Cancelados = cancelados;
            return View(await _context.ObtenerPedidosPendientesCliente(id));


        }
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

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> PedidoAVenta(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Venta = await _context.ObtenerPedidoPorID(id);
            Venta.FechaVenta = DateTime.Now;
            await _context.PedidoAVentaNoEnviada(Venta);

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> VentaSinEnviarAVentaEnviada(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _context.VentaNoEnviadaAVentaEnviada(await _context.ObtenerPedidoPorID(id));

            return RedirectToAction(nameof(VentaIndex));
        }
        public async Task<IActionResult> AgregarComprobante(Pedido pedido)
        {

            await _context.AgregarComprobantePedido(pedido);

            return RedirectToAction(nameof(Index));
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

            
            var pedido = await _context.ObtenerPedidoPorID(id);
            
            IEnumerable<DetallePedido> listaDetalle = await _context.ObtenerDetallePedidos(id);
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

            IEnumerable<DetallePedido> listaDetalle = await _context.ObtenerDetallePedidos(id);
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

            IEnumerable<DetallePedido> listaDetalle = await _context.ObtenerDetallePedidos(id);
            ViewBag.DetallePedidos = listaDetalle;
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }
    }
}
