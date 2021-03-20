using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IUsuarioBusiness
    {
         Task<IEnumerable<UsuarioDetalle>> ObtenerUsuario();
        Task<Usuario> ObtenerUsuarioPorID(int? id);
        Task GuardarEditarUsuario(Usuario usuario);
        Task<IEnumerable<Rol>> ObtenerRol();
        Task CambiarEstadoUsuario(Usuario usuario);
        
    }
}
