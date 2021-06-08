using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToroCreativo.Models.Entities;

namespace ToroCreativo.Models.Abstract
{
    public interface INotificacionesBusiness
    {
        List<Notificacion> ObtenerNotificaciones(string IdUsuario, bool bIsGetOnlyUnread);
        public List<Notificacion> ObtenerNotificacionesAdmin();
        Task CrearNotificacion(Notificacion notificacion);
    }
}
