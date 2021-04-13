using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IEntradaBusiness
    {
        Task GuardarEditarEntrada(Entrada entrada);
        Task<List<Entrada>> ObtenerEntradaProducto(int? id);
        Task<Entrada> ObtenerEntradaPorId(int? id);
    }
}
