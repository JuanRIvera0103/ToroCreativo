var notificaciones = document.getElementById('notificaciones-box');
var notificacion = document.getElementById('notificacion');
var notificaciones_active = false;

var cuenta = document.getElementById('cuenta-box');
var user = document.getElementById('user');
var cuenta_active = false;


function mostrarnoti() {
    if (notificaciones_active) {
        notificaciones.style.height = '0px';
        notificaciones.style.opacity = 0;
        notificacion.style.backgroundColor = 'transparent';
        notificaciones_active = false;
    } else {
        if (cuenta_active) {
            cuenta.style.height = '0px';
            cuenta.style.opacity = 0;
            user.style.backgroundColor = 'transparent';
            cuenta_active = false;
        }
        notificaciones.style.height = '500px';
        notificaciones.style.opacity = 1;
        notificacion.style.backgroundColor = 'rgba(255, 236, 194, 0.824)';
        notificaciones_active = true;
    }
}


function mostrarcuenta() {
    if (cuenta_active) {
        cuenta.style.height = '0px';
        cuenta.style.opacity = 0;
        user.style.backgroundColor = 'transparent';
        cuenta_active = false;
    } else {
        if (notificaciones_active) {
            notificaciones.style.height = '0px';
            notificaciones.style.opacity = 0;
            notificacion.style.backgroundColor = 'transparent';
            notificaciones_active = false;
        }
        cuenta.style.height = '160px';
        cuenta.style.opacity = 1;
        user.style.backgroundColor = 'rgba(255, 236, 194, 0.824)';
        cuenta_active = true;
    }
}
