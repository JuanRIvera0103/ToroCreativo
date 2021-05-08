using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToroCreativo.ViewModels.Usuario;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;
using Microsoft.AspNetCore.Http;

namespace ToroCreativo.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly IUsuarioBusiness _usuarioBusiness;
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsuariosController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, RoleManager<IdentityRole> roleManager, IUsuarioBusiness usuarioBusiness)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _usuarioBusiness = usuarioBusiness;
        }
        public async Task<IActionResult> Index()
        {
            /*
            var usuarios = await _userManager.Users.ToListAsync();
            return View(usuarios);
            */

            var usuarios = await _userManager.Users.ToListAsync();
            var listaUsuariosViewModel = new List<UsuarioViewModel>();

            foreach (var usuario in usuarios)
            {
                var usuarioViewModel = new UsuarioViewModel()
                {
                    Id = usuario.Id,
                    Estado= usuario.Estado,
                    Email = usuario.Email,
                    Rol = await ObtenerRolUsuario(usuario)
                };

                listaUsuariosViewModel.Add(usuarioViewModel);
            }

            return View(listaUsuariosViewModel);


        }

        private async Task<List<string>> ObtenerRolUsuario(Usuario usuario)
        {
            return new List<string>(await _userManager.GetRolesAsync(usuario));
        }

        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> CrearUsuario()
        {
            ViewData["Roles"] = new SelectList(await _roleManager.Roles.ToListAsync(), "Name", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearUsuario(UsuarioViewModel usuarioViewModel)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario
                {
                    UserName = usuarioViewModel.Email,
                    Email = usuarioViewModel.Email,
                    Estado="Habilitado"
                };

                try
                {
                    var result = await _userManager.CreateAsync(usuario, usuarioViewModel.Password);

                    if (result.Succeeded)
                    {
                        TempData["guardar"] = "si";

                        await _userManager.AddToRoleAsync(usuario, usuarioViewModel.RolSeleccionado);

                        return RedirectToAction("Index");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                catch (Exception)
                {

                    return View(usuarioViewModel);
                }

            }

            return View(usuarioViewModel);
        }

        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, loginViewModel.RecordarMe, false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
                    // Get the roles for the user
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Contains("Admin"))   { return RedirectToAction("Index", "Inicio_Admin"); }
                    if (roles.Contains("Cliente")) 
                    {
                        HttpContext.Session.SetString("usuario", user.Id);
                        await HttpContext.Session.CommitAsync();
                        return RedirectToAction("Index", "Home"); 
                    }

                }
                TempData["Invalido"] = "si";
            }


            return View();
        }

        public async Task<IActionResult> CerrarSesion()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Usuarios");
        }
        public IActionResult Registrar()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registrar(RegistrarViewModel registrarViewModel)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario
                {
                    UserName = registrarViewModel.Email,
                    Email = registrarViewModel.Email,
                    Estado = "Habilitado"
                };

                try
                {
                    var result = await _userManager.CreateAsync(usuario, registrarViewModel.Password);

                    if (result.Succeeded)
                    {
                        TempData["Crear"] = "si";                       

                        await _userManager.AddToRoleAsync(usuario, "Cliente");

                        return RedirectToAction("Login", "Usuarios");
                    }

                    foreach (var error in result.Errors)
                    {
                        TempData["Igual"] = "si";
                        ModelState.AddModelError("", error.Description);
                    }
                }
                catch (Exception)
                {

                    return View(registrarViewModel);
                }

            }

            return View(registrarViewModel);
        }


        public async Task<IActionResult> CambiarEstado(string id)
        {
            if (id == null)
            {
               return NotFound();
           }
            var usuarios = _usuarioBusiness.VerificarUsuarioPedidos(id);
            if (usuarios > 0)
                TempData["Cambiar"] = "no";
            else
            {
                await _usuarioBusiness.CambiarEstadoUsuario(await _usuarioBusiness.ObtenerUsuarioPorID(id));
                TempData["Cambiar"] = "si";
            }           
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CambiarContraseña()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CambiarContraseña(CambioContraseñaViewModel cambioContraseña)
        {
            if (ModelState.IsValid)
            {
               

                try
                {
                    var usuario = await _userManager.FindByIdAsync(HttpContext.Session.GetString("usuario"));
                     IdentityResult result = await _userManager.ChangePasswordAsync(usuario, cambioContraseña.PasswordAntigua, cambioContraseña.PasswordNueva);

                    if (result.Succeeded)
                    {
                        TempData["Accion"] = "Cambiar";
                        TempData["Mensaje"] = "Contraseña actualizada";
                        return RedirectToAction("Index", "Usuarios");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                catch (Exception)
                {

                    return View(cambioContraseña);
                }

            }

            return View(cambioContraseña);
        }




    }
}
