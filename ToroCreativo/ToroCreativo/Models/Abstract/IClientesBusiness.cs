using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface IClientesBusiness
    {
        //Task<IEnumerable<ClienteDetalle>> ObtenerCliente();
        Task<Cliente> ObtenerClientePorID(int? id);
        Task CambiarEstadoCliente(Cliente cliente);
        Task CrearEditarCliente(Cliente cliente);
        Task<IEnumerable<Usuario>> ObtenerUsuario();
    }
}
