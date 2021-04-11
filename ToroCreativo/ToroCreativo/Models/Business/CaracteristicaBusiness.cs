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
    public class CaracteristicaBusiness:ICaracteristicaBusiness
    {
        private readonly DbContextToroCreativo _context;

        public CaracteristicaBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }

        public async Task<Caracteristica> ObtenerCaracteristicaPorId(int? id)
        {
            return await _context.caracteristicas.FindAsync(id);
        }
        public async Task<IEnumerable<CaracteristicaDetalle>> ObtenerCaracteristicasProducto(int? id)
        {

            await using (_context)
            {
                IEnumerable<CaracteristicaDetalle> caracteristicas =
                    (from caracteristica in _context.caracteristicas

                     where caracteristica.idProducto == id
                     select new CaracteristicaDetalle
                     {
                         idCaracteristicas = caracteristica.idCaracteristicas,
                         Color = caracteristica.Color,
                         Medida = caracteristica.Color,
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
        public async Task EditarCaracteristica(Caracteristica caracteristica)
        {
            try
            {
                _context.Update(caracteristica);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public async Task CambiarEstadoCaracteristica(Caracteristica caracteristica)
        {
            try
            {
                if (caracteristica.Estado.Equals("Habilitado"))
                    caracteristica.Estado = "Deshabilitado";
                else
                    caracteristica.Estado = "Habilitado";

                _context.caracteristicas.Update(caracteristica);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
