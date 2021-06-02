using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
        private readonly IWebHostEnvironment _hostEnvironment;

        public InformesController(DbContextToroCreativo context, IWebHostEnvironment hostEnvironmen)
        {
            _context = context;
            _hostEnvironment = hostEnvironmen;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> InformesProductos(int? tipoInforme)
        {
            DateTime fechaAnterior = DateTime.Today.AddDays(-1);
            DateTime fechaHoy = DateTime.Today;





            IEnumerable<InformesDatos> listaPedidos = null;
            if (tipoInforme == 1)
            {
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
                TempData["Tipo"] = "Informes Produtos más pedidos (diario)";
            }
            else if (tipoInforme == 2)
            {
                IEnumerable<Pedido> IEPedidos = null;
                int semanadelaños = CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(fechaHoy, CalendarWeekRule.FirstDay, fechaHoy.DayOfWeek);
                await using (_context)
                {
                    IEPedidos =
                    (from detallePedidos in _context.DetallePedidos
                     join pedidos in _context.Pedidos
                     on detallePedidos.IdPedido equals pedidos.IdPedido
                     join caracteristicas in _context.caracteristicas
                     on detallePedidos.IdCaracteristica equals caracteristicas.idCaracteristicas
                     join producto in _context.productos
                     on caracteristicas.idProducto equals producto.idProductos
                     where pedidos.FechaPedido.Month == fechaHoy.Month
                            && pedidos.FechaPedido.Year == fechaHoy.Year
                     select new Pedido
                     {

                         FechaPedido = pedidos.FechaPedido,


                     }).ToList();
                }


                TempData["Tipo"] = "Informes Produtos más pedidos (semanales)";
            }
            else if (tipoInforme == 3)
            {
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
                     where pedidos.FechaPedido.Month == fechaHoy.Month
                            && pedidos.FechaPedido.Year == fechaHoy.Year
                     group detallePedidos by producto.Nombre into informe
                     select new InformesDatos
                     {
                         Nombre = informe.Key,
                         Cantidad = informe.Sum(s => s.Cantidad)

                     }).ToList();
                }
                TempData["Tipo"] = "Informes Produtos más pedidos (mensuales)";

            }

            listaPedidos = listaPedidos.OrderByDescending(x => x.Cantidad).ToList();

            List<InformesDatos> listaInforme = new List<InformesDatos>();
            int contador = 0;
            foreach (var item in listaPedidos)
            {
                listaInforme.Add(item);
                contador++;
                if (contador == 5)
                    break;

            }



            var datosJson = JsonConvert.SerializeObject(listaInforme);
            ViewBag.Datos = datosJson;
            return View("Informes", listaInforme);
        }

        public async Task<IActionResult> InformesCategorias(int? tipoInforme)
        {
            DateTime fechaAyer = DateTime.Today.AddDays(-1);
            DateTime fechaHoy = DateTime.Today;

            IEnumerable<InformesDatos> listaPedidos = null;
            if (tipoInforme == 1)
            {
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
                TempData["Tipo"] = "Informes Categorías más vendidas (diario)";
            }
            else if (tipoInforme == 3)
            {
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
                     where pedidos.FechaPedido.Month == fechaHoy.Month
                            && pedidos.FechaPedido.Year == fechaHoy.Year
                     group detallePedidos by categorias.Nombre into informe

                     select new InformesDatos
                     {
                         Nombre = informe.Key,
                         Cantidad = informe.Sum(s => s.Cantidad)

                     }).ToList();
                }
                TempData["Tipo"] = "Informes Categorías más vendidas (mensuales)";
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




            var datosJson = JsonConvert.SerializeObject(listaInforme);
            ViewBag.Datos = datosJson;
            return View("Informes", listaInforme);
        }


        public async Task<IActionResult> InformesVentas(int? tipoInforme)
        {
            DateTime fechaHoy = DateTime.Today;
            int ventasAyer = 0;
            int ventasHoy = 0;
            if (tipoInforme == 1)
            {
                DateTime fechaAyer = DateTime.Today.AddDays(-1);

                ventasAyer = await _context.Pedidos
                               .Where(x => x.FechaVenta.Day == fechaAyer.Day
                               && x.FechaVenta.Month == fechaAyer.Month
                               && x.FechaVenta.Year == fechaAyer.Year).CountAsync();

                ventasHoy = await _context.Pedidos
                    .Where(x => x.FechaVenta.Day == fechaHoy.Day
                    && x.FechaVenta.Month == fechaHoy.Month
                    && x.FechaVenta.Year == fechaHoy.Year).CountAsync();
                TempData["Tipo"] = "Informes Ventas (diario)";
            }
            else if (tipoInforme == 3)
            {
                DateTime fechaAyer = DateTime.Today.AddMonths(-1);

                ventasAyer = await _context.Pedidos
                               .Where(x => x.FechaVenta.Month == fechaAyer.Month
                               && x.FechaVenta.Year == fechaAyer.Year).CountAsync();

                ventasHoy = await _context.Pedidos
                    .Where(x => x.FechaVenta.Month == fechaHoy.Month
                    && x.FechaVenta.Year == fechaHoy.Year).CountAsync();
                TempData["Tipo"] = "Informes Ventas (mensuales)";
            }

            List<InformesDatos> listaInforme = new List<InformesDatos>();
            InformesDatos informe = null;
            for (int i = 0; i < 2; i++)
            {
                if (tipoInforme == 1)
                {
                    if (i == 0)
                    {
                        informe = new InformesDatos
                        {
                            Nombre = "Ayer",
                            Cantidad = ventasAyer
                        };
                    }
                    else
                    {
                        informe = new InformesDatos
                        {
                            Nombre = "Hoy",
                            Cantidad = ventasHoy
                        };
                    }
                }
                else if (tipoInforme == 3)
                {
                    if (i == 0)
                    {
                        informe = new InformesDatos
                        {
                            Nombre = "Mes Anterior",
                            Cantidad = ventasAyer
                        };
                    }
                    else
                    {

                        informe = new InformesDatos
                        {
                            Nombre = "Mes Actual",
                            Cantidad = ventasHoy
                        };
                    }
                }


                listaInforme.Add(informe);
            }




            var datosJson = JsonConvert.SerializeObject(listaInforme);
            ViewBag.Datos = datosJson;
            return View("Informes", listaInforme);
        }

        [HttpPost]
        [ActionName("GenerarPDF")]
        public IActionResult GenerarPDF(InformePDF informePDF)
        {
            string imgBase64 = "";
            string wwwRootPath = _hostEnvironment.WebRootPath;
            List<string> listaImagenes = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                string imgName = "informe" + i + ".png";
                string path = Path.Combine(wwwRootPath + "/imgInformes", imgName);
                if (i == 0)
                {
                    imgBase64 = informePDF.DiagramaLineas.Substring(informePDF.DiagramaLineas.LastIndexOf(',') + 1);
                }
                else if (i == 1)
                {
                    imgBase64 = informePDF.DiagramaBarras.Substring(informePDF.DiagramaBarras.LastIndexOf(',') + 1);
                }
                else
                {
                    imgBase64 = informePDF.DiagramaCircular.Substring(informePDF.DiagramaCircular.LastIndexOf(',') + 1);
                }

                byte[] bytes = Convert.FromBase64String(imgBase64);

                System.IO.File.WriteAllBytes(path, bytes);
                listaImagenes.Add(path);
            }
            DateTime fechaActual = DateTime.Now;
            InformePDF informe = new InformePDF
            {
                Titulo = informePDF.Titulo,
                Fecha = fechaActual.ToString("dd/MM/yyyy"),
                Hora = fechaActual.ToString("hh:mm tt")
            };        
            return new ViewAsPdf("InformeProductosPDF", informe)
            {
                FileName = informe.Titulo + " " + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_tt") + ".pdf",
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape
           
            };
        }

        [ActionName("EliminarFotos")]
        public bool EliminarFotos()
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string path = wwwRootPath + "/imgInformes";
            List<string> Files = Directory.GetFiles(path, "*", SearchOption.AllDirectories).ToList();
            try
            {
                foreach (string fichero in Files)
                {
                    System.IO.File.Delete(fichero);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }            
            
        }

     
        public static int SemanaAño(DateTime fecha)
        {
            return CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(fecha, CalendarWeekRule.FirstDay, fecha.DayOfWeek);
        }
    }
}
