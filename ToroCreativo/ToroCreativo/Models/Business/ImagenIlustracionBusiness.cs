using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Business
{
    public class ImagenIlustracionBusiness : IImagenIlustracionBusiness
    {

        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly DbContextToroCreativo _context;

            public ImagenIlustracionBusiness(DbContextToroCreativo context, IWebHostEnvironment hostEnvironmen)
            {
                _context = context;
            this._hostEnvironment = hostEnvironmen;
            }

            
            

            public async Task<ImagenIlustracion> ObtenerImagenIlustracionPorId(int? id)
            {
                ImagenIlustracion imagenIlustracion;
                imagenIlustracion = null;

                if (id == null)
                    return imagenIlustracion;
                else
                {
                    imagenIlustracion = await _context.ImagenIlustraciones.FirstOrDefaultAsync(e => e.IdImagenIlustracion == id);
                    return imagenIlustracion;
                }
            }

            public async Task GuardarEditarImagenIlustracion(ImagenIlustracion imagenIlustracion)
            {
                try
                {
                    if (imagenIlustracion.IdImagenIlustracion == 0)
                    {
                        
                        _context.Add(imagenIlustracion);
                    }
                    else
                        _context.Update(imagenIlustracion);

                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {

                    throw new Exception();
                }
            }
            
            public async Task EliminarImagenIlustracion(int id)
            {

                var imagenIlustracion = await _context.ImagenIlustraciones.FindAsync(id);
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "imgIlustraciones", imagenIlustracion.ImageName);
            if (System.IO.File.Exists(imagePath)) System.IO.File.Delete(imagePath);
            _context.ImagenIlustraciones.Remove(imagenIlustracion);
                await _context.SaveChangesAsync();
            
            }
            public async Task<List<ImagenIlustracion>> ImagenesIlustraciones()
            {            
                List<ImagenIlustracion> imagenIlustracion = await _context.ImagenIlustraciones.ToListAsync();
                return imagenIlustracion;
                
            }

            public List<ImagenIlustracion> ObtenerImagenesIlustracion(int? id)
            {            
                List<ImagenIlustracion> imagenIlustracion =  _context.ImagenIlustraciones.Where(i => i.IdIlustracion == id).ToList();
                return imagenIlustracion;
                
            }
        }
    }

