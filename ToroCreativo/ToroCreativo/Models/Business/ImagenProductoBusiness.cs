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
    public class ImagenProductoBusiness:IImagenProductoBusiness
    {

        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly DbContextToroCreativo _context;

        public ImagenProductoBusiness(DbContextToroCreativo context, IWebHostEnvironment hostEnvironmen)
        {
            _context = context;
            this._hostEnvironment = hostEnvironmen;
        }


        public async Task<List<ImagenProducto>> ObtenerImagenes()
        {
            return await _context.ImagenProductos.ToListAsync();
        }

        public async Task<List<ImagenProducto>> ObtenerImagenesProductoPorId(int? id)
        {
            var imagenProducto = await _context.ImagenProductos.Where(i => i.IdProducto == id).ToListAsync();
            return imagenProducto;
            
        }

        public async Task GuardarEditarImagenProducto(ImagenProducto imagenProducto)
        {
            try
            {
                if (imagenProducto.IdImagenProducto == 0)
                {
                    imagenProducto.Estado = "Secundario";
                    _context.Add(imagenProducto);
                }
                else
                    _context.Update(imagenProducto);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public async Task EliminarImagenProducto(int id)
        {

            var imagenProducto = await _context.ImagenProductos.FindAsync(id);
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "imgIlustraciones", imagenProducto.ImageName);
            if (System.IO.File.Exists(imagePath)) System.IO.File.Delete(imagePath);
            _context.ImagenProductos.Remove(imagenProducto);
            await _context.SaveChangesAsync();

        }

         public async Task<ImagenProducto> ObtenerImagenProductoPorProducto(int? id)
        {
            ImagenProducto imagenProducto;
            imagenProducto = null;

            if (id == null)
                return imagenProducto;
            else
            {
                imagenProducto = await _context.ImagenProductos.FirstOrDefaultAsync(e => e.IdProducto == id);
                return imagenProducto;
            }
        }
    }
}
