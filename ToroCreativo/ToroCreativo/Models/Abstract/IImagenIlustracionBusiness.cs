using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
     public interface IImagenIlustracionBusiness
    {
        
        
        Task GuardarEditarImagenIlustracion(ImagenIlustracion imagenIlustracion);
        Task EliminarImagenIlustracion(int id);
        Task<ImagenIlustracion> ObtenerImagenIlustracionPorId(int? id);
        List<ImagenIlustracion> ObtenerImagenesIlustracion(int? id);
        Task<List<ImagenIlustracion>> ImagenesIlustraciones();

    }
}
