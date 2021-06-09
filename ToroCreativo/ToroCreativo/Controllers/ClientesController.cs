using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToroCreativo.Clases;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;
using ToroCreativo.ViewModels.Usuario;

namespace ToroCreativo.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClientesBusiness _context;
        private readonly IPedidoBusiness _pedidoBusiness;
        private readonly IProductosBusiness _productosBusiness;

        public ClientesController(IClientesBusiness context, IPedidoBusiness pedidoBusiness, IProductosBusiness productosBusiness)
        {
            _context = context;
            _pedidoBusiness = pedidoBusiness;
            _productosBusiness = productosBusiness;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.ObtenerCliente());
        }
        
        public async Task<IActionResult> DetalleCliente(int? id)
        {
            if (id == null)            
                return NotFound();            
                       
            var cliente = await _context.ObtenerClienteDetalle(id);
            if (cliente == null)            
                return NotFound();            

            return View(cliente);
        }

        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productos = _context.VerificarUsuarioClientePedidos(id);
            if (productos > 0)            
                TempData["Cambiar"] = "no";            
            else
            {
                await _context.CambiarEstadoCliente(await _context.ObtenerClientePorID(id));
                TempData["Cambiar"] = "si";
            }            

            return RedirectToAction(nameof(Index));
        }
        // GET: Usuarios/Create
        public async Task<IActionResult> CrearEditar(int id = 0)
        {
            ViewData["Usuarios"] = new SelectList(await _context.ObtenerUsuario(),"Id", "Email");
            
            if (id == 0)
                return View(new Cliente());
            else
                return View(await _context.ObtenerClientePorID(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdCliente,Nombre,Apellido,IdUsuario,Estado,Direccion,Cedula,Telefono")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                await _context.CrearEditarCliente(cliente);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }        
        public async Task<IActionResult> Perfil()
        {
            var id= await _context.ObtenerClienteDetallePorUsuario(HttpContext.Session.GetString("usuario"));
            var usuario = HttpContext.Session.GetString("usuario");
            ViewBag.PedidosPendientes = await _pedidoBusiness.ObtenerPedidosPendientesCliente(usuario);
            ViewBag.PedidosAceptados = await _pedidoBusiness.ObtenerPedidosAceptadosCliente(usuario);
            ViewBag.PedidosCancelados = await _pedidoBusiness.ObtenerPedidosCanceladosCliente(usuario);
            ViewBag.VentasSinEnviar = await _pedidoBusiness.ObtenerVentasSinEnviarCliente(usuario);
            ViewBag.VentasEnviadas = await _pedidoBusiness.ObtenerVentasEnviadasCliente(usuario);
            TempData["Usuario"] = usuario;
            List<CarritoDetalle> detalle = _productosBusiness.ObtenerCarrito(HttpContext.Session);
            ViewBag.Carrito = detalle;
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

     
        [HttpPost]      
        public async Task<IActionResult> Perfil([Bind("IdCliente,Nombre,Apellido,Direccion,Cedula,Telefono")] PerfilViewModel perfil)
        {
            
            if (ModelState.IsValid)
            {
                Cliente cliente = new Cliente
                {
                    Nombre = perfil.Nombre,
                    Apellido = perfil.Apellido,
                    Cedula = perfil.Cedula,
                    Direccion = perfil.Direccion,
                    IdCliente = perfil.IdCliente,
                    Telefono = perfil.Telefono,
                    IdUsuario = HttpContext.Session.GetString("usuario"),
                    Estado = "Habilitado",
                };
                
                await _context.CrearEditarCliente(cliente);
                TempData["Editar"] = "si";
            }
            return RedirectToAction("Perfil", "Clientes");
        }
    }
}
