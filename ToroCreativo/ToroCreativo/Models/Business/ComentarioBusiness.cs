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
    public class ComentarioBusiness : IComentarioBusiness
    {
        private readonly DbContextToroCreativo _context;
        public  ComentarioBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }
        public List<ComentarioUsuario> ObtenerComentarios(string IdUsuario)
        {
            using (_context)
            {

                List<ComentarioUsuario> ListaComentarioUsuario =
                    (from usuario in _context.Usuarios
                     join comentario in _context.Comentarios
                     on usuario.Id equals comentario.IdUsuario
                     select new ComentarioUsuario
                     {
                         IdComentario = comentario.IdComentario,
                         IdUsuario = comentario.IdUsuario,
                         Fecha = comentario.Fecha,
                         IdIlustracion = comentario.IdIlustracion,
                         Texto = comentario.Texto,
                         Correo = usuario.Email
                     }).Where(e => e.IdUsuario == IdUsuario).OrderByDescending(x => x.IdComentario).ToList();
                return (ListaComentarioUsuario);
            }
           
        }
        public List<ComentarioUsuario> ObtenerComentariosPorIlustracionAsync(int? IdIlustracion)
        {
            List<ComentarioUsuario> ListaComentarioUsuario;
             using (_context)
            {

                ListaComentarioUsuario =
                    (from usuario in _context.Usuarios
                     join comentario in _context.Comentarios
                     on usuario.Id equals comentario.IdUsuario
                     select new ComentarioUsuario
                     {
                         IdComentario=comentario.IdComentario,
                         IdUsuario=comentario.IdUsuario,
                         Fecha=comentario.Fecha,
                         IdIlustracion=comentario.IdIlustracion,
                         Texto=comentario.Texto,
                         Correo = usuario.Email
                     }).Where(e => e.IdIlustracion == IdIlustracion).OrderByDescending(x => x.IdComentario).ToList();
                
                
            }
            return (ListaComentarioUsuario);

        }
        public async Task CrearEditarComentario(Comentario comentario)
        {
            try
            {
                if (comentario.IdComentario == 0)
                    _context.Add(comentario);
                else

                    _context.Update(comentario);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();

            }
        }


    }
    
}
