
function CambiarEstadoCategoria(id, nombre) {
    Swal.fire({
        title: '¿Estas seguro de cambiar el estado de la categoría '+nombre+'?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/ProductosCategoria/CambiarEstadoCategoria/" + id;          
        }
    });
};


function CambiarEstadoProductos(id, nombre) {
    Swal.fire({
        title: '¿Estas seguro de cambiar el estado del producto ' + nombre + '?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/ProductosCategoria/CambiarEstadoProducto/" + id;
        }
    });
};


function CambiarEstadoCaracteristica(id) {
    Swal.fire({
        title: '¿Estas seguro de cambiar el estado de la característica?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/Caracteristicas/CambiarEstadoCaracteristica/" + id;
        }
    });
};


function CambiarEstadoGenero(id, nombre) {
    Swal.fire({
        title: '¿Estas seguro de cambiar el estado del género ' + nombre + '?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/GenerosIlustracions/CambiarEstadoGenero/" + id;
        }
    });
};

function CambiarEstadoIlustracion(id, nombre) {
    Swal.fire({
        title: '¿Estas seguro de cambiar el estado de la ilustración ' + nombre + '?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#ff8c29db',
        confirmButtonText: 'Cambiar Estado'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location.href = "/GenerosIlustracions/CambiarEstadoIlustracion/" + id;
        }
    });
};

