using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class HomeController : Controller
    {        
        private readonly DbContextToroCreativo _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly IProductosBusiness _productosBusiness;


        public HomeController(DbContextToroCreativo context, RoleManager<IdentityRole> roleManager, UserManager<Usuario> userManager,
            IProductosBusiness productosBusiness)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            _productosBusiness = productosBusiness;

        }
        
        public async Task<IActionResult> Index()
        {
            var usuario = HttpContext.Session.GetString("usuario");
            TempData["Usuario"] = usuario;
            TempData["Principal"] = "si";
            List<CarritoDetalle> detalle = await _productosBusiness.ObtenerCarrito(HttpContext.Session);
            ViewBag.Carrito = detalle;
            var productos = await _productosBusiness.ObtenerProductosCliente();            
            ViewBag.Productos = productos;
            return View();
        }

        
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
