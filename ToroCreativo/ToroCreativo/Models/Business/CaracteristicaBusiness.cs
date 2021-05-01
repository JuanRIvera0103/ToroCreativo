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
        public async Task<IEnumerable<CaracteristicaDetalle>> ObtenerCaracteristicaDetallePorId(int? id)
        {
            await using (_context)
            {
                IEnumerable<CaracteristicaDetalle> caracteristicas =
                    (from caracteristica in _context.caracteristicas
                     join tamaño in _context.tamaños
                     on caracteristica.Medida equals tamaño.idTamaño
                     where caracteristica.idCaracteristicas == id
                     select new CaracteristicaDetalle
                     {
                         idCaracteristicas = caracteristica.idCaracteristicas,
                         Color = caracteristica.Color,
                         Medida = tamaño.Medida,
                         Estado = caracteristica.Estado,
                         idProducto = caracteristica.idProducto
                     }).ToList();
                return caracteristicas;
            }
        }
        public async Task<IEnumerable<CaracteristicaDetalle>> ObtenerCaracteristicasProducto(int? id)
        {

            await using (_context)
            {
                IEnumerable<CaracteristicaDetalle> caracteristicas =
                    (from caracteristica in _context.caracteristicas
                     join tamaño in _context.tamaños
                     on caracteristica.Medida equals tamaño.idTamaño
                     where caracteristica.idProducto == id
                     select new CaracteristicaDetalle
                     {
                         idCaracteristicas = caracteristica.idCaracteristicas,
                         Color = caracteristica.Color,
                         Medida = tamaño.Medida,
                         Estado = caracteristica.Estado,
                         idProducto = caracteristica.idProducto
                     }).ToList();
                return caracteristicas;
            }
        }

        public async Task<int> GuardarEditarCaracteristica(Caracteristica caracteristica)
        {
            try
            {
                int guadarEditar = 1;
                if (caracteristica.idCaracteristicas == 0)
                    guadarEditar = 0;

                if (caracteristica.idCaracteristicas == 0)
                {
                    caracteristica.Estado = "Habilitado";
                    _context.Add(caracteristica);
                }
                else
                    _context.Update(caracteristica);

                await _context.SaveChangesAsync();

                return guadarEditar;
                
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

        public async Task<IEnumerable<Caracteristica>> ObtenerCaracteristicasSelectPorProducto(int? id)
        {
            return await _context.caracteristicas.Where(c => c.idProducto == id).ToListAsync();
        }
    }
}
