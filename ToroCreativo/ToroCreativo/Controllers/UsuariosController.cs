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
    public class UsuariosController : Controller
    {
        private readonly IUsuarioBusiness _context;

        public UsuariosController(IUsuarioBusiness context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {


             return View(await _context.ObtenerUsuario());


        }
    

     

        // GET: Usuarios/Create
        public async Task <IActionResult> CrearEditar(int id =0)
        {
            IEnumerable<Rol> listarol = await _context.ObtenerRol();
            ViewBag.Roles = listarol;
            if (id == 0)
                return View(new Usuario());
            else
                return View(await _context.ObtenerUsuarioPorID(id));
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdUsuario,Correo,Contraseña,Estado,Rol")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarUsuario(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }







        public async Task<IActionResult> CambiarEstado(int? id)
        {
            if (id == null)
            {
               return NotFound();
           }

            await _context.CambiarEstadoUsuario(await _context.ObtenerUsuarioPorID(id));

            return RedirectToAction(nameof(Index));
        }





    }
}
