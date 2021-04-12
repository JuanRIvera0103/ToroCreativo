using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IPrecioBusiness
    {
        Task<List<Precio>> ObtenerPreciosProducto(int? id);
        Task GuardarPrecio(Precio precio);        
        Task<double> ObtenerPrecioConIvaProducto(int? id);
    }
}
