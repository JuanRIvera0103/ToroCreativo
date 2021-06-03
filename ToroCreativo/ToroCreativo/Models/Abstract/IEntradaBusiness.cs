using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IEntradaBusiness
    {
        Task<int> GuardarEditarEntrada(Entrada entrada);
        Task<List<EntradaDetalle>> ObtenerEntradaProducto(int? id);
        Task<Entrada> ObtenerEntradaPorId(int? id);
        Task<List<Entrada>> ObtenerEntradaPorIdCaracteristica(int? id);
    }
}
