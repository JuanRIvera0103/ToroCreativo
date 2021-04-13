using Microsoft.AspNetCore.Hosting;
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
    public class IlustracionBusiness:IIlustracionBusiness
    {
        private readonly DbContextToroCreativo _context;

        public IlustracionBusiness(DbContextToroCreativo context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;

        }
        public async Task<IEnumerable<IlustracionDetalle>> ObtenerTodosLasIlustraciones()
        
        {
            await using (_context)
            {

                IEnumerable<IlustracionDetalle> ListaIlustracionDetalles =
                    (from Ilustracion in _context.Ilustracions
                     join genero in _context.generos
                     on Ilustracion.IdGenero equals genero.idGenero
                     select new IlustracionDetalle
                     {
                         IdIlustracion = Ilustracion.IdIlustracion,
                         Nombre = Ilustracion.Nombre,
                         Descripcion = Ilustracion.Descripcion,
                         Estado = Ilustracion.Estado,
                         Genero = genero.Nombre,
                         ImageName=Ilustracion.ImageName
                     }).ToList();
                return (ListaIlustracionDetalles);
            }
        }
        public async Task<Ilustracion> ObtenerIlustracionPorId(int? id)
        {
            try
            {
                Ilustracion ilustracion;
                ilustracion = null;
                if (id == null)
                    return ilustracion;
                else
                {
                    ilustracion = await _context.Ilustracions.FirstOrDefaultAsync(x => x.IdIlustracion == id);
                    return ilustracion;
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public async Task CrearEditarIlustracion(Ilustracion ilustracion)
        {
            try
            {
                if (ilustracion.IdIlustracion == 0)
                    _context.Add(ilustracion);
                else

                    _context.Update(ilustracion);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                
                throw new Exception();
                
            }

        }

        public async Task<IEnumerable<Generos>> ObtenerGenero()
        {
            return await _context.generos.ToArrayAsync();

        }

        public async Task CambiarEstadoIlustracion(Ilustracion ilustracion)
        {
            try
            {
                if (ilustracion.Estado.Equals("Habilitado"))
                    ilustracion.Estado = "Deshabilitado";
                else
                    ilustracion.Estado = "Habilitado";

                _context.Ilustracions.Update(ilustracion);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw new Exception();
            }
        }


        public async Task<IEnumerable<IlustracionDetalle>> ObtenerIlustracionesPorCategoria(int? id)
        {

            await using (_context)
            {
                IEnumerable<IlustracionDetalle> ListaIlustracionDetalles =
                    (from Ilustracion in _context.Ilustracions
                     join genero in _context.generos
                     on Ilustracion.IdGenero equals genero.idGenero
                     where Ilustracion.IdGenero == id
                     select new IlustracionDetalle
                     {
                         IdIlustracion = Ilustracion.IdIlustracion,
                         Nombre = Ilustracion.Nombre,
                         Descripcion = Ilustracion.Descripcion,
                         Estado = Ilustracion.Estado,
                         Genero = genero.Nombre,
                         ImageName = Ilustracion.ImageName
                     }).ToList();
                return (ListaIlustracionDetalles);
            }

        }
    }
}
