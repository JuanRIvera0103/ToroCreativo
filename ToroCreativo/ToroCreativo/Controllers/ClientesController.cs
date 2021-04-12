using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

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
        //public async Task<IActionResult> Index()
        //{


        //    return View(await _context.ObtenerCliente());


        //}

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
            IEnumerable<Usuario> listausuario = await _context.ObtenerUsuario();
            ViewBag.Usuarios = listausuario;
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
    }
}
