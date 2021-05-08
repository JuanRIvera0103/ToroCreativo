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
        
        Task<Usuario> ObtenerUsuarioPorID(string id);
        
        Task CambiarEstadoUsuario(Usuario usuario);
        int VerificarUsuarioPedidos(string id);


    }
}
