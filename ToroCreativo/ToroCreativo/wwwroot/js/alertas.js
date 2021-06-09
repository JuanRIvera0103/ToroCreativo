
function CambiarEstadoCategoria(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de cambiar el estado de la categoría '+nombre+'?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/ProductosCategoria/CambiarEstadoCategoria/" + id;          
        }
    });
};


function CambiarEstadoProductos(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de cambiar el estado del producto ' + nombre + '?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/ProductosCategoria/CambiarEstadoProducto/" + id;
        }
    });
};


function CambiarEstadoCaracteristica(id) {
    Swal.fire({
        title: '¿Estás seguro de cambiar el estado de la característica?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/Caracteristicas/CambiarEstadoCaracteristica/" + id;
        }
    });
};


function CambiarEstadoGenero(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de cambiar el estado del género ' + nombre + '?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/GenerosIlustracions/CambiarEstadoGenero/" + id;
        }
    });
};

function CambiarEstadoIlustracion(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de cambiar el estado de la ilustración ' + nombre + '?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/GenerosIlustracions/CambiarEstadoIlustracion/" + id;
        }
    });
};

function CambiarEstadoUsuario(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de cambiar el estado del usuario ' + nombre + '?',
        icon: 'warning',
        text: 'Si se deshabilita el usuario, este no podrá acceder a su cuenta hasta que se habilite de nuevo',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/Usuarios/CambiarEstado/" + id;
        }
    });
};

function CambiarEstadoCliente(id, nombre) {
    Swal.fire({
        title: '¿Estás seguro de cambiar el estado del cliente ' + nombre + '?',
        icon: 'warning',
        text: 'Si se deshabilita el cliente, este no podrá realizar ningún pedido hasta que se habilite de nuevo',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/Clientes/CambiarEstado/" + id;
        }
    });
};
