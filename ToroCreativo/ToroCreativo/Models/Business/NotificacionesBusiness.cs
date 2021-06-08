using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Abstract;
using ToroCreativo.Models.DAL;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Business
{
    public class NotificacionesBusiness : INotificacionesBusiness
    {
        private readonly DbContextToroCreativo _context;

        public NotificacionesBusiness(DbContextToroCreativo context)
        {
            _context = context;
        }
        public List<Notificacion> ObtenerNotificaciones(string IdUsuario, bool bIsGetOnlyUnread)
        {
           return  _context.Notificaciones.Where(e => e.IdUsuario == IdUsuario).OrderByDescending(x => x.IdNotificacion).ToList();
        }
        public List<Notificacion> ObtenerNotificacionesAdmin()
        {
            return _context.Notificaciones.Where(e => e.Tipo =="Pendiente" || e.Tipo == "Comentario" || e.Tipo=="CanceladoAdmin" || e.Tipo=="Comprobante").OrderByDescending(x => x.IdNotificacion).ToList();
        }
        public async Task CrearNotificacion(Notificacion notificacion)
        {
             _context.Add(notificacion);
            await _context.SaveChangesAsync();
        }
    }
}
