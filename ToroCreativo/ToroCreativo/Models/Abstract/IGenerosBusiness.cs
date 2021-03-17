using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IGenerosBusiness
    {
        Task<List<Generos>> ObtenerGeneros();
        Task<Generos> ObtenerGeneroPorId(int? id);
        Task GuardarEditarGeneros(Generos generos);
        Task CambiarEstadoGenero(Generos generos);
    }
}
