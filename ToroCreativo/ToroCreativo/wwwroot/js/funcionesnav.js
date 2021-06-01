var notificaciones = document.getElementById('notificaciones-box');
var notificacion = document.getElementById('notificacion');
var notificaciones_active = false;



function mostrarnoti() {
    if (notificaciones_active) {
        notificaciones.style.height = '0px';
        notificaciones.style.opacity = 0;
        notificacion.style.backgroundColor = 'transparent';
        notificaciones_active = false;
    } else {       
        notificaciones.style.height = '500px';
        notificaciones.style.opacity = 1;
        notificacion.style.backgroundColor = 'rgba(255, 236, 194, 0.824)';
        notificaciones_active = true;
    }
}
