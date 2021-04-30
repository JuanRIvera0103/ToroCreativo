function CambiarEstadoRegistro() {
    return confirm("¿Deseas cambiarle el estado al registro?");   
};

function CrearRegistro() {
    swal("Se creo!", "You clicked the button!", "success");
}
function EditarRegistro() {
    swal("Se edito!", "You clicked the button!", "success");
}

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

