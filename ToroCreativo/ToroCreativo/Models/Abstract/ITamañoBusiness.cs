using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface ITamañoBusiness
    {
        Task<List<Tamaño>> ObtenerTamañosSelectProducto();
        Task<IEnumerable<TamañoDetalle>> ObtenerTamaños();
        Task<IEnumerable<Tamaño>> ObtenerTamañosSelectPorCategoria(int? id);
        Task<Tamaño> ObtenerTamañoPorId(int? id);
        Task GuardarEditarTamaño(Tamaño tamaño);

    }
}
