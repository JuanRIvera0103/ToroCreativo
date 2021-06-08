using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IComentarioBusiness
    {
        List<ComentarioUsuario> ObtenerComentarios(string IdUsuario);
        List<ComentarioUsuario> ObtenerComentariosPorIlustracionAsync(int? IdIlustracion);
        Task CrearEditarComentario(Comentario comentario);
    }
}
