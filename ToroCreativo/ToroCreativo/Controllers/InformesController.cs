using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Controllers
{
    public class InformesController : Controller
    {
        private readonly DbContextToroCreativo _context;
       
        public InformesController(DbContextToroCreativo context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> InformesProductos()
        {
            DateTime fechaAyer = DateTime.Today.AddDays(-1);
            DateTime fechaHoy = DateTime.Today;

            IEnumerable<InformesDatos> listaPedidos = null;
            await using (_context)
            {
                listaPedidos =
                (from detallePedidos in _context.DetallePedidos
                 join pedidos in _context.Pedidos
                 on detallePedidos.IdPedido equals pedidos.IdPedido
                 join caracteristicas in _context.caracteristicas
                 on detallePedidos.IdCaracteristica equals caracteristicas.idCaracteristicas
                 join producto in _context.productos
                 on caracteristicas.idProducto equals producto.idProductos                 
                 where pedidos.FechaPedido.Day == fechaHoy.Day
                        && pedidos.FechaPedido.Month == fechaHoy.Month
                        && pedidos.FechaPedido.Year == fechaHoy.Year
                 group detallePedidos by producto.Nombre into informe                 
                 select new InformesDatos
                 {
                     Nombre = informe.Key,
                     Cantidad = informe.Sum(s => s.Cantidad)

                 }).ToList();
            }
            int contador = 0;
            listaPedidos = listaPedidos.OrderByDescending(x => x.Cantidad).ToList();
            List<InformesDatos> listaInforme = new List<InformesDatos>();
            foreach (var item in listaPedidos)
            {
                listaInforme.Add(item);
                contador++;
                if (contador == 5)                
                    break;
                
            }

            TempData["Tipo"] = "diario";
            

            var datosJson = JsonConvert.SerializeObject(listaInforme);
            ViewBag.Datos = datosJson;
            return View(listaInforme);
        }

        public async Task<IActionResult> InformesCategorias()
        {
            DateTime fechaAyer = DateTime.Today.AddDays(-1);
            DateTime fechaHoy = DateTime.Today;

            IEnumerable<InformesDatos> listaPedidos = null;
            await using (_context)
            {
                listaPedidos =
                (from detallePedidos in _context.DetallePedidos
                 join pedidos in _context.Pedidos
                 on detallePedidos.IdPedido equals pedidos.IdPedido
                 join caracteristicas in _context.caracteristicas
                 on detallePedidos.IdCaracteristica equals caracteristicas.idCaracteristicas
                 join producto in _context.productos
                 on caracteristicas.idProducto equals producto.idProductos
                 join categorias in _context.categorias
                 on producto.Categoria equals categorias.idCategoria
                 where pedidos.FechaPedido.Day == fechaHoy.Day
                        && pedidos.FechaPedido.Month == fechaHoy.Month
                        && pedidos.FechaPedido.Year == fechaHoy.Year               
                 group detallePedidos by categorias.Nombre into informe
                 
                 select new InformesDatos
                 {
                     Nombre = informe.Key,
                     Cantidad = informe.Sum(s => s.Cantidad)

                 }).ToList();
            }
            int contador = 0;
            listaPedidos = listaPedidos.OrderByDescending(x => x.Cantidad).ToList();
            List<InformesDatos> listaInforme = new List<InformesDatos>();
            foreach (var item in listaPedidos)
            {
                listaInforme.Add(item);
                contador++;
                if (contador == 5)
                    break;

            }

            TempData["Tipo"] = "diario";

            
            var datosJson = JsonConvert.SerializeObject(listaInforme);
            ViewBag.Datos = datosJson;
            return View(listaInforme);
        }


        public async Task<IActionResult> InformesVentas()
        {
            DateTime fechaAyer = DateTime.Today.AddDays(-1);
            DateTime fechaHoy = DateTime.Today;


            int ventasAyer = await _context.Pedidos
                .Where(x => x.FechaVenta.Day == fechaAyer.Day
                && x.FechaVenta.Month == fechaAyer.Month
                && x.FechaVenta.Year == fechaAyer.Year).CountAsync();

            int ventasHoy = await _context.Pedidos
                .Where(x => x.FechaVenta.Day == fechaHoy.Day 
                && x.FechaVenta.Month == fechaHoy.Month
                && x.FechaVenta.Year == fechaHoy.Year).CountAsync();

                            
            List<InformesDatos> listaInforme = new List<InformesDatos>();
           
            
            for (int i = 0; i <= 1; i++)
            {
                
                if (i == 0)
                {
                    InformesDatos informe = new InformesDatos
                    {
                        Nombre = "Ayer",
                        Cantidad = ventasAyer
                    };
                    listaInforme.Add(informe);
                }                    
                else
                {
                    InformesDatos informe = new InformesDatos
                    {
                        Nombre = "Hoy",
                        Cantidad = ventasHoy
                    };
                    listaInforme.Add(informe);
                }                

                
            }

            TempData["Tipo"] = "diario";


            var datosJson = JsonConvert.SerializeObject(listaInforme);
            ViewBag.Datos = datosJson;
            return View(listaInforme);
        }
    }
}
