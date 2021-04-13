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
        Task CrearEditarIlustracion(Ilustracion ilustracion);

        Task<IEnumerable<Generos>> ObtenerGenero();
        Task CambiarEstadoIlustracion(Ilustracion ilustracion);
        Task<IEnumerable<IlustracionDetalle>> ObtenerIlustracionesPorCategoria(int? id);
    }
}
