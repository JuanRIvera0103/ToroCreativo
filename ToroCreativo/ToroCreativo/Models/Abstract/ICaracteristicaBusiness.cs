using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface ICaracteristicaBusiness
    {
        Task<Caracteristica> ObtenerCaracteristicaPorId(int? id);
        Task<IEnumerable<CaracteristicaDetalle>> ObtenerCaracteristicasProducto(int? id);
        Task<int> GuardarEditarCaracteristica(Caracteristica caracteristica);        
        Task CambiarEstadoCaracteristica(Caracteristica caracteristica);
        Task<IEnumerable<Caracteristica>> ObtenerCaracteristicasSelectPorProducto(int? id);
        Task<IEnumerable<CaracteristicaDetalle>> ObtenerCaracteristicaDetallePorId(int? id);
    }
}
