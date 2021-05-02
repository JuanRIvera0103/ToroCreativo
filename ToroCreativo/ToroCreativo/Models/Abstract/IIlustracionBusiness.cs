using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IIlustracionBusiness
    {
        Task<IEnumerable<IlustracionDetalle>> ObtenerTodosLasIlustraciones();
        Task<Ilustracion> ObtenerIlustracionPorId(int? id);
        Task<int> CrearEditarIlustracion(Ilustracion ilustracion);
        Task<List<ImagenIlustracion>> ObtenerImagenesIlustracion(int? id);
        Task<IEnumerable<Generos>> ObtenerGenero();
        Task CambiarEstadoIlustracion(Ilustracion ilustracion);
        Task<IEnumerable<IlustracionDetalle>> ObtenerIlustracionesPorCategoria(int? id);
    }
}
