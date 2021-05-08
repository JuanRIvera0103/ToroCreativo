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
                    (from ilustracion in _context.Ilustracions
                     join genero in _context.generos
                     on ilustracion.IdGenero equals genero.idGenero
                     select new IlustracionDetalle
                     {
                         IdIlustracion = ilustracion.IdIlustracion,
                         Nombre = ilustracion.Nombre,
                         Descripcion = ilustracion.Descripcion,
                         Estado = ilustracion.Estado,
                         Genero = genero.Nombre
                         //ImageName=Ilustracion.ImageName
                     }).ToList();
                return (ListaIlustracionDetalles);
            }
        }
        public async Task<IEnumerable<IlustracionDetalle>> ObtenerIlustracionesPorCategoria(int? id)
        {
            await using (_context)
            {

                IEnumerable<IlustracionDetalle> ListaIlustracionDetalles =
                    (from ilustracion in _context.Ilustracions
                     join genero in _context.generos
                     on ilustracion.IdGenero equals genero.idGenero
                     where ilustracion.IdGenero == id
                     select new IlustracionDetalle
                     {
                         IdIlustracion = ilustracion.IdIlustracion,
                         Nombre = ilustracion.Nombre,               
                         Estado = ilustracion.Estado,
                         Genero = genero.Nombre
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
        public async Task<int> CrearEditarIlustracion(IlustracionRegistroCompleto ilustracionRegistro)
        {
            try
            {
                int guardareditar = 1;
                if (ilustracionRegistro.IdIlustracion == 0)
                    guardareditar = 0;

                if (ilustracionRegistro.IdIlustracion == 0)
                {
                    var ilustracion = new Ilustracion
                    {
                        IdIlustracion = ilustracionRegistro.IdIlustracion,
                        Nombre = ilustracionRegistro.Nombre,
                        Descripcion = ilustracionRegistro.Descripcion,
                        IdGenero = ilustracionRegistro.IdGenero,
                        Estado = "Habilitado"
                    };
                    _context.Ilustracions.Add(ilustracion);
                    await _context.SaveChangesAsync();

                    var imagen = new ImagenIlustracion
                    {
                        IdImagenIlustracion = 0,
                        ImageName = ilustracionRegistro.ImageName,
                        ImageFile = ilustracionRegistro.ImageFile,
                        //Estado = "Principal",
                        IdIlustracion = ilustracion.IdIlustracion
                    };
                    _context.ImagenIlustraciones.Add(imagen);
                }
                else
                {
                    var ilustracion = new Ilustracion
                    {
                        IdIlustracion = ilustracionRegistro.IdIlustracion,
                        Nombre = ilustracionRegistro.Nombre,
                        Descripcion = ilustracionRegistro.Descripcion,
                        IdGenero = ilustracionRegistro.IdGenero,
                        Estado = ilustracionRegistro.Estado
                    };

                    _context.Ilustracions.Update(ilustracion);
                }


                await _context.SaveChangesAsync();

                return guardareditar;
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
        public async Task<List<ImagenIlustracion>> ObtenerImagenesIlustracion(int ? id)
        {
            return await _context.ImagenIlustraciones.Where(e => e.IdIlustracion == id).ToListAsync();
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
        public int VerificarIlustracionRepetida(string nombre)
        {
            return _context.Ilustracions.Where(i => i.Nombre == nombre).Count();
        }
        public async Task<IlustracionRegistroCompleto> ObtenerIlustracionPorIdIndex(int? id)
        {
            Ilustracion ilustracion;
            ilustracion = null;

            IlustracionRegistroCompleto ilustracionRegistro = null;
            if (id == null)
                return ilustracionRegistro;
            else
            {
                ilustracion = await _context.Ilustracions.FirstOrDefaultAsync(i => i.IdIlustracion == id);

                ilustracionRegistro = new IlustracionRegistroCompleto
                {
                    IdIlustracion = ilustracion.IdIlustracion,
                    Nombre = ilustracion.Nombre,
                    Descripcion = ilustracion.Descripcion,
                    IdGenero = ilustracion.IdGenero,
                    Estado = ilustracion.Estado
                };

                return ilustracionRegistro;
            }
        }
    }
}
