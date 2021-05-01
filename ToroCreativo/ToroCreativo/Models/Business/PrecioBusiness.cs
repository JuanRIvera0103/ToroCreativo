using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Business
{
    public class PrecioBusiness:IPrecioBusiness
    {
        private readonly DbContextToroCreativo _context;

        public PrecioBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }
        public async Task<Precio> ObtenerPreciosPorId(int? id)
        {
            return await _context.precios.FindAsync(id);
        }
        public async Task<List<PrecioDetalle>> ObtenerPreciosProducto(int? id)
        {
            var precios = await _context.precios.Where(p => p.idProducto == id).ToListAsync();
            List<PrecioDetalle> listaPrecios = new List<PrecioDetalle>();
            DateTime fechaActual = DateTime.Now;
            foreach (var precio in precios)
            {
                var precioDetalle = new PrecioDetalle
                {
                    idPrecios = precio.idPrecios,
                    Valor = precio.Valor,
                    F_Inicio = precio.F_Inicio,
                    F_Fin = precio.F_Fin,
                    idProducto = precio.idProducto,
                    Estado = ""
                };

                if (precioDetalle.F_Fin == null)
                {
                    TimeSpan diferencia = fechaActual - precioDetalle.F_Inicio;
                    var diferenciaMinutos = diferencia.TotalMinutes;

                    if (diferenciaMinutos < 5)
                        precioDetalle.Estado = "Valido";                    
                }
                else
                    precioDetalle.Estado = "Invalido";

                listaPrecios.Add(precioDetalle);
            }
            return listaPrecios;
        }
        public async Task<List<Precio>> ObtenerPrecios()
        {
            return await _context.precios.Where(p => p.F_Fin == null).ToListAsync();
        }

        public async Task<int> GuardarEditarPrecio(Precio precio)
        {
            try
            {
                int guadarEditar = 1;
                if (precio.idPrecios == 0)
                    guadarEditar = 0;

                if (precio.idPrecios == 0)
                {
                    var ulimoprecio = _context.precios.Where(p => p.idProducto == precio.idProducto)
                        .OrderByDescending(p => p.idPrecios).FirstOrDefault();
                    if (ulimoprecio != null)
                    {
                        ulimoprecio.F_Fin = DateTime.Now;
                        _context.Update(ulimoprecio);
                    }

                    precio.F_Inicio = DateTime.Now;
                    _context.Add(precio);
                }
                else
                    _context.Update(precio);
                        

                await _context.SaveChangesAsync();

                return guadarEditar;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }


        public async Task<double> ObtenerPrecioConIvaProducto(int? id)
        {
            var ultimoPrecio = await _context.precios.Where(p => p.idProducto == id)
                .OrderByDescending(p => p.idPrecios).FirstOrDefaultAsync();

            var ultimoIva = await _context.ivas.Where(p => p.idProducto == id)
                .OrderByDescending(p => p.idIva).FirstOrDefaultAsync();

            double precioTotal = 0;

            if (ultimoIva != null && ultimoPrecio != null)
            {
                precioTotal = ((ultimoIva.IVA / 100) * ultimoPrecio.Valor) + ultimoPrecio.Valor;
            }

            return precioTotal;

        }
    }
}
