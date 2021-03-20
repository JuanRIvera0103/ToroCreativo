using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Clases;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Business
{
    public class ClienteBusiness:IClientesBusiness
    {
        private readonly DbContextToroCreativo _context;

        public ClienteBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClienteDetalle>> ObtenerCliente()
        {


            await using (_context)
            {

                IEnumerable<ClienteDetalle> ListaClientesDetalles =
                    (from usuario in _context.Usuarios
                     join cliente in _context.Clientes
                     on usuario.IdUsuario equals cliente.IdUsuario
                     select new ClienteDetalle
                     {
                         IdCliente = cliente.IdCliente,
                         Correo = usuario.Correo,
                         Nombre = cliente.Nombre,
                         Estado = cliente.Estado,
                         Apellido = cliente.Apellido,
                         Cedula = cliente.Cedula,
                         Direccion=cliente.Direccion,
                         Telefono=cliente.Telefono
                     }).ToList();
                return (ListaClientesDetalles);
            }
        }

        public async Task<Cliente> ObtenerClientePorID(int? id)
        {
            Cliente cliente;
            cliente = null;

            if (id == null)
            {
                return cliente;
            }
            else
            {
                cliente = await _context.Clientes.FirstOrDefaultAsync(e => e.IdCliente == id);
                return cliente;
            }
        }

       

        public async Task CambiarEstadoCliente(Cliente cliente)
        {
            try
            {
                if (cliente.Estado.Equals("Habilitado"))
                    cliente.Estado = "Deshabilitado";
                else
                    cliente.Estado = "Habilitado";

                _context.Clientes.Update(cliente);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
        public async Task CrearEditarCliente(Cliente cliente)
        {
            try
            {
                if (cliente.IdCliente == 0)
                    _context.Add(cliente);
                else

                    _context.Update(cliente);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();

            }

        }

        public async Task<IEnumerable<Usuario>> ObtenerUsuario()
        {
            return await _context.Usuarios.ToArrayAsync();

        }

    }

}

    
