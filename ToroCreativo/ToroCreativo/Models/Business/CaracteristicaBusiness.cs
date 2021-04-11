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
    public class CaracteristicaBusiness:ICaracteristicaBusiness
    {
        private readonly DbContextToroCreativo _context;

        public CaracteristicaBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Caracteristica>> ObtenerCaracteristicasProducto(int? id)
        {

                await using (_context)
                {
                    IEnumerable<Caracteristica> caracteristicas =
                        (from caracteristica in _context.caracteristicas
                         where caracteristica.idProducto == id
                         select new Caracteristica
                         {
                             idCaracteristicas = caracteristica.idCaracteristicas,
                             Color = caracteristica.Color,
                             Medida = caracteristica.Medida,
                             Estado = caracteristica.Estado,
                             idProducto = caracteristica.idProducto
                         }).ToList();                    
                    return caracteristicas;
                }  
        }

        public async Task GuardarCaracteristica(Caracteristica caracteristica)
        {
            try
            {
                
                    caracteristica.Estado = "Habilitado";
                    _context.Add(caracteristica);
                

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
