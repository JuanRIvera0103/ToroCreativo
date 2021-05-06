using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public ClientesController(IClientesBusiness context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {


            return View(await _context.ObtenerCliente());


        }
        
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            
           
            var cliente = await _context.ObtenerClienteDetalle(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);



        }

        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _context.CambiarEstadoCliente(await _context.ObtenerClientePorID(id));

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

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                return RedirectToAction(nameof(Index));
            }
            return View(perfil);
        }
    }
}
