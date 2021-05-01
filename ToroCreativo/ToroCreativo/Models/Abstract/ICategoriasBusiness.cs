using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface ICategoriasBusiness
    {
        Task<List<Categorias>> ObtenerCategorias();
        Task<IEnumerable<Categorias>> ObtenerCategoriasSelect();
        Task<Categorias> ObtenerCategoriaPorId(int? id);
        Task<int> GuardarEditarCategorias(Categorias categorias);
        Task CambiarEstadoCategoria(Categorias categorias);
        Task<int> VerificarProductosHabilitados(int? id);

        }
}
