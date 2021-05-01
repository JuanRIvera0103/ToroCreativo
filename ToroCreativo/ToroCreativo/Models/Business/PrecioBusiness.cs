using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<List<Precio>> ObtenerPreciosProducto(int? id)
        {
            return await _context.precios.OrderByDescending(p => p.idPrecios).Where(p => p.idProducto == id).ToListAsync();
        }
        public async Task<List<Precio>> ObtenerPrecios()
        {
            return await _context.precios.Where(p => p.F_Fin == null).ToListAsync();
        }

        public async Task GuardarEditarPrecio(Precio precio)
        {
            try
            {
                if (precio.idPrecios == 0)
                {
                    var ulimoprecio = _context.precios.Where(p => p.idProducto == precio.idProducto)
                        .OrderByDescending(p => p.idPrecios).FirstOrDefault();
                    if (ulimoprecio != null)
                    {
                        ulimoprecio.F_Fin = DateTime.Now;
                        _context.Update(ulimoprecio);
                    }
                    else
                    {
                        
                    }

                    precio.F_Inicio = DateTime.Now;
                    _context.Add(precio);
                }
                else
                {
                    _context.Update(precio);
                }                

                await _context.SaveChangesAsync();
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
