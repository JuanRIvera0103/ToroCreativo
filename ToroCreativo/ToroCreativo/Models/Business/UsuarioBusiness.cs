using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.Clases;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Business
{
    public class UsuarioBusiness:IUsuarioBusiness
    {
        private readonly DbContextToroCreativo _context;

        public UsuarioBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UsuarioDetalle>> ObtenerUsuario()
        {
            

            await using (_context)
            {

                IEnumerable<UsuarioDetalle> ListaUsuarioDetalles =
                    (from usuario in _context.Usuarios
                     join rol in _context.Roles
                     on usuario.Rol equals rol.IdRol
                     select new UsuarioDetalle
                     {
                         IdUsuario = usuario.IdUsuario,
                         Correo = usuario.Correo,
                         Contraseña = usuario.Contraseña,
                         Estado = usuario.Estado,
                         Rol = rol.NombreRol
                     }).ToList();
                return (ListaUsuarioDetalles);
            }
        }

        public async Task<Usuario> ObtenerUsuarioPorID(int? id)
        {
            Usuario usuario;
            usuario = null;

            if(id == null)
            {
                return usuario;
            }else
            {
                usuario = await _context.Usuarios.FirstOrDefaultAsync(e => e.IdUsuario == id);
                return usuario;
            }
        }

        public async Task GuardarEditarUsuario(Usuario usuario)
        {
            try
            {
                if (usuario.IdUsuario == 0)
                    _context.Add(usuario);
                else
                    _context.Update(usuario);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw  new Exception();
            }


        }

        public async Task<IEnumerable<Rol>> ObtenerRol() 
        {
            return await _context.Roles.ToArrayAsync();  

        }

        public async Task CambiarEstadoUsuario(Usuario usuario)
        {
            try
            {
                if (usuario.Estado.Equals("Habilitado"))
                    usuario.Estado = "Deshabilitado";
                else
                    usuario.Estado = "Habilitado";

                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

    }

}
