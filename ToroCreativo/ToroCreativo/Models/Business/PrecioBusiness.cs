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

        public async Task<List<Precio>> ObtenerPreciosProducto(int? id)
        {
            return await _context.precios.Where(p => p.idProducto == id).OrderByDescending(p => p.idPrecios).ToListAsync();
        }
        
        public async Task GuardarPrecio(Precio precio)
        {
            try
            {
                var ulimoprecio = _context.precios.OrderByDescending(p => p.idPrecios).FirstOrDefault();
                if(ulimoprecio != null)
                {
                    ulimoprecio.F_Fin = DateTime.Now.ToString("dd/MM/yyyy");
                    _context.Update(ulimoprecio);
                }
                
                precio.F_Inicio = DateTime.Now.ToString("dd/MM/yyyy");
                _context.Add(precio);

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
