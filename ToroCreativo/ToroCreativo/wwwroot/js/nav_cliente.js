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
        cuenta.style.height = '320px';
        cuenta.style.opacity = 1;
        user.style.backgroundColor = 'rgba(255, 236, 194, 0.824)';
        cuenta_active = true;
    }
}

var carrito = document.getElementById('carrito-box');
var shop = document.getElementById('shop');
var carrito_active = false;

function mostrarcarrito() {
    if (carrito_active) {
        carrito.style.height = '0px';
        carrito.style.opacity = 0;
        shop.style.backgroundColor = 'transparent';
        carrito_active = false;
    } else {
        carrito.style.height = '460px';
        carrito.style.opacity = 1;
        shop.style.backgroundColor = 'rgba(255, 236, 194, 0.824)';
        carrito_active = true;
    }
}