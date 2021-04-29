using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Clases;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ToroCreativo.Models.Business
{
    public class UsuarioBusiness:IUsuarioBusiness
    {
        private readonly DbContextToroCreativo _context;
        private readonly UserManager<Usuario> _userManager;

        public UsuarioBusiness(DbContextToroCreativo context, UserManager<Usuario> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

       
        public async Task<Usuario> ObtenerUsuarioPorID(string id)
        {
            Usuario usuario;
            usuario = null;

            if(id == null)
            {
                return usuario;
            }else
            {
                usuario = await _context.Usuarios.FirstOrDefaultAsync(e => e.Id == id);
                return usuario;
            }
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
