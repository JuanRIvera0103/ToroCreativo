using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface ICalificacionBusiness
    {
        Task<List<CalificacionProducto>> ObtenerCalificacionesProducto(int? id);
        Task CrearEditarCalificacion(CalificacionProducto calificacionProducto);
        int ObtenerCalificacionesUsuario(string idUsuario, int? idProducto);
        Task<int> ValidarProductoPedido(string idUsuario, int? idProducto);
    }
}
