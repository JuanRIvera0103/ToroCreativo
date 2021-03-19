using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.DAL;

namespace ToroCreativo.Controllers
{
    public class Inicio_AdminController : Controller
    {
        private readonly DbContextToroCreativo _context;

        public Inicio_AdminController(DbContextToroCreativo context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            ViewBag.Usuarios = await _context.Usuarios.CountAsync();            
            return View();
        }
    }
}
