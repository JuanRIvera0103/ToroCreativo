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
using EmailService;
using AutoMapper;

namespace ToroCreativo.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly IUsuarioBusiness _usuarioBusiness;
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;
        public UsuariosController(IMapper mapper, IEmailSender emailSender, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, RoleManager<IdentityRole> roleManager, IUsuarioBusiness usuarioBusiness)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _usuarioBusiness = usuarioBusiness;
            _emailSender = emailSender;
        }
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        private async Task<List<string>> ObtenerRolUsuario(Usuario usuario)
        {
            return new List<string>(await _userManager.GetRolesAsync(usuario));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CrearUsuario()
        {
            ViewData["Roles"] = new SelectList(await _roleManager.Roles.ToListAsync(), "Name", "Name");
            return View();
        }
        [Authorize(Roles = "Admin")]
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
                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(usuario);
                        var user = await _userManager.FindByEmailAsync(usuario.Email);
                        if (user == null)
                            return View("Error");
                         await _userManager.ConfirmEmailAsync(user, token);
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
                    if (roles.Contains("Admin"))   { return RedirectToAction("Index", "InicioAdmin"); }
                    if (roles.Contains("Cliente")) 
                    {
                        HttpContext.Session.SetString("usuario", user.Id);
                        await HttpContext.Session.CommitAsync();
                        return RedirectToAction("Index", "Home"); 
                    }

                }
                else
                {
                    if (result.IsNotAllowed)
                        TempData["SinConfirmar"] = "si";
                    else
                        TempData["Invalido"] = "si";
                }
                
            }


            return View();
        }
        [Authorize(Roles = "Admin,Cliente")]
        public async Task<IActionResult> CerrarSesion()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
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
                            var token = await _userManager.GenerateEmailConfirmationTokenAsync(usuario);
                            var confirmationLink = Url.Action(nameof(ConfirmarEmail), "Usuarios", new { token, email = usuario.Email }, Request.Scheme);
                            var message = new Message(new string[] { usuario.Email }, "Confirmacion del email", confirmationLink, null);
                        string caso = "Usa este link para confimar tu cuenta, no compartas este link por seguridad";
                            await _emailSender.SendEmailAsync(message, caso);
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
        [HttpGet]
        public async Task<IActionResult> ConfirmarEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return View("Error");
            var result = await _userManager.ConfirmEmailAsync(user, token);
            TempData["EmailConfirmado"] = "si";
            return View(result.Succeeded ? nameof(Login) : "Error");
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
        [Authorize(Roles = "Cliente")]
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
                        TempData["CambioContraseña"] = "si";                                            
                    else
                        TempData["CambioContraseña"] = "no";
                }
                catch (Exception)
                {
                    return RedirectToAction("Perfil", "Clientes");
                }
            }
            return RedirectToAction("Perfil", "Clientes");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel forgotPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(forgotPasswordModel);
            var user = await _userManager.FindByEmailAsync(forgotPasswordModel.Email);
            if (user == null)
            {
                TempData["Existe"] = "no";
                return View(forgotPasswordModel);
            }
               
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "Usuarios", new { token, email = user.Email }, Request.Scheme);
            var message = new Message(new string[] { user.Email }, "Reestablecimiento de la contraseña", callback, null);
            string caso = "Usa este link para el reestablecimiento de tu contraseña de tu contraseña, no compartas este link por seguridad";
            await _emailSender.SendEmailAsync(message, caso);
            TempData["Existe"] = "si";
            return View();
        }
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            if (email == null || token == null)
                return RedirectToAction(nameof(Login));
            var model = new ResetPasswordViewModel { Token = token, Email = email };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordModel)
        {
            if (!ModelState.IsValid)
                return View(resetPasswordModel);
            if (resetPasswordModel.Email == null || resetPasswordModel.Token == null)
                return RedirectToAction(nameof(Login));
            var user = await _userManager.FindByEmailAsync(resetPasswordModel.Email);            
            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordModel.Token, resetPasswordModel.Password);
            if (!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View();
            }
            TempData["CambioContraseña"] = "si";
            return View();
        }
        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }       
    }
}
