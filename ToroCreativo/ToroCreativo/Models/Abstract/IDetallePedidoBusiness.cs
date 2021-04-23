using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
     public interface IDetallePedidoBusiness
    {
        Task<DetallePedido> ObtenerDetallePedidoPorId(int? id);
        Task GuardarEditarDetallePedido(DetallePedido detallePedido);
        Task EliminarDetallePedido(int id);
    }
}
