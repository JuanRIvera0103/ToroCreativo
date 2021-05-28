function AceptarPedido(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de aceptar el pedido seleccionado de ' + nombre + '?',
        icon: 'warning',
        iconColor: '#0be881',
        showCancelButton: true,
        confirmButtonColor: '#0be881',
        confirmButtonText: 'Aceptar Pedido'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/Pedidos/AceptarPedido/" + id;
        }
    });
};

function CancelarPedido(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de cancelar el pedido seleccionado de ' + nombre + '?',
        icon: 'warning',
        iconColor: '#ff6b6b',
        showCancelButton: true,
        confirmButtonColor: '#ff6b6b',
        confirmButtonText: 'Cancelar Pedido'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/Pedidos/CancelarPedido/" + id;
        }
    });
};

function PedidoPagado(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de cambiar el estado del pedido seleccionado de ' + nombre + ' a pagado?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Pagado'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/Pedidos/PedidoAVenta/" + id;
        }
    });
};

function EnviarVenta(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de enviar la venta seleccionada de ' + nombre + '?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Enviar'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/Pedidos/VentaSinEnviarAVentaEnviada/" + id;
        }
    });
};