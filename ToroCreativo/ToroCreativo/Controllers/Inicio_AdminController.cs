using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;
using ToroCreativo.ViewModels.Admin;

namespace ToroCreativo.Controllers
{
    public class Inicio_AdminController : Controller
    {
        private readonly DbContextToroCreativo _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Usuario> _userManager;


        public Inicio_AdminController(DbContextToroCreativo context, RoleManager<IdentityRole> roleManager, UserManager<Usuario> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;

        }
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult> Index()
        {
            ViewBag.Usuarios = await _context.Usuarios.CountAsync();
            ViewBag.Productos = await _context.productos.CountAsync();
            ViewBag.Ilustraciones = await _context.Ilustracions.CountAsync();
            return View();
        }
        public IActionResult CrearRol()
        {
            return View();
        }

    [HttpPost]
    public async Task<IActionResult> CrearRol(RolViewModel rolViewModel)
    {
        if (ModelState.IsValid)
        {

            IdentityRole rol = new IdentityRole
            {
                Name = rolViewModel.NombreRol
            };

            var result = await _roleManager.CreateAsync(rol);
            if (result.Succeeded)
                return RedirectToAction("ListarRoles");
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);

            }

        }
        return View(rolViewModel);
    }

    public IActionResult ListarRoles()
    {
        return View(_roleManager.Roles);
    }

    public async Task<IActionResult> EditarRol(string id)
    {
        var rol = await _roleManager.FindByIdAsync(id);
        if (rol == null)
        {
            ViewData["Error"] = $"El rol con id {id} no se encontró";
            return View("NotFound");
        }
        var editarRolViewModel = new EditarRolViewModel
        {
            Id = rol.Id,
            NombreRol = rol.Name
        };

        foreach (var usuario in _userManager.Users.ToList())
        {
            if (await _userManager.IsInRoleAsync(usuario, rol.Name))
            {
                editarRolViewModel.Usuarios.Add(usuario.UserName);
            }

        }
        return View(editarRolViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> EditarRol(EditarRolViewModel editarRolViewModel)
    {
        var rol = await _roleManager.FindByIdAsync(editarRolViewModel.Id);
        if (rol == null)
        {
            ViewData["Error"] = $"El rol con id {editarRolViewModel.Id} no se encontró";
            return View("NotFound");
        }
        else
        {
            rol.Name = editarRolViewModel.NombreRol;
            var result = await _roleManager.UpdateAsync(rol);
            if (result.Succeeded)
            {
                return RedirectToAction("ListarRoles");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);

            }
        }


        return View(editarRolViewModel);
    }

}
}
