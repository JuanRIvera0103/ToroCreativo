using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<Usuario> _userManager;

        public ClienteBusiness(DbContextToroCreativo context, UserManager<Usuario> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IEnumerable<ClienteDetalle>> ObtenerCliente()
        {


            await using (_context)
            {

                IEnumerable<ClienteDetalle> ListaClientesDetalles =
                    (from usuario in _context.Usuarios
                     join cliente in _context.Clientes
                     on usuario.Id equals cliente.IdUsuario
                     select new ClienteDetalle
                     {
                         IdCliente = cliente.IdCliente,
                         Correo = usuario.Email,
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

        public async Task<ClienteDetalle> ObtenerClienteDetalle(int? id)
        {


            await using (_context)
            {

                ClienteDetalle ClientesDetalles =
                    (from usuario in _context.Usuarios
                     join cliente in _context.Clientes
                     on usuario.Id equals cliente.IdUsuario
                     select new ClienteDetalle
                     {
                         IdCliente = cliente.IdCliente,
                         Correo = usuario.Email,
                         Nombre = cliente.Nombre,
                         Estado = cliente.Estado,
                         Apellido = cliente.Apellido,
                         Cedula = cliente.Cedula,
                         Direccion = cliente.Direccion,
                         Telefono = cliente.Telefono,
                         IdUsuario = cliente.IdUsuario,
                     }).FirstOrDefault(e => e.IdCliente == id);
                return (ClientesDetalles);
            }
        }
        public async Task<Cliente> ObtenerClienteDetallePorUsuario(string id)
        {


            Cliente cliente;
            cliente = null;

            if (id == null)
            {
                return cliente;
            }
            else
            {
                cliente = await _context.Clientes.FirstOrDefaultAsync(e => e.IdUsuario == id);
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
            return await _userManager.Users.ToListAsync(); 

        }

    }

}

    
