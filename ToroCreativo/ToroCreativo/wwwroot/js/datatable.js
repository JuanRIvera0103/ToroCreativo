//primera tabla
$(document).ready(function () {
    $('#tabla').DataTable({
        "language": {
            "lengthMenu": "Mostrar _MENU_ registros",
            "zeroRecords": "No se encontraron resultados",
            "info": "_START_ - _END_ de _TOTAL_ registros",
            // "info": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "infoEmpty": "Mostrando registros del 0 al 0 de un total de 0",
            // "infoFiltered": "(filtrado de un total de _MAX_ registros)",
            "infoFiltered": "",
            "sSearch": "Buscar",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior",
            },
            "sProcessing": "Procesando...",
        }
    });
});


//segunda tabla
$(document).ready(function () {
    $('#tabla2').DataTable({
        "language": {
            "lengthMenu": "Mostrar _MENU_ registros",
            "zeroRecords": "No se encontraron resultados",
            "info": "_START_ - _END_ de _TOTAL_ registros",
            // "info": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "infoEmpty": "Mostrando registros del 0 al 0 de un total de 0",
            // "infoFiltered": "(filtrado de un total de _MAX_ registros)",
            "infoFiltered": "",
            "sSearch": "Buscar",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior",
            },
            "sProcessing": "Procesando...",
        }
    });
});


//tercer tabla
$(document).ready(function () {
    $('#tabla3').DataTable({
        "order": [[0, "desc"]],
        "language": {
            "lengthMenu": "Mostrar _MENU_ registros",
            "zeroRecords": "No se encontraron resultados",
            "info": "_START_ - _END_ de _TOTAL_ registros",
            // "info": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "infoEmpty": "Mostrando registros del 0 al 0 de un total de 0",
            // "infoFiltered": "(filtrado de un total de _MAX_ registros)",
            "infoFiltered": "",
            "sSearch": "Buscar",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior",
            },
            "sProcessing": "Procesando...",
        }
    });
});

// Cuarta tabla
$(document).ready(function () {
    $('#tabla4').DataTable({
        "language": {
            "lengthMenu": "Mostrar _MENU_ registros",
            "zeroRecords": "No se encontraron resultados",
            "info": "_START_ - _END_ de _TOTAL_ registros",
            // "info": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "infoEmpty": "Mostrando registros del 0 al 0 de un total de 0",
            // "infoFiltered": "(filtrado de un total de _MAX_ registros)",
            "infoFiltered": "",
            "sSearch": "Buscar",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior",
            },
            "sProcessing": "Procesando...",
        }
    });
});
