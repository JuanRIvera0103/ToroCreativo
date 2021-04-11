using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface ICaracteristicaBusiness
    {
        Task<IEnumerable<Caracteristica>> ObtenerCaracteristicasProducto(int? id);
    }
}
