using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IPrecioBusiness
    {
        Task<Precio> ObtenerPreciosPorId(int? id);
        Task<List<Precio>> ObtenerPreciosProducto(int? id);
        Task GuardarEditarPrecio(Precio precio);        
        Task<double> ObtenerPrecioConIvaProducto(int? id);
        Task<List<Precio>> ObtenerPrecios();
    }
}
